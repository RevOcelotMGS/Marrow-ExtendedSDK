using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;

public class BossClawAi : MonoBehaviour
{
	[Serializable]
	public enum MentalState
	{
		Rest = 0,
		Patrol = 1,
		Pounce = 2,
		Unload = 3
	}

	public enum PounceState
	{
		Charge = 0,
		Drop = 1,
		Scoop = 2,
		Check = 3
	}

	[SerializeField]
	private NavMeshAgent _navAgent;

	[SerializeField]
	private Rigidbody _baseRb;

	[SerializeField]
	private ConfigurableJoint _jointBase;

	[SerializeField]
	private ConfigurableJoint _jointSpineA;

	[SerializeField]
	private ConfigurableJoint _jointSpineB;

	[SerializeField]
	private ConfigurableJoint _jointSpineC;

	[SerializeField]
	private ConfigurableJoint _jointCabin;

	[SerializeField]
	private GameObject[] _scoopObjects;

	[SerializeField]
	private Transform _boxCheck;

	public Transform unloadPoint;

	public Vector2 patrolXz;

	[Range(0f, 1f)]
	public float patrolFrequency;

	public float maxExtension;

	public float extensionTime;

	public float retractionTime;

	public float speed;

	public float acceleration;

	public float scoopSpringXz;

	public float scoopDamperXz;

	public float pounceSpeedMult;

	public float pounceAccelMult;

	public float pounceSpringMult;

	public float pounceDamperMult;

	public LayerMask preyLayers;

	public List<TriggerRefProxy> targetList;

	private Dictionary<TriggerRefProxy, int> _targetRefCount;

	[SerializeField]
	private TriggerRefProxy _activeTarget;

	private ulong _activeTargetId;

	[Header("SFX")]
	public AudioClip movementLoop;

	public AudioClip articulationLoop;

	public AudioClip charge;

	[SerializeField]
	private AudioClip _scoopOn;

	[SerializeField]
	private AudioClip _scoopOff;

	[SerializeField]
	private AudioMixerGroup _mixerGroup;

	private float _curExtension;

	private float _extensionVelocity;

	private float _targetExtension;

	private float _lastAiTickTime;

	private float _patrolTimer;

	private float _aiTickFreq;

	private float _pounceTimer;

	private float _baseAcceleration;

	private Vector3 _homePosition;

	private Vector3 _scoopDisplace;

	private bool _forceAiTick;

	private AudioPlayer _movementPlayer;

	private AudioPlayer _articulationPlayer;

	private Collider[] _boxCheckResults;

	[SerializeField]
	private MentalState _mentalState;

	[SerializeField]
	private MentalState _defaultState;

	[SerializeField]
	private PounceState _pounceState;

	public void SetPath(Vector3 target)
	{
	}

	public void ClearPath()
	{
	}

	public void SetActive()
	{
	}

	public void SetDeactive()
	{
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	public void TriggerStateChange(TriggerRefProxy trp, bool enter = true)
	{
	}

	public void CheckTarget()
	{
	}

	private void AiTick()
	{
	}

	private void SwitchPounceState(PounceState pState)
	{
	}

	private void SwitchMentalState(MentalState mState)
	{
	}

	private bool CaughtPrey()
	{
		return default(bool);
	}

	private void ToggleScoop(bool toggleOn)
	{
	}

	private void SetScoopXzDrives(float spring, float damper)
	{
	}

	private void AttenuateMovementLoop(AudioPlayer player, Transform parentTransform, float volume, float pitch)
	{
	}

	public BossClawAi()
		: base()
	{
	}
}
