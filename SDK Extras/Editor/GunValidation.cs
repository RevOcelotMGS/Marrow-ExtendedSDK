#if UNITY_EDITOR
using Cysharp.Threading.Tasks;
using SLZ.Interaction;
using SLZ.Props.Weapons;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GunValidation {

    [MenuItem("Tools/Validate Gun Prefab")]
    public static void ValidateGunPrefab() {
        var prefab = PrefabStageUtility.GetCurrentPrefabStage();
        if (prefab == null) {
            EditorUtility.DisplayDialog("No prefabs open", "Please open a prefab to use this tool", "Ok");
            return;
        }

        var results = new List<ValidationResult>();
        var gameObject = prefab.prefabContentsRoot;

        results.Add(new ValidationResult {
            Testcase = "Gun script has InteractableHost set",
            Success = () => {
                var gunHost = gameObject.GetComponent<Gun>()?.host;
                if (gunHost == null) return false;
                return gunHost == gameObject.GetComponent<InteractableHost>();
            }
        });

        results.Add(new ValidationResult {
            Testcase = "WeaponSlot script has InteractableHost set",
            Success = () => {
                var WeaponSlotHost = gameObject.GetComponentInChildren<WeaponSlot>()?.interactableHost;
                if (WeaponSlotHost == null) return false;
                return WeaponSlotHost == gameObject.GetComponent<InteractableHost>();
            }
        });

        results.Add(new ValidationResult {
            Testcase = "WeaponSlot script has Gun set",
            Success = () => {
                var WeaponSlotGun = gameObject.GetComponentInChildren<WeaponSlot>()?.gun;
                if (WeaponSlotGun == null) return false;
                return WeaponSlotGun == gameObject.GetComponent<Gun>();
            }
        });

        results.Add(new ValidationResult {
            Testcase = "WeaponSlot script has Magazine set",
            Success = () => {
                var WeaponSlotMagazine = gameObject.GetComponentInChildren<WeaponSlot>()?.magazineSocket;
                if (WeaponSlotMagazine == null) return false;
                return gameObject.GetComponentsInChildren<AmmoSocket>().Contains(WeaponSlotMagazine);
            }
        });

        results.Add(new ValidationResult {
            Testcase = "Gun's Magazine has a matching AmmoSocket Platform",
            Success = () => {
                var gun = gameObject.GetComponent<Gun>();
                var magazine = gun?.defaultMagazine ?? gun?.internalMagazine;
                if (magazine == null) return true;
                return gameObject.GetComponentsInChildren<AmmoSocket>().Any(a => a.platform == magazine.platform);
            }
        });

        results.Add(new ValidationResult {
            Testcase = "Gun has magazine data",
            Success = () => gameObject.GetComponent<Gun>()?.defaultMagazine ?? gameObject.GetComponent<Gun>()?.internalMagazine != null
        });

        results.AddRange(SharedValidation.SharedValidationRules());

        ValidationResult.DisplayResults(results);
    }
}


#endif