using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.SFX;
using SLZ.VRMK;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class TaxiController : MonoBehaviour
{
	public ConfigurableJoint frontLf;

	public ConfigurableJoint frontRt;

	public ConfigurableJoint backLf;

	public ConfigurableJoint backRt;

	public CollisionStaySensor frontLfStaySensor;

	public CollisionStaySensor frontRtStaySensor;

	public CollisionStaySensor backLfStaySensor;

	public CollisionStaySensor backRtStaySensor;

	public Rigidbody steeringWheel;

	public Rigidbody frontAxle;

	[SerializeField]
	private SplineJoint splineJoint;

	[SerializeField]
	private PolyLine jimmyExitPolyLine;

	[SerializeField]
	private Rigidbody carBody;

	private ConfigurableJoint _steeringHinge;

	[SerializeField]
	private RigManager rigManager;

	[InspectorDisplayName("Target Velocity")]
	[Header("Off  -  0")]
	public float velocity_off;

	[InspectorDisplayName("Position Damper")]
	public float damper_off;

	[InspectorDisplayName("Maximum Force")]
	public float force_off;

	[Header("Idle  -  1")]
	[InspectorDisplayName("Target Velocity")]
	public float velocity_idle;

	[InspectorDisplayName("Position Damper")]
	public float damper_idle;

	[InspectorDisplayName("Maximum Force")]
	public float force_idle;

	[Header("Fast  -  2")]
	[InspectorDisplayName("Target Velocity")]
	public float velocity_fast;

	[InspectorDisplayName("Position Damper")]
	public float damper_fast;

	[InspectorDisplayName("Maximum Force")]
	public float force_fast;

	[InspectorDisplayName("Target Velocity")]
	[Header("Slow  -  3")]
	public float velocity_slow;

	[InspectorDisplayName("Position Damper")]
	public float damper_slow;

	[InspectorDisplayName("Maximum Force")]
	public float force_slow;

	[Header("Brake  -  4")]
	[InspectorDisplayName("Target Velocity")]
	public float velocity_brake;

	[InspectorDisplayName("Position Damper")]
	public float damper_brake;

	[InspectorDisplayName("Maximum Force")]
	public float force_brake;

	private Vector3 jointDriveCurrent;

	private Vector3 jointDriveTarget;

	private Vector3 jointDriveVel;

	public float throttleTime;

	[SerializeField]
	private float currVelMag;

	[SerializeField]
	private float velThresh;

	private float stopThresh;

	public float creditsLength;

	public MeshRenderer creditsRenderer;

	public Texture creditsTexture;

	private Material creditsMaterial;

	public GenericAnimatorController jimmyController;

	public AudioMixerGroup outputMixer;

	[SerializeField]
	private AudioClip[] engineStart;

	[SerializeField]
	private AudioClip[] brakeSqueal;

	[SerializeField]
	private AudioClip[] doorOpen;

	[SerializeField]
	private AudioClip[] doorClose;

	[Range(0f, 1f)]
	public float engineVolume;

	[Range(0f, 1f)]
	public float engineVolumeInterior;

	[SerializeField]
	private AudioClip engineIdleExteriorLoop;

	[SerializeField]
	private AudioClip engineIdleInteriorLoop;

	[SerializeField]
	private AudioClip engineSpeedExteriorLoop;

	[SerializeField]
	private AudioClip engineSpeedInteriorLoop;

	public AudioSource engineSource1;

	public AudioSource engineSource2;

	public Transform doorTransform;

	private IEnumerator engineCoroutine;

	private bool engineSource1UsedLast;

	[SerializeField]
	private AudioClip honkClip;

	[SerializeField]
	private AudioClip fenceMusic;

	public AudioSource cabMusicSource;

	public AnimationCurve duckCurve;

	[Range(0f, 4f)]
	public float duckTime;

	[Range(0f, 1f)]
	public float duckVolumeLevel;

	private IEnumerator duckCoroutine;

	private IEnumerator pushCoroutine;

	private float cashedBaseVolume;

	[SerializeField]
	public MusicAmbience2dSFX headSFX;

	[SerializeField]
	private Seat rearSeat;

	[SerializeField]
	private UnityEvent OnEngineStart;

	[SerializeField]
	private UnityEvent OnPlayerSeated;

	[SerializeField]
	private UnityEvent OnWhiteFlag;

	[SerializeField]
	private UnityEvent OnStopingStart;

	[SerializeField]
	private UnityEvent OnRideComplete;

	[SerializeField]
	private UnityEvent OnLoopComplete;

	[SerializeField]
	private UnityEvent OnDriveOff;

	private Rigidbody _frontLfRb;

	private Rigidbody _frontRtRb;

	private Rigidbody _backLfRb;

	private Rigidbody _backRtRb;

	private float _lastFrontLfPressure;

	private float _lastFrontRtPressure;

	private float _lastBackLfPressure;

	private float _lastBackRtPressure;

	private int loopCount;

	private int loopGoal;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void UpdateSpeed(int setting)
	{
	}

	[ContextMenu("StartCreditsCoroutine")]
	public void StartCreditsCoroutine()
	{
	}

	private IEnumerator CreditsCoroutine()
	{
		return null;
	}

	public void StartPushTaxiRoutine()
	{
	}

	private IEnumerator CoWaitForPush()
	{
		return null;
	}

	public void SwapEngineSoundSimple(int i)
	{
	}

	public void SwapEngineSound(int i, float blendTime)
	{
	}

	private IEnumerator EngineSoundCoroutine(int i, float blendTime)
	{
		return null;
	}

	[ContextMenu("SeatRegistered")]
	private void SeatRegistered()
	{
	}

	[ContextMenu("Start Taxi Song")]
	public void StartTaxiSong()
	{
	}

	public void StartPushPromptsCoroutine()
	{
	}

	private IEnumerator PushPromptCoroutine()
	{
		return null;
	}

	public void KillPushPromptCoroutine()
	{
	}

	public void StartDuckMusicCoroutine(float length)
	{
	}

	private IEnumerator DuckMusicCoroutine(float length)
	{
		return null;
	}

	[ContextMenu("SeatDeRegistered")]
	private void SeatDeRegistered()
	{
	}

	public void SplineLoopCounter()
	{
	}

	public void DriveComplete()
	{
	}

	private IEnumerator CoWaitForStop()
	{
		return null;
	}

	private IEnumerator CoPlayerDist()
	{
		return null;
	}

	public TaxiController()
		: base()
	{
	}
}
