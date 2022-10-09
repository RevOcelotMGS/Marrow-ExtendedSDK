using System;
using System.Runtime.CompilerServices;
using SLZ.Combat;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

namespace SLZ.SFX
{
	public class ImpactSFX : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		private static ComponentCache<ImpactSFX> _cache;

		public AudioMixerGroup outputMixer;

		public GameObject sourceObj;

		public AudioClip[] impactSoft;

		public AudioClip[] impactHard;

		public AudioClip[] destruction;

		public AudioClip[] jointBreak;

		public Collider[] altImpactColliders;

		public AudioClip[] altImpact;

		public float pitchMod;

		public bool bluntAttack;

		public float bluntDamageMult;

		public float minVelocity;

		public float velocityClipSplit;

		public float jointBreakVolume;

		public ImpactSfxManager manager;

		private AudioSource source;

		private InteractableHost _host;

		private const float _lowPitchRange = 0.75f;

		private const float _highPitchRange = 1.25f;

		private float _minVelSquared;

		private float _mass;

		private Rigidbody _rb;

		private float _nextImpactTime;

		private float _pitchMod;

		private bool _altColliders;

		public Action<Collision, float> OnSignificantCollision;

		public static ComponentCache<ImpactSFX> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetPitchMultiplier(float value)
		{
		}

		private void Initialize()
		{
		}

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		public void ImpactSound(Collision collision)
		{
		}

		private void BluntAttack(float impulse, Collision c)
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}

		public void JointBreakFx(AudioClip[] breakClips)
		{
		}

		public void DestructionEvent(float volume = 1f)
		{
		}

		private bool AltColliderCheck(Collider hitCol)
		{
			return default(bool);
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		public ImpactSFX()
			: base()
		{
		}
	}
}
