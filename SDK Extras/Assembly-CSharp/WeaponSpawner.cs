using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Warehouse;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
	[SerializeField]
	private bool isSpawningAllowed;

	[SerializeField]
	private bool visDebug;

	[SerializeField]
	private float initSpawnDelay;

	[SerializeField]
	private List<WeaponPack> weaponPackList;

	[SerializeField]
	private GameObject lightAmmoSpawnTarg;

	[SerializeField]
	private GameObject medAmmoSpawnTarg;

	[SerializeField]
	private GameObject heavyAmmoSpawnTarg;

	[SerializeField]
	private AssetPoolee lightAmmoPoolee;

	[SerializeField]
	private AssetPoolee medAmmoPoolee;

	[SerializeField]
	private AssetPoolee heavyAmmoPoolee;

	[SerializeField]
	private SpawnablePack defaultSpawnablePack;

	public Dictionary<string, WeaponPack> weaponPackMap;

	public Transform defSpawn;

	[SerializeField]
	private int weaponLimit;

	public Transform[] limitedSpawns;

	[SerializeField]
	private AudioClip overLimitClip;

	private Dictionary<GameObject, AssetPoolee> pooleeDict;

	public static Action<Vector2> OnCountUpdated;

	public static Action<bool> IsSpawningAllowed;

	[SerializeField]
	private AudioClip spawnClip;

	[SerializeField]
	private AudioClip despawnClip;

	[SerializeField]
	private Spawnable spawnFXSpawnable;

	[SerializeField]
	private Spawnable despawnFXSpawnable;

	[SerializeField]
	private InventorySlotReceiver[] inventorySlotRecievers;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	[ContextMenu("Spawn all WeaponPacks")]
	public void SpawnAllWeaponPacks()
	{
	}

	[ContextMenu("Despawn All WeaponPacks")]
	public void DespawnAllWeaponPacks()
	{
	}

	private void DespawnPack(WeaponPack pack)
	{
	}

	private IEnumerator CoSpawnDefaultPack()
	{
		return null;
	}

	private void SpawnDefaultSpawnablePack()
	{
	}

	private IEnumerator CoSpawnAllWeaponPacks(float delay)
	{
		return null;
	}

	private void SpawnWeaponPack(WeaponPack pack)
	{
	}

	private void OnPackGrabbed(WeaponPack pack)
	{
	}

	public void ToggleWeaponSpawning(bool enable)
	{
	}

	public void SpawnDefaultAmmo()
	{
	}

	[ContextMenu("Despawn All Ammo")]
	private void DespawnAllAmmo()
	{
	}

	private void CreateSpawnDictionary()
	{
	}

	public void OnWeaponSelected(SpawnableCrateReference scr)
	{
	}

	[ContextMenu("GetWeaponSlots")]
	public void GetWeaponSlots()
	{
	}

	public void DropAndDespawnInventory(GameObject playerObject = default(GameObject))
	{
	}

	[ContextMenu("Despawn All Weapons")]
	public void DespawnAllWeapons()
	{
	}

	public void OnTriggerEnter(Collider other)
	{
	}

	private void UpdateSpawn(Transform spawnPoint)
	{
	}

	public WeaponSpawner()
		: base()
	{
	}
}
