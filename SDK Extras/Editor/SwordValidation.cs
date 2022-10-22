using SLZ.Combat;
using SLZ.Interaction;
using SLZ.Props.Weapons;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SwordValidation
{
    [MenuItem("Tools/Validate Sword prefab")]
    public static void ValidateSwordPrefab()
    {
        var prefab = PrefabStageUtility.GetCurrentPrefabStage();
        if (prefab == null)
        {
            EditorUtility.DisplayDialog("No prefab open", "Please open a prefab to use this tool", "Ok");
            return;
        }

        var results = new List<ValidationResult>();
        var gameObject = prefab.prefabContentsRoot;

        results.Add(new ValidationResult
        {
            Testcase = "Stab Slash Script have at least 1 Stab Points or 1 Slash Blades",
            Success = () => {
                var stabPoints = gameObject.GetComponent<StabSlash>().stabPoints.Length;
                var slashBlades = gameObject.GetComponent<StabSlash>().slashBlades.Length;
                if (stabPoints == 0 && slashBlades == 0) return false;
                return stabPoints > 0 || slashBlades > 0;
            }
        });

        results.Add(new ValidationResult
        {
            Testcase = "Each collider object except grips should be set on Dynamic layer",
            Success = () => {
                var gameObjects = gameObject.GetComponentsInChildren<Collider>()
                    .Select(s => s.gameObject)
                    .Where(s => s.gameObject.GetComponent<Grip>() == null)
                    .Distinct();
                var layer = LayerMask.NameToLayer("Dynamic");
                return gameObjects.All(go => go.layer == layer);
            }
        });

        results.Add(new ValidationResult
        {
            Testcase = "WeaponSlot has InteractableHost",
            Success = () => {
                var bladeHost = gameObject.GetComponentInChildren<WeaponSlot>()?.interactableHost;
                if (bladeHost == null) return false;
                return bladeHost == gameObject.GetComponent<InteractableHost>();
            }
        });

        results.Add(new ValidationResult
        {
            Testcase = "WeaponSlot has Grip",
            Success = () => {
                var bladeGrip = gameObject.GetComponentInChildren<WeaponSlot>()?.grip;
                if (bladeGrip == null) return false;
                var grips = gameObject.GetComponentsInChildren<Grip>();
                foreach (var grip in grips)
                {
                    if (bladeGrip == gameObject.GetComponentInChildren<Grip>())
                    {
                        return true;
                    }
                }
                return false;
            }
        });

        results.AddRange(SharedValidation.SharedValidationRules());

        ValidationResult.DisplayResults(results);
    }
}
