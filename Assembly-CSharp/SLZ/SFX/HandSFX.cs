using System.Runtime.CompilerServices;
using SLZ.Combat;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

namespace SLZ.SFX
{
	public class HandSFX : MonoBehaviour
	{
		private static ComponentCache<HandSFX> _cache;

		public AudioClip[] grab;

		public AudioClip[] grabBig;

		public AudioClip[] drop;

		public AudioClip[] bodySlot;

		public AudioClip[] fallbackImpact;

		public AudioClip[] punch;

		public AudioClip[] slap;

		public AudioClip[] backhand;

		public AudioClip[] punchSlowMo;

		public AudioClip[] slapSlowMo;

		public AudioClip[] backhandSlowMo;

		public AudioClip whoosh;

		public AudioClip forceGrab;

		public AudioClip forceGrabLong;

		public LayerMask meleeAttackMask;

		public float minSpeed;

		public float maxSpeed;

		public float volumeMulti;

		public AnimationCurve VelocityPitchCurve;

		public AudioMixerGroup outputMixer;

		public float realtimeWhooshUpdateFrequency;

		[SerializeField]
		private PhysHand _physHand;

		private Rigidbody _rb;

		private bool isPlaying;

		private Hand _hand;

		private float _lastImpactTime;

		private int _enemyLayer;

		public static ComponentCache<HandSFX> Cache
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

		private void Start()
		{
		}

		public void Grab()
		{
		}

		public void BodySlot()
		{
		}

		public void Drop()
		{
		}

		public void ForcePull(float massDistance)
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return default(float);
		}

		private void OnCollisionStay(Collision c)
		{
		}

		private bool PunchAttack(Collision c, float impulse, float relVelSqr)
		{
			return default(bool);
		}

		public HandSFX()
			: base()
		{
		}
	}
}
