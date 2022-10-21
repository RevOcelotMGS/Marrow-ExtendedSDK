#if UNITY_EDITOR
using System.IO;
using UnityEngine;

[ExecuteInEditMode]
public class ExtendedSDKSetup {

    [UnityEditor.Callbacks.DidReloadScripts]
    private static void OnScriptsReloaded()
    {
        var tagAssetPath = $"{Application.dataPath}/../ProjectSettings/TagManager.asset";
        var text = File.ReadAllText(tagAssetPath);
        if (text.Contains("NoFootBall")) return;

        File.WriteAllText(tagAssetPath, "%YAML 1.1\r\n%TAG !u! tag:unity3d.com,2011:\r\n--- !u!78 &1\r\nTagManager:\r\n  serializedVersion: 2\r\n  tags:\r\n  - Conductor\r\n  - Tornado\r\n  - Butter\r\n  - Grass\r\n  - PPaint\r\n  - Freezable\r\n  - water\r\n  - SkyMasterTree\r\n  - Flamer\r\n  - Flammable\r\n  - NoForcePDM\r\n  - Road\r\n  - interactable\r\n  - WP\r\n  - Zombie\r\n  - Item\r\n  - Door\r\n  - Key\r\n  - FxTemporaire\r\n  - Level\r\n  - Pickup\r\n  - projectile\r\n  - BakeryProcessed\r\n  - Zone/SpawnTracker\r\n  - Zone/Scene\r\n  - Ship\r\n  - Attachment\r\n  - LootChute\r\n  - Metal\r\n  - VHSTape\r\n  - cartridge\r\n  - NoDamage\r\n  - Wood\r\n  - Physics\r\n  - sparks\r\n  - Glass\r\n  - CaveDungeonHide\r\n  - NoGravityGun\r\n  - carpet\r\n  - PickableItem\r\n  - Flashlight\r\n  - Elevator\r\n  - ElevatorButtonOpen\r\n  - ElevatorNumericButton\r\n  - ElevatorGoButton\r\n  - LootSpawner\r\n  - TackleBox\r\n  - GWLock\r\n  - ShipPanel\r\n  - ObjectPool\r\n  - Target\r\n  - agent\r\n  - ground\r\n  - target\r\n  - sidewall\r\n  - checkpoint\r\n  - road\r\n  - obstacle\r\n  - TrainRod\r\n  - Default\r\n  - jump\r\n  - boostpad\r\n  - goal\r\n  - boid\r\n  layers:\r\n  - Default\r\n  - TransparentFX\r\n  - Ignore Raycast\r\n  - \r\n  - Water\r\n  - UI\r\n  - \r\n  - \r\n  - Player\r\n  - NoCollide\r\n  - Dynamic\r\n  - StereoRender_Ignore\r\n  - EnemyColliders\r\n  - Static\r\n  - SpawnGunUI\r\n  - Interactable\r\n  - Hand\r\n  - HandOnly\r\n  - Socket\r\n  - Plug\r\n  - InteractableOnly\r\n  - PlayerAndNpc\r\n  - NoSelfCollide\r\n  - FeetOnly\r\n  - Feet\r\n  - NoFootBall\r\n  - Tracker\r\n  - Trigger\r\n  - \r\n  - \r\n  - \r\n  - Background\r\n  m_SortingLayers:\r\n  - name: Default\r\n    uniqueID: 0\r\n    locked: 0\r\n  - name: Background\r\n    uniqueID: 588598653\r\n    locked: 0\r\n");

    }
}
#endif