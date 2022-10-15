using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using static PlasticGui.GetProcessName;

namespace MetaFileUpdater
{
    public static class Program
    {
        const string guidIdentifier = "guid: ";

        static string rootAssetsFolderOriginal;
        static string rootAssetsFolderNew;
        static bool autoFix;
        static bool autoFixedAny = false;


        static Dictionary<string, string> replacableGuids = new Dictionary<string, string>();
        static Dictionary<string, string> guidsWithoutLocalReplacement = new Dictionary<string, string>();


        public static void WriteLine(string arg) => UnityEngine.Debug.Log(arg);
        public static void WriteWarning(string arg) => UnityEngine.Debug.LogWarning(arg);
        public static void WriteError(string arg) => UnityEngine.Debug.LogError(arg);

        public static string Fix(string rootAssetsFolderOriginal, string rootAssetsFolderNew, bool autoFix)
        {
            Program.rootAssetsFolderOriginal = rootAssetsFolderOriginal;
            Program.rootAssetsFolderNew = rootAssetsFolderNew;
            Program.autoFix = autoFix;

            replacableGuids.Clear();
            guidsWithoutLocalReplacement.Clear();
            autoFixedAny = false;

            //Get all the meta files
            string[] consideredExtensions = new string[]{
                //".cs",
                //".asset",
                //".mixer",
                "",
            };

            var foundFiles = 0;
            consideredExtensions.ToList().ForEach(extension =>
            {
                string[] oldMetaFilePaths = Directory.GetFiles(rootAssetsFolderOriginal, $"*{extension}.meta", SearchOption.AllDirectories);
                string[] newMetaFilePaths = Directory.GetFiles(rootAssetsFolderNew, $"*{extension}.meta", SearchOption.AllDirectories);
                foundFiles += oldMetaFilePaths.Length;
                FindReplacementGUIDs(oldMetaFilePaths, newMetaFilePaths);
            });

            WriteLine($"Found {foundFiles} meta files in original directory");

            string[] consideredLocalExtensionsToReplace = new string[]{
                //"*.prefab",
                //"*.asset",
                //"*.mat",
                "*",
            };

            var fixedAtLeastOnce = false;
            do {
                autoFixedAny = false;
                var localPaths = consideredLocalExtensionsToReplace.SelectMany(extension =>
                    Directory.GetFiles(rootAssetsFolderNew, extension, SearchOption.AllDirectories)
                )
                .Distinct()
                .ToArray();

                ReplaceGUIDs(localPaths);
                if (autoFixedAny) fixedAtLeastOnce = true;
            } while (autoFixedAny);

            if (fixedAtLeastOnce) {
                AssetDatabase.Refresh();
            }

            return "Success. Meta files fixed";
        }

        private static string GetGuidFromMetaPath(string path)
        {
            using (StreamReader reader = new StreamReader(path)) {
                while (reader.Peek() >= 0) {
                    string currentLine = reader.ReadLine();
                    if (currentLine.StartsWith(guidIdentifier)) {
                        return currentLine.Split(new string[] { guidIdentifier }, StringSplitOptions.None)[1];
                    }
                }
            }
            return null;
        }

        private static void FindReplacementGUIDs(string[] oldMetaFiles, string[] newMetaFiles)
        {
            for (int i = 0; i < oldMetaFiles.Length; i++) {
                string oldGUID = GetGuidFromMetaPath(oldMetaFiles[i]);
                if (oldGUID == null)
                    continue;

                //Try to find a new meta file with the same name
                string correspondingNewMetaFile = FindMatchingFile(newMetaFiles, Path.GetFileName(oldMetaFiles[i]));
                if (correspondingNewMetaFile == null) {
                    if (!guidsWithoutLocalReplacement.ContainsKey(oldGUID)) {
                        guidsWithoutLocalReplacement.Add(oldGUID, oldMetaFiles[i]);
                    }
                    continue;
                }

                string newGUID = GetGuidFromMetaPath(correspondingNewMetaFile);

                if (newGUID == null)
                    continue;

                //Add the guids to the dictionary
                if (!replacableGuids.ContainsKey(oldGUID) && oldGUID != newGUID)
                    replacableGuids.Add(oldGUID, newGUID);
            }

            WriteLine($"Found replacement GUIDs for {replacableGuids.Count} meta files");
            WriteLine($"Found {guidsWithoutLocalReplacement.Count} meta files without local replacement");
        }

        private static string FindMatchingFile(string[] filesToSearch, string fileName)
        {
            for (int i = 0; i < filesToSearch.Length; i++) {
                if (Path.GetFileName(filesToSearch[i]) == fileName)
                    return filesToSearch[i];
            }

            return null;
        }

        private static void ReplaceGUIDs(string[] prefabPaths)
        {
            for (int i = 0; i < prefabPaths.Length; i++) {
                var guidsToReplace = new List<string>();
                // This is much more efficient than reading the whole file to work out if it's a viable yaml file for replacement
                using (StreamReader reader = new StreamReader(prefabPaths[i])) {
                    if (reader?.ReadLine()?.StartsWith("%YAML") != true)
                        continue;
                }

                File.ReadAllLines(prefabPaths[i]).ToList().ForEach(line => {
                    foreach (var part in line.Split(guidIdentifier).Skip(1)) {
                        //Get the existing guid
                        string currentGUID = part.Substring(0, 32);
                        //Add the guid to a list to be replaced if it exists in the dictionary
                        if (replacableGuids.TryGetValue(currentGUID, out string newGUID)) {
                            guidsToReplace.Add(currentGUID);
                        } else if (guidsWithoutLocalReplacement.TryGetValue(currentGUID, out var originalPath)) {
                            if (autoFix) {
                                var path = originalPath.TrimStart(rootAssetsFolderOriginal);
                                Directory.CreateDirectory($"{Path.GetDirectoryName($"{rootAssetsFolderNew}/{path}")}");
                                try {
                                    File.Copy(originalPath, $"{rootAssetsFolderNew}/{path}");
                                    File.Copy(originalPath.TrimEnd(".meta"), $"{rootAssetsFolderNew}/{path.TrimEnd(".meta")}");
                                    WriteWarning($"Copied {rootAssetsFolderNew}/{path.TrimEnd(".meta")}");
                                    autoFixedAny = true;
                                } catch (Exception e) {
                                    if (e.Message.Contains("already exists") == false) {
                                        WriteWarning($"Failed to copy {rootAssetsFolderNew}/{path.TrimEnd(".meta")}: {e.Message}");
                                    }
                                }
                                continue;
                            }
                            var msg = $"Asset detected in original directory that does not exist locally: {originalPath}";
                            if (originalPath.EndsWith(".cs.meta")) {
                                WriteError(msg);
                            } else {
                                WriteWarning(msg);
                            }
                        }
                    }
                });

                if (guidsToReplace.Count > 0)
                {
                    //Read the entire prefab file
                    string fileData = File.ReadAllText(prefabPaths[i]);

                    //Replace all guids with the new ones
                    for (int j = 0; j < guidsToReplace.Count; j++)
                    {
                        string currentGUID = guidsToReplace[j];
                        string newGUID = replacableGuids[guidsToReplace[j]];
                        fileData = fileData.Replace(currentGUID, newGUID);
                        WriteLine($"Replacing {currentGUID} with {newGUID} in {Path.GetFileName(prefabPaths[i])}");
                    }

                    //Write the modified text back to the prefab file
                    File.WriteAllText(prefabPaths[i], fileData);
                }
            }
        }
    }
}