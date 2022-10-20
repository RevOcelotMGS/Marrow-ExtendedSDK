using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Combat;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

namespace SLZ.SFX
{
	public class HeadSFX : MonoBehaviour
	{
		private static ComponentCache<HeadSFX> _cache;

		[Header("Jump Effort")]
		public AudioClip[] jumpEffort;

		public AudioClip[] doubleJump;

		[Header("Take Damage")]
		public AudioClip[] smallDamage;

		public AudioClip[] bigDamage;

		public AudioClip[] dying;

		public AudioClip[] dead;

		public AudioClip[] recovery;

		public AudioSource mouthSrc;

		[Header("Headbutt")]
		public LayerMask meleeAttackMask;

		public AudioClip[] headbuttClips;

		public AudioClip[] headbuttClipsSlowmo;

		public TriggerRefProxy proxy;

		private float _speachEnd;

		private float _lastJumpEffort;

		private float _lastImpactTime;

		public AudioMixerGroup inHeadMixer;

		private Rigidbody _rbHead;

		public PhysicsRig physRig;

		public static ComponentCache<HeadSFX> Cache
		{
			get
			{
				return null;
			}
		}

		public bool isSpeaking
		{
			get
			{
				return default(bool);
			}
		}

		public void Speak(AudioClip clip, bool playDelayed = false, bool overwrite = true)
		{
		}

		public void SmallDamageVocal(float damage)
		{
		}

		public void BigDamageVocal()
		{
		}

		public void DyingVocal()
		{
		}

		public void DeathVocal()
		{
		}

		public void RecoveryVocal()
		{
		}

		public void JumpEffort()
		{
		}

		public void DoubleJump()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return default(float);
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public HeadSFX()
			: base()
		{
		}
	}
}
