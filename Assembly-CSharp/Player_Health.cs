using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Combat;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : Health
{
	public delegate void PlayerDeathImminent(bool isDying);

	public delegate void PlayerDeath();

	public delegate void PlayerDamageReceived(float damageAmount);

	private static ComponentCache<Player_Health> _cache;

	public bool reloadLevelOnDeath;

	[Space(2f)]
	[Header("IMPACT")]
	[Tooltip("Can be damaged by physical impacts")]
	public bool damageFromImpact;

	[Tooltip("Modifier multiplier to collision")]
	public float mod_Impact;

	[Tooltip("Threshold of impact magnitude required to damage")]
	public float thr_Impact;

	[Tooltip("Can this use a mask to ignore damage")]
	public bool useMask;

	[Tooltip("Layer to Minimal Hit")]
	public LayerMask msk_Impact;

	[Tooltip("Amount of Minimal Mod")]
	public float mod_Minimal;

	[Tooltip("Spawnable hero props")]
	public GameObject[] prop_Hero;

	[Tooltip("Threshold of damage to cause a reaction")]
	[Space(5f)]
	[Header("REACTION")]
	public float thr_React;

	private bool reacting;

	[Tooltip("Spawn hero props?")]
	public bool spawnHeroProps;

	public Transform[] spawn_points;

	[Tooltip("FX for death")]
	public GameObject fx_death;

	public SceneManager boneworks_SceneManager;

	public Control_GlobalTime globalTimeControl;

	[SerializeField]
	[Header("Regen & Imminent Death")]
	private bool visDebug;

	private bool slowMoOnDeath;

	public bool deathIsImminent;

	private bool regenerating;

	private bool isFadingVignette;

	[HideInInspector]
	public bool isInstaDying;

	[HideInInspector]
	public bool displayHealthFX;

	[Tooltip("Time until regen starts after hit")]
	public float wait_Regen_t;

	[Range(0.05f, 15f)]
	[Tooltip("Time in seconds to regnerate health from 0 - maxHealth")]
	public float totalRegenDuration;

	private float currentHealthRegenDuration;

	[Tooltip("Time player has (in seconds) to score damage after health reaches 0, if no attack is scored player dies")]
	public float deathTimeAmount;

	private float currDeathTime;

	[Tooltip("Time player has (in seconds) before instant death")]
	public float instaDeathTimeAmount;

	[Tooltip("Once player reached death state any additional hits will reduce deathTime left by this amount in seconds")]
	public float deathTimeReduction;

	private float routineTickRate;

	public AnimationCurve shutEyeCurve;

	private Coroutine deathRoutine;

	private Coroutine vignetteRoutine;

	private Coroutine regenRoutine;

	private Coroutine lowPassAudioRoutine;

	public Color darkRed;

	public Color brightRed;

	private float highLPF;

	private float lowLPF;

	private float currLPF;

	public int playerDamageScore;

	public int playerDeathSaves;

	[Header("VisDebug Canvas")]
	public GameObject healthCanvasPrefab;

	public Transform uiTarget;

	public PlayerHealthCanvas healthCanvas;

	private Vector3 canvasOffset;

	private MaterialPropertyBlock matPropBlock;

	public GameObject Vignetter;

	private SkinnedMeshRenderer vigRend;

	private int shutEyesID;

	private int brightenID;

	private int innerID;

	private int outerID;

	private int colorID;

	public static ComponentCache<Player_Health> Cache
	{
		get
		{
			return null;
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void MakeVignette()
	{
	}

	private void CreateHealthCanvas()
	{
	}

	private void Start()
	{
	}

	public void ToggleInstantDeathMode(bool toggleOn)
	{
	}

	public void OnPuppetDeath(PuppetMaster puppet)
	{
	}

	[ContextMenu("LfeSavingDamageDealt")]
	public void LifeSavingDamgeDealt()
	{
	}

	private void Update()
	{
	}

	private void ResetVigMaterial()
	{
	}

	public void SetFullHealth()
	{
	}

	public void ToggleHealthFX()
	{
	}

	private void PlayerDamageScore(float damage)
	{
	}

	[ContextMenu("Apply kill damage")]
	public void ApplyKillDamage()
	{
	}

	public void ShowHealthInstaDeathMode()
	{
	}

	public void StartHealthRegnerationAndVignette(float regenWait)
	{
	}

	private IEnumerator CoBrightenDeathSave()
	{
		return null;
	}

	private IEnumerator CoUpdateHealthUI()
	{
		return null;
	}

	private IEnumerator CoFadeVignette()
	{
		return null;
	}

	private IEnumerator CoFadeDeathVignette(float deathTime)
	{
		return null;
	}

	private IEnumerator CoRegenHealth(float waitSeconds)
	{
		return null;
	}

	private IEnumerator CoLowPassFilter(bool enableLow)
	{
		return null;
	}

	public void Death()
	{
	}

	public void TELEPORTONESECOND()
	{
	}

	private IEnumerator CoWaitAndReloadScene()
	{
		return null;
	}

	public IEnumerator CoWaitAndGoToRespawn()
	{
		return null;
	}

	public void Reaction(float damage)
	{
	}

	public void STARTDATA()
	{
	}

	public Player_Health()
		: base()
	{
	}

	public static event PlayerDeathImminent OnDeathImminent;

	public static event PlayerDeath OnPlayerDeath;

	public static event PlayerDamageReceived OnPlayerDamageReceived;
}
