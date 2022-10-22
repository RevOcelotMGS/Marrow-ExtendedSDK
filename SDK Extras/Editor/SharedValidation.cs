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

public class SharedValidation {

    public static List<ValidationResult> SharedValidationRules() {
        var results = new List<ValidationResult>();
        var gameObject = PrefabStageUtility.GetCurrentPrefabStage().prefabContentsRoot;

        results.Add(new ValidationResult {
            Testcase = "Root has InteractableHost",
            Success = () => gameObject.GetComponent<InteractableHost>() != null
        });

        results.Add(new ValidationResult {
            Testcase = "All Grip's AdditionalGripColliders are valid",
            Success = () => gameObject.GetComponentsInChildren<Grip>().SelectMany(g => g.additionalGripColliders).All(c => c != null)
        });

        results.Add(new ValidationResult {
            Testcase = "Sockets are all on the Socket layer",
            Success = () => {
                var parents = gameObject.GetComponentsInChildren<Socket>().Select(s => s.gameObject).Distinct();
                var layer = LayerMask.NameToLayer("Socket");
                return parents.All(go => go.layer == layer);
            }
        });

        results.Add(new ValidationResult {
            Testcase = "Sockets have InteractableHost set",
            Success = () => {
                var sockets = gameObject.GetComponentsInChildren<Socket>();
                return sockets.All(s => s.host != null);
            }
        });

        results.Add(new ValidationResult {
            Testcase = "Plugs have InteractableHost set",
            Success = () => {
                var plugs = gameObject.GetComponentsInChildren<Plug>();
                return plugs.All(p => p.host != null);
            }
        });

        results.Add(new ValidationResult {
            Testcase = "Grips have hand poses",
            Success = () => {
                var grips = gameObject.GetComponentsInChildren<Grip>();
                return grips.All(g => g.handPose != null);
            }
        });

        results.Add(new ValidationResult {
            Testcase = "Force pull grips have grips to use",
            Success = () => {
                var parents = gameObject.GetComponentsInChildren<ForcePullGrip>().Select(s => s.gameObject).Distinct();
                return parents.All(go => go.GetComponents<Grip>().Length > 0);
            }
        });


        // Recommended

        results.Add(new ValidationResult {
            Testcase = "Recommended: Grips are all on the Interactable layer",
            Success = () => {
                var parents = gameObject.GetComponentsInChildren<Grip>().Select(s => s.gameObject).Distinct();
                var layer = LayerMask.NameToLayer("Interactable");
                return parents.All(go => go.layer == layer);
            }
        });

        results.Add(new ValidationResult {
            Testcase = "Best Practice: Root shouldn't have RigidBody, Art, Colliders etc",
            Success = () => {
                if (gameObject.GetComponent<MeshRenderer>()) return false;
                if (gameObject.GetComponent<Collider>()) return false;
                if (gameObject.GetComponent<Rigidbody>()) return false;
                if (gameObject.GetComponent<RigidbodyProjectile>()) return false;
                return true;
            }
        });

        return results;
    }
}


#endif