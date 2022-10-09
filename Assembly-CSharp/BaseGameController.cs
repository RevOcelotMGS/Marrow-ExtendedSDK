using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ;
using SLZ.AI;
using SLZ.Marrow.Warehouse;
using SLZ.Props;
using SLZ.Props.Weapons;
using SLZ.Rig;
using SLZ.SFX;
using SLZ.Zones;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class BaseGameController : MonoBehaviour
{
	public enum GameMode
	{
		LINEAR = 0,
		ARENA = 1,
		TIME_TRIAL = 2
	}

	public enum TimerMode
	{
		COUNT_UP = 0,
		COUNT_DOWN = 1,
		REALTIME = 2,
		COUNT_UP_REALTIME = 3
	}

	public enum EndMode
	{
		LOAD_NEXT = 0,
		RELOAD_CURRENT = 1,
		NONE = 2,
		EXPLICIT = 3
	}

	public enum DebugMode
	{
		VERBOSE = 0,
		MINIMAL = 1,
		NONE = 2
	}

	public GameMode gameMode;

	public TimerMode timerMode;

	public EndMode endMode;

	public DebugMode debugMode;

	[Tooltip("Name of the scene used for debug logs, defaults to scene title string.")]
	public string sceneTitle;

	[SerializeField]
	private string sceneDescription;

	[SerializeField]
	private string explicitSceneName;

	[SerializeField]
	private LevelCrateReference explicitSceneCrate;

	protected bool isSessionOngoing;

	[Header("Time Data")]
	[SerializeField]
	private float timerValue;

	[SerializeField]
	protected TimeSpan tsTimerValue;

	[SerializeField]
	public string tsTimerString;

	[SerializeField]
	private float maxTime;

	[SerializeField]
	private float defaultMaxTime;

	[SerializeField]
	public bool isSlowTime;

	[SerializeField]
	private float delayedMaxTime;

	[SerializeField]
	private float defaultDelayedMaxTime;

	[SerializeField]
	private float delayedEndMaxTime;

	[SerializeField]
	private float defaultEndDelayedMaxTime;

	[Header("Stats")]
	[SerializeField]
	public int score;

	[SerializeField]
	public int enemiesKilled;

	[SerializeField]
	public int totalEnemiesKilled;

	[SerializeField]
	public int activeEnemyCount;

	[SerializeField]
	public int maxDeadDespawnLimit;

	[SerializeField]
	public int activeFriendlyCount;

	[SerializeField]
	public int friendlyRespawnAmount;

	public RigManager rigManager;

	public GameObject playerObject;

	public TriggerRefProxy playerProxy;

	[SerializeField]
	protected MusicAmbience2dSFX headSFX;

	public Rigidbody[] allPlayerRBs;

	public Rigidbody playerPelvisBody;

	public GenGameControl_Trigger startTrigger;

	private Scene activeScene;

	[SerializeField]
	protected List<CollectiblePickup> collectiblePickupList;

	public bool isTrackingCollectibles;

	public int collectedAmount;

	public int totalCollectibles;

	public UnityEvent onCollectedAll;

	public List<TMP_Text> modeTexts;

	public List<TMP_Text> timerTexts;

	public List<TMP_Text> aliveTexts;

	public List<TMP_Text> aliveFriendsTexts;

	public List<TMP_Text> killsTexts;

	public List<TMP_Text> totalKillsTexts;

	public List<TMP_Text> totalEnemiesTexts;

	public List<TMP_Text> collectiblesTotalTexts;

	public List<TMP_Text> collectiblesFoundTexts;

	private Coroutine timerRoutine;

	[SerializeField]
	[Tooltip("Assuming all zones are the child of a single transform, will be used to grab all zone refs")]
	private GameObject zoneParentObj;

	[SerializeField]
	[Tooltip("List of all scene zones in the scene, use 'GetSceneZones' button to populate")]
	public List<SceneZone> sceneZoneList;

	public List<ZoneDisplayEditor> zoneDisplayList;

	[SerializeField]
	[Tooltip("List of all zone spawners in the scene, use 'GetZoneSpawners' button to populate")]
	public List<ZoneSpawner> zoneSpawnerList;

	[SerializeField]
	public ZoneSpawner safetyZoneSpawner;

	protected List<ZoneSpawner> removeSpawnerList;

	[HideInInspector]
	public bool isTrackingEnemies;

	[SerializeField]
	private bool isAutoDespawn;

	[SerializeField]
	private float despawnDelay;

	[SerializeField]
	[Tooltip("A list of all npcs that have been spawned since session began")]
	protected List<AIBrain> NPC_List;

	[Tooltip("A list of all living enemy NPC's")]
	[SerializeField]
	protected List<AIBrain> Alive_Enemy_List;

	[Tooltip("A list of all dead enemy NPC's")]
	[SerializeField]
	protected List<AIBrain> Dead_Enemy_List;

	[Tooltip("A list of all the friendly npcs")]
	[SerializeField]
	protected List<AIBrain> FriendlyNPC_List;

	[Tooltip("A list of all living enemy NPC's")]
	[SerializeField]
	protected List<AIBrain> Alive_Friendly_List;

	[Tooltip("A list of all dead enemy NPC's")]
	[SerializeField]
	protected List<AIBrain> Dead_Friendly_List;

	private int currFriendlyProxy;

	[SerializeField]
	protected List<TriggerRefProxy> friendlyProxyList;

	[SerializeField]
	protected List<NPC_Data> friendly_Data_List;

	[SerializeField]
	public List<NPC_Data> NPC_Data_List;

	[SerializeField]
	protected List<NPC_Data> dead_NPC_Data_List;

	[SerializeField]
	protected List<DeadData> despawnedDataList;

	[SerializeField]
	protected List<DeadData> despawnedDataWaveList;

	protected Dictionary<GameObject, NPC_Data> NPC_Data_Dict;

	protected Dictionary<ZoneSpawner, NPC_Data> NPC_Zone_Dict;

	public Action<NPC_Data> onNPCRegistration;

	public Action<NPC_Data> OnRegisteredNPCDeath;

	[SerializeField]
	private Gun[] guns;

	[SerializeField]
	private List<GameObject> meleeObjList;

	[SerializeField]
	private Magazine[] magazines;

	[SerializeField]
	private AmmoPickup[] ammoPickups;

	[SerializeField]
	private List<ObjectDestructable> destAmmoBoxList;

	[SerializeField]
	private int lightAmmoAvailable;

	[SerializeField]
	private int medAmmoAvailable;

	[SerializeField]
	private int heavyAmmoAvailable;

	[SerializeField]
	private int lightAmmoCollected;

	[SerializeField]
	private int medAmmoCollected;

	[SerializeField]
	private int heavyAmmoCollected;

	public BoneLeaderManager boneLeaderManager;

	public List<LinkData> linkList;

	public int crabletAgentID;

	[Header("SESSION EVENTS")]
	[Tooltip("Session is initialized, timer routine starts")]
	public UnityEvent onSessionBegin;

	[Tooltip("Session is complete, timer routine ends")]
	public UnityEvent onSessionEnd;

	public StaticProfiles staticProfile;

	public bool showUIData;

	public bool showPlayerData;

	public bool showEnemyDisplay;

	public bool showEnemyData;

	public bool showZoneData;

	public bool showDebugDisplay;

	public bool showWeaponsAmmo;

	public bool showEventData;

	public bool showLeaderboardData;

	public bool showCollectibles;

	public bool showArena;

	public bool showArenaProfile;

	public bool showArenaEvents;

	public bool showArenaAudio;

	public bool showArenaUI;

	public bool showArenaSpawning;

	public bool[] foldArray;

	public NPC_Data currNPC;

	public ZoneItem currZoneItem;

	public Texture soundIcon;

	public Texture settingsIcon;

	public Color zoneRectColor;

	public Mesh graveMesh;

	public static string profilePath;

	public string profileTitle;

	public float elapsedTime
	{
		get
		{
			return default(float);
		}
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Start()
	{
	}

	[ContextMenu("BeginSession")]
	public void BeginSession()
	{
	}

	[ContextMenu("EndSession")]
	public void EndSession()
	{
	}

	private IEnumerator CoDelayedStart()
	{
		return null;
	}

	private IEnumerator CoTimerUp()
	{
		return null;
	}

	private IEnumerator CoTimerUpRealtime()
	{
		return null;
	}

	private IEnumerator CoTimerDown()
	{
		return null;
	}

	private IEnumerator CoTimerRealtime()
	{
		return null;
	}

	private IEnumerator CoDelayedEnd()
	{
		return null;
	}

	private void UpdateTimeDisplay(bool showMilliscond = false)
	{
	}

	private void OnSlowTime(float slowStep)
	{
	}

	protected void ResetFriendlyProxyList()
	{
	}

	protected void CheckForProxyTarget(TriggerRefProxy proxy)
	{
	}

	protected TriggerRefProxy GetFriendlyProxy()
	{
		return null;
	}

	public void RegisterNPCBase(ZoneSpawner zoneSpawn, AIBrain brain, EnemyProfile enemyProfile, bool isFriendly)
	{
	}

	public void DeRegisterNPCBase(ZoneTracker tracker)
	{
	}

	public void OnNPC_DeathBase(AIBrain brain)
	{
	}

	protected void DespawnAllNPCs()
	{
	}

	private IEnumerator CoDelayedDespawn(AIBrain brain, float seconds)
	{
		return null;
	}

	private void OnDespawn(GameObject despawnedObject)
	{
	}

	protected void UpdateNPCDisplay()
	{
	}

	public void DebugTime()
	{
	}

	public void KillVolumeNPCRemoval(GameObject npcObj)
	{
	}

	[ContextMenu("CreateSeeker")]
	public void CreateDefSeeker()
	{
	}

	public void CreateTrialSeekers()
	{
	}

	protected void CreateZoneSeeker(ZoneSpawner spawner)
	{
	}

	private void OnAmmoUpdate(string ammoWeight, int count)
	{
	}

	private void OnCollected(CollectiblePickup pickup)
	{
	}

	public void SubmitScoreByType()
	{
	}

	private void LoadFXAndLevel(LevelCrateReference level, LevelCrateReference loadLevel)
	{
	}

	public void LOAD_HUB()
	{
	}

	public void WAITANDRELOADCURRENTLEVEL(float delay)
	{
	}

	private IEnumerator CoDelayedReload(float delay)
	{
		return null;
	}

	public void RELOADCURRENTLEVEL()
	{
	}

	public void LOADNEXTLEVEL()
	{
	}

	public void LOADEXPLICITLEVEL()
	{
	}

	[ContextMenu("GetAllLinkData")]
	public void GetAllLinkData()
	{
	}

	public BaseGameController()
		: base()
	{
	}
}
