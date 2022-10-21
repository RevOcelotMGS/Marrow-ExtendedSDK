using SLZ.Interaction;
using SLZ.Props.Weapons;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEditor;
using UnityEngine;
using System.Linq;

public class MagazineValidation {
    [MenuItem("Tools/Validate Magazine Prefab")]
    public static void ValidateMagazinePrefab()
    {
        var prefab = PrefabStageUtility.GetCurrentPrefabStage();
        if (prefab == null) {
            EditorUtility.DisplayDialog("No prefabs open", "Please open a prefab to use this tool", "Ok");
            return;
        }

        var results = new List<ValidationResult>();
        var gameObject = prefab.prefabContentsRoot;


        results.AddRange(SharedValidation.SharedValidationRules());

        ValidationResult.DisplayResults(results);
    }
}
