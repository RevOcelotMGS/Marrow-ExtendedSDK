using SLZ.Interaction;
using SLZ.Props.Weapons;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEditor;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

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

        results.Add(new ValidationResult {
            Testcase = "Magazine script has InteractableHost set",
            Success = () => {
                var magazineHost = gameObject.GetComponent<Magazine>()?.interactableHost;
                if (magazineHost == null) return false;
                return magazineHost == gameObject.GetComponent<InteractableHost>();
            }
        });

        results.Add(new ValidationResult {
            Testcase = "Magazine has magazine data",
            Success = () => {
                var magazine = gameObject.GetComponent<Magazine>()?.magazineState?.magazineData;
                return magazine != null;
            }
        });

        results.Add(new ValidationResult {
            Testcase = "Magazine data's spawnable if known should link back to prefab",
            Success = () => {
                var spawnable = gameObject.GetComponent<Magazine>()?.magazineState?.magazineData?.spawnable;
                if (spawnable == null) return false;
                var crateRef = spawnable.Value.crateRef;
                Debug.Log(crateRef);
                if (crateRef == null) return false;
                if (crateRef.TryGetCrate(out var crate)) {
                    if (gameObject.name != crate.MainGameObject?.EditorAsset.name) return false;
                }

                return true;
            }
        });


        results.AddRange(SharedValidation.SharedValidationRules());

        ValidationResult.DisplayResults(results);
    }
}
