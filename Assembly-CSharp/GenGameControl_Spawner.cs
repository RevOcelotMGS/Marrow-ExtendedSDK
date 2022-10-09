using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ;
using SLZ.Marrow.Data;
using SLZ.Rig;
using UnityEngine;

public class GenGameControl_Spawner : MonoBehaviour
{
	private Arena_GameController arenaGameController;

	[SerializeField]
	private AudioClip _spawnClip;

	public int lightAmmoSpawned;

	public int medAmmoSpawned;

	public int heavyAmmoSpawned;

	[SerializeField]
	private Transform ammoSpawnTrans;

	public List<GameObject> spawnedWeaponObjList;

	public List<GameObject> despawnedWeaponObjList;

	public List<AmmoPickup> ammoPickupList;

	public AmmoPickup spawnedLightPickup;

	public AmmoPickup spawnedMedPickup;

	public AmmoPickup spawnedHeavyPickup;

	[Header("ArenaWeaponMode")]
	private RigManager rigManager;

	[SerializeField]
	private GameObject playerRelSpawnPrefab;

	[SerializeField]
	private PlayerRelativeGunSpawns playerRelGunSpawns;

	public void Awake()
	{
	}

	public void Initialize(Arena_GameController gameController)
	{
	}

	private void Start()
	{
	}

	public void SetupPlayerRelativeGunSpawns()
	{
	}

	public void SpawnWaveLoot(WaveProfile wave)
	{
	}

	private IEnumerator CoSpawnLoots(WaveProfile wave)
	{
		return null;
	}

	private IEnumerator CoSpawnWeaponModeLoots(WaveProfile wave)
	{
		return null;
	}

	public void DespawnLootWeapons(bool despawnAll)
	{
	}

	public void ForceCollectAllAmmo()
	{
	}

	public GenGameControl_Spawner()
		: base()
	{
	}
}
