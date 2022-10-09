using System.Collections.Generic;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

[ExecuteAlways]
public class StaticProfiles : ScriptableObject
{
	[Header("Leaderboards")]
	public List<LeaderboardData> leaderboardData;

	[Header("NPC Profiles")]
	public List<EnemyProfile> enemyProfileList;

	public List<EnemyProfile> friendlyProfileList;

	public List<EnemyProfile> easyEnemyList;

	public List<EnemyProfile> medEnemyList;

	public List<EnemyProfile> hardEnemyList;

	[Header("Loot Profiles")]
	public List<ArenaLootItem> sidearmLootList;

	public List<ArenaLootItem> smgLootList;

	public List<ArenaLootItem> rifleLootList;

	public List<ArenaLootItem> shotgunLootList;

	public List<ArenaLootItem> bluntLootList;

	public List<ArenaLootItem> bladeLootList;

	[Header("Prefabs")]
	public GameObject displayPrefab_TimeTrial;

	public GameObject displayPrefab_Linear;

	public GameObject displayPrefab_Arena;

	public GameObject LinkDataManagerPrefab;

	[Header("Spawnable Crates")]
	public Spawnable lightAmmoSpawnable;

	public Spawnable medAmmoSpawnable;

	public Spawnable heavyAmmoSpawnable;

	public Spawnable crownSpawnable;

	[Header("Loot Tables")]
	public LootTableData lightAmmoLootTable;

	public LootTableData medAmmoLootTable;

	public CartridgeData defaultLightCartridge;

	public CartridgeData defaultMediumCartridge;

	public CartridgeData defaultHeavyCartridge;

	[Header("Alliance Data")]
	public List<AllianceData> allyData;

	private static StaticProfiles Instance;

	public static string path;

	public static string linearGCPrefabPath;

	public static string timeTrialGCPrefabPath;

	public static string arenaGCPrefabPath;

	private List<SpawnableCrateReference> sidearmCrateList;

	private List<SpawnableCrateReference> smgCrateList;

	private List<SpawnableCrateReference> rifleCrateList;

	private List<SpawnableCrateReference> shotgunCrateList;

	private List<SpawnableCrateReference> bluntCrateList;

	private List<SpawnableCrateReference> bladeCrateList;

	public Spawnable vfxFadeOutSpawnable;

	public LevelCrateReference hubLevelCrate;

	public LevelCrateReference loadScreenLevel;

	public Spawnable seekerSpawnable;

	public static StaticProfiles instance
	{
		get
		{
			return null;
		}
	}

	public void CreateStatProfile(StaticProfiles profile)
	{
	}

	public StaticProfiles()
		: base()
	{
	}
}
