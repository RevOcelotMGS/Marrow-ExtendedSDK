using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Marrow.Pool;
using SLZ.Zones;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Arena_GameController : BaseGameController
{
	public enum ArenaStartMode
	{
		ON_START = 0,
		ON_TRIGGER = 1,
		CUSTOM = 2,
		ON_TRIGGER_BELL = 3
	}

	public enum ArenaDifficulty
	{
		EASY = 0,
		MEDIUM = 1,
		HARD = 2,
		HARDER = 3,
		HARDEST = 4
	}

	public enum ArenaState
	{
		ACTIVE = 0,
		WAITING = 1,
		FAILED = 2,
		QUIT = 3,
		WIN = 4
	}

	public TimeBender timeBender;

	public RoundProfileGroup assignedRoundProfile;

	public RoundProfileGroup survivalProfile;

	public RoundProfileGroup survivalProfileProjected;

	public List<RoundProfileGroup> roundProfileGroupList;

	public ArenaStartMode arenaStartMode;

	public ArenaDifficulty difficulty;

	public ArenaState arenaState;

	public GenGameControl_Trigger arenaStartTrigger;

	public GenGameControl_Trigger NPCEntranceTrigger;

	public GenGameControl_Spawner lootSpawner;

	public WeaponSpawner weaponSpawner;

	public GeoManager geoManager;

	[SerializeField]
	private int currGeo;

	[SerializeField]
	private int friendlySpawnCount;

	[SerializeField]
	private GameObject kingSpawn;

	[SerializeField]
	private GameObject[] friendlyTargetObjs;

	[SerializeField]
	private int currFriendlySpawn;

	private int currFriendlyTarg;

	[SerializeField]
	private Arena_Launcher launcher;

	[SerializeField]
	private int initLightAmmo;

	[SerializeField]
	private int initMedAmmo;

	[SerializeField]
	private int initHeavyAmmo;

	private Coroutine enemySpawnRoutine;

	private Coroutine arenaTimerRoutine;

	private Coroutine friendlySpawnRoutine;

	private Coroutine killComboRoutine;

	private bool isSpawning;

	private bool isWaveOngoing;

	public bool isPlayerReady;

	public bool isRung;

	private int currWaveIndex;

	private int currRoundIndex;

	private int maxConcurrentLimit;

	private int totalEnemyCount;

	private int currSpawner;

	[SerializeField]
	private float arenaTimerValue;

	[SerializeField]
	private float arenaStartDelay;

	private RoundProfile currentRound;

	private WaveProfile currentWave;

	[SerializeField]
	private int killScore;

	[SerializeField]
	private int comboMult;

	private float comboTimeVal;

	private float comboTimer;

	private int initPlayerAmmoVal;

	public TMP_Text arenaTimerText;

	public TMP_Text arenaRoundText;

	public TMP_Text arenaWaveText;

	public List<TMP_Text> arenaModeTexts;

	public List<TMP_Text> arenaDifficultyTexts;

	public TMP_Text comboTimerText;

	public TMP_Text comboMultText;

	public TMP_Text scoreText;

	public UnityEvent onPlayerReady;

	public UnityEvent onPlayerEnter;

	public UnityEvent onRoundBegin;

	public UnityEvent onRoundEnd;

	public UnityEvent onWaveBegin;

	public UnityEvent onWaveEnd;

	public UnityEvent onModeEnd;

	public UnityEvent onModeQuit;

	public UnityEvent OnReadyUpBell;

	public UnityEvent onRingBell;

	public UnityEvent onModeWin;

	public static Action OnSaveReady;

	[SerializeField]
	private AudioClip[] roundStartClips;

	[SerializeField]
	private AudioClip[] roundEndClips;

	[SerializeField]
	private AudioClip waveStartClip;

	[SerializeField]
	private AudioClip waveEndClip;

	[SerializeField]
	private AudioClip playerEnterClip;

	[SerializeField]
	private AudioClip greetingClip;

	[SerializeField]
	private AudioClip failModeClip;

	[SerializeField]
	private AudioClip winModeClip;

	[SerializeField]
	private float musicVol;

	[SerializeField]
	private AudioClip[] loopingMusicClips;

	private int currClip;

	public Dictionary<GameObject, Arena_NPC_Data> arena_NPC_dict;

	public Dictionary<GameObject, NPC_Data> sublimationDict;

	public GameObject[] randToggleObjs;

	public HashSet<ZoneSpawner> spawnerHash;

	private Coroutine playerDistRoutine;

	private Vector3 currPlayerPos;

	private Vector3 lastPlayerPos;

	private float lastPlayerCheck;

	private float thresh;

	private float playerDistTick;

	public float totalPlayerDist;

	private bool nextWaveExists;

	private int totalHeadShots;

	private int projectilesShot;

	[SerializeField]
	private List<NPC_Objective> allNPCObjectives;

	[SerializeField]
	private List<NPC_Objective> activeNPCObjectives;

	[SerializeField]
	private List<Arena_TriggeredSpawners> triggeredSpawnerList;

	private int currObjProxy;

	private int currProfile;

	public UnityEvent OnObjectiveInitiated;

	public UnityEvent OnObjectiveFailed;

	public UnityEvent OnObjectiveCompleted;

	public UnityEvent OnStackCompletion;

	public int round
	{
		get
		{
			return default(int);
		}
	}

	public int wave
	{
		get
		{
			return default(int);
		}
	}
}
