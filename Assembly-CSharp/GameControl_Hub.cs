using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab;
using SLZ.Data.SaveData;
using SLZ.Marrow.Data;
using SLZ.Marrow.SceneStreaming;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class GameControl_Hub : MonoBehaviour
{
	public const string OneTrueLevelKey = "Hub";

	public const string LevelKeyA = "Hub_A";

	public const string LevelKeyB = "Hub_B";

	public const string LevelKeyC = "Hub_C";

	public static readonly string[] PriorLevelsA;

	public static readonly string[] PriorLevelsB;

	public static readonly string[] PriorLevelsC;

	public const string HubSpawnLocation = "SLZ.Bonelab.HubSpawnLocation";

	public const string ElevatorBroken = "SLZ.Bonelab.ElevatorBroken";

	public const string TacTrialKeyUnlocked = "SLZ.Bonelab.TacTrialKeyUnlocked";

	public const string ArenaKeyUnlocked = "SLZ.Bonelab.ArenaKeyUnlocked";

	public const string SandboxKeyUnlocked = "SLZ.Bonelab.SandboxKeyUnlocked";

	public const string ParkourKeyUnlocked = "SLZ.Bonelab.ParkourKeyUnlocked";

	public const string ExperimentalKeyUnlocked = "SLZ.Bonelab.ExperimentalKeyUnlocked";

	public const string ModKeyUnlocked = "SLZ.Bonelab.ModKeyUnlocked";

	public const string JimmyKeyUnlocked = "SLZ.Bonelab.JimmyKeyUnlocked";

	public const string TacTrialKeyPlaced = "SLZ.Bonelab.TacTrialKeyPlaced";

	public const string ArenaKeyPlaced = "SLZ.Bonelab.ArenaKeyPlaced";

	public const string SandboxKeyPlaced = "SLZ.Bonelab.SandboxKeyPlaced";

	public const string ParkourKeyPlaced = "SLZ.Bonelab.ParkourKeyPlaced";

	public const string ExperimentalKeyPlaced = "SLZ.Bonelab.ExperimentalKeyPlaced";

	public const string ModKeyPlaced = "SLZ.Bonelab.ModKeyPlaced";

	public const string JimmyKeyPlaced = "SLZ.Bonelab.JimmyKeyPlaced";

	public const string BatteryAPlaced = "SLZ.Bonelab.BatteryAPlaced";

	public const string BatteryBPlaced = "SLZ.Bonelab.BatteryBPlaced";

	[Header("References")]
	public Control_Player controlPlayer;

	public Control_UI_ProgressBoard progressBoard;

	public TriggerLasers rmFetcher;

	[Header("Keys")]
	public GameObject[] key_Modules;

	public GameObject[] key_Inserted;

	public GameObject battery1;

	public GameObject battery2;

	public GameObject battery1_Inserted;

	public GameObject battery2_Inserted;

	public GameObject jimmyKey;

	public GameObject jimmyKey_Inserted;

	[Header("Key Bools")]
	public bool[] isKeyUnlock;

	public bool[] isKeyInserted;

	public bool isJimmyKeyUnlocked;

	public bool isJimmyKeyInserted;

	public bool isBattery1Inserted;

	public bool isBattery2Inserted;

	public bool isGateUnlock;

	public bool isAllInserted;

	public bool isGameFinished;

	public int keyCount;

	[HideInInspector]
	public int keyUnlock;

	[Header("Renderer")]
	public GameObject[] render_Lamp;

	public MeshRenderer[] render_LockLamp;

	public MeshRenderer[] bigDoors_LockLamp;

	public Material[] mat_Lamp;

	[Header("Game Objects")]
	public GameObject[] lockBar;

	private ConfigurableJoint[] lockBarJoints;

	private Rigidbody[] lockBarRB;

	public GameObject[] keyStopperLocks;

	public GameObject[] bigDoors;

	public GameObject smallDoor;

	public Vector3 smallDoorOffSettings;

	public Vector3 smallDoorOnSettings;

	public GameObject doorStopper;

	public GameObject BWBox;

	public GameObject flooring;

	public BasicSeatTrigger seatTrigger;

	public GauntletElevator gauntletElevator;

	public GameObject breakableDoorsGroup;

	public GameObject workingDoorsGroup;

	public bool isInBWBoxVolume;

	public bool isBWBoxBroken;

	private bool isBWDoorOpen;

	[Header("AudioClips")]
	public AudioClip intoMusic;

	public AudioClip[] bwClunk;

	public AudioClip[] bwWarning;

	public AudioClip[] klaxon;

	public AudioClip[] radiation;

	public AudioClip[] barRetraction;

	public AudioClip[] doorSeal;

	public PrismaticSFX bwDoorPismatic;

	public AudioMixerGroup outputMixer;

	private AudioPlayer apMain;

	private AudioPlayer apKlaxon;

	private AudioPlayer apRadiation;

	public ParticleSystem[] steamParticles;

	public Light klaxonLight;

	public Rigidbody klaxonRB;

	public ConfigurableJoint klaxonJoint;

	[Header("Locations")]
	public List<ResumePoint> hubSpawnPoints;

	[Header("Level Loader")]
	public LevelCrateReference longRun;

	public LevelCrateReference ascent;

	public LevelCrateReference loadScreenLevel;

	public Spawnable vfxFadeOutSpawnable;

	public InventorySaveFilter inventorySaveFilter;

	public RigManager rm;

	private int _loadedTeleportSpot;

	private IEnumerator doorCycle;

	private IEnumerator airlockCoroutine;

	private bool bigDoorsOpening;

	private bool bigDoorsClosing;

	private bool smallDoorsOpening;

	private bool smallDoorsClosing;

	private bool airLockOccupied;

	public bool labLoaded;

	public bool airlockLoaded;

	public bool funicularLoaded;

	public bool slzRoomLoaded;

	public Chunk northChunk;

	public Chunk northAndAirlockChunk;

	public Chunk airlockChunk;

	public Chunk southAndAirlockChunk;

	public Chunk southChunk;

	public UnityEvent activateCrane;

	public UnityEvent unlockSPA;

	public UnityEvent insertIronKey;

	public UnityEvent breakBoneBox;

	private AvatarCrateReference[] avatarCrates;

	public static string LevelKey
	{
		get
		{
			return null;
		}
	}

	public static string[] PriorLevels
	{
		get
		{
			return null;
		}
	}

	private static PlayerProgression p
	{
		get
		{
			return null;
		}
	}

	private static PlayerUnlocks u
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void FETCHRIGMANAGER()
	{
	}

	public void DataRead()
	{
	}

	public void DataWrite()
	{
	}

	public void ELEVATORBREAKOUT()
	{
	}

	private void Teleport()
	{
	}

	private void SetupKeys()
	{
	}

	public void SETUPELEVATOR()
	{
	}

	public void UNLOCKKEY(int keyInt)
	{
	}

	public void KEYINSERTED(int keyInt)
	{
	}

	public void UNLOCKJIMMYKEY()
	{
	}

	public void JIMMYKEYINSERTED()
	{
	}

	public void BATTERYINSERTED(int i)
	{
	}

	public void OPENBWDOOR()
	{
	}

	public IEnumerator BWBoxSequence()
	{
		return null;
	}

	public IEnumerator KlaxonLight()
	{
		return null;
	}

	private void PlayAudioClip(AudioPlayer ap, AudioClip[] clip, float volume, float minDist, Transform pos, bool looping = false)
	{
	}

	public void ENTERBWBOXVOL()
	{
	}

	public void EXITBWBOXVOL()
	{
	}

	public void BWBOXDESTROYED()
	{
	}

	private void CheckTotal()
	{
	}

	private void DisplayKeys()
	{
	}

	public void COMPLETE()
	{
	}

	private void GameDone()
	{
	}

	public void GOTOSCENE(int gameStage = 0)
	{
	}

	private int CountKeys()
	{
		return default(int);
	}

	public void AIRLOCKENTERNORTH()
	{
	}

	public void AIRLOCKENTERSOUTH()
	{
	}

	public void AIRLOCKOCCUPIED()
	{
	}

	public void AIRLOCKUNOCCUPIED()
	{
	}

	public void AIRLOCKCYCLE()
	{
	}

	private IEnumerator AirlockEnter(int side)
	{
		return null;
	}

	private IEnumerator AirlockExitCycle()
	{
		return null;
	}

	public void CANCELCYCLE()
	{
	}

	public void OpenSmallDoor()
	{
	}

	public void CloseSmallDoor()
	{
	}

	public IEnumerator OpenSmallDoorCoroutine()
	{
		return null;
	}

	public IEnumerator CloseSmallDoorCoroutine()
	{
		return null;
	}

	public void OpenBigDoors()
	{
	}

	private IEnumerator OpenDoorCoroutine()
	{
		return null;
	}

	private IEnumerator OpenDoorInterrupt()
	{
		return null;
	}

	public void CloseBigDoors()
	{
	}

	private IEnumerator CloseDoorCoroutine()
	{
		return null;
	}

	private IEnumerator CloseDoorInterrupt()
	{
		return null;
	}

	public void OnLabLoaded()
	{
	}

	public void OnAirlockLoaded()
	{
	}

	public void OnFunicularLoaded()
	{
	}

	public void OnSLZRoomLoaded()
	{
	}

	public void OnLabUnloaded()
	{
	}

	public void OnAirlockUnloaded()
	{
	}

	public void OnFunicularUnloaded()
	{
	}

	public void OnSLZRoomUnloaded()
	{
	}

	private void LoadFXAndLevel(LevelCrateReference level)
	{
	}

	public GameControl_Hub()
		: base()
	{
	}
}
