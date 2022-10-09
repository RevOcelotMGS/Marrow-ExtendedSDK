using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

public class PrismaticSFX : MonoBehaviour
{
	[Serializable]
	public class AudioEvent
	{
		[HideInInspector]
		public bool eventEnabled;

		public Transform eventTran;

		public AudioClip[] eventClip;

		public float minSpeed;

		public float maxSpeed;

		public float triggerDistance;

		public AudioEvent()
			: base()
		{
		}
	}

	[Header("PROPERTIES")]
	public Rigidbody rb_parent;

	public Transform velocityTran;

	public Transform sourceTran;

	public float minSpeed;

	public float maxSpeed;

	public float sourceMinDistance;

	public float pitchMod;

	private float calculate_t;

	[Header("AUDIO")]
	public AudioMixerGroup outputMixer;

	public bool enableModulatedAudio;

	public bool loopClips;

	public AudioClip[] modulatedClips;

	public bool enableEvents;

	public AudioEvent[] audioEvents;

	[Range(0f, 1f)]
	public float SpatialBlend;

	[SerializeField]
	private bool _blockJointBreakStop;

	private AudioPlayer _ap;

	private bool _hasAp;

	private InteractableHost _host;

	private Rigidbody _rigidbody;

	private bool _hostMode;

	private bool _canPlay;

	private const float sleepFreq_t = 0.06f;

	private const float playFreq_t = 0.025f;

	private bool _hasBeenDisabled;

	private WaitForSeconds _sleepWait;

	private WaitForSeconds _playWait;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private IEnumerator UpdateSound()
	{
		return null;
	}

	private void OnJointBreak(float breakForce)
	{
	}

	public PrismaticSFX()
		: base()
	{
	}
}
