using System;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public class StabSlash : MonoBehaviour
	{
		[Serializable]
		public class StabPoint
		{
			[Serializable]
			public class StabJoint
			{
				public ConfigurableJoint joint;

				public Collider collider;

				public float megaPascals;

				public ImpactProperties iP;

				public bool firstFrame;

				public float depth;

				public float deepestDepth;

				public float velocity;

				public float damageBuffer;

				public StabJoint()
					: base()
				{
				}
			}

			public Transform pointTran;

			public Collider pointCollider;

			public float maxDepth;

			[Range(1f, 10f)]
			public float aspectRatio;

			public float stabBreakForce;

			[Range(0f, 1000f)]
			[Tooltip("Area in millimeters squared of the tip")]
			public float sharpness;

			public float depthResistanceMult;

			public float linearSpring;

			public float linearDamp;

			public float damage;

			public StabJoint[] stabJoints;

			public int impaleCount;

			private float _unStabDelay;

			private float _reStabTimer;

			[HideInInspector]
			public InteractableHost _host;

			[HideInInspector]
			public BladeAudio bAudio;

			[HideInInspector]
			public Rigidbody rb
			{
				get
				{
					return null;
				}
			}

			public void SpawnStab(Transform tran, Collision c, float stabForce, ImpactProperties surfaceProperties)
			{
			}

			public void InitStabs(Transform tran)
			{
			}

			private void InitializeStab(Transform tran, int i)
			{
			}

			private void JointSetup(ConfigurableJoint j)
			{
			}

			public void UpdateStabs()
			{
			}

			private void UnStab(int i)
			{
			}

			public StabPoint()
				: base()
			{
			}
		}

		[Serializable]
		public class SlashBlade
		{
			[Serializable]
			public class BladeJoint
			{
				public ConfigurableJoint joint;

				public Collider collider;

				public float megaPascals;

				public ImpactProperties iP;

				public bool firstFrame;

				public float velocity;

				public float damageBuffer;

				public BladeJoint()
					: base()
				{
				}
			}

			public Transform bladeTran;

			public Collider bladeCollider;

			public float bladeLength;

			public float maxDepth;

			public float bladeBreakForce;

			[Range(0f, 1000f)]
			public float sharpness;

			public float linearSpring;

			public float linearDamp;

			public float damage;

			public BladeJoint[] bladeJoints;

			public int impaleCount;

			private float _unSlashDelay;

			private float _reStabTimer;

			[HideInInspector]
			public InteractableHost _host;

			[HideInInspector]
			public BladeAudio bAudio;

			[HideInInspector]
			public Rigidbody rb
			{
				get
				{
					return null;
				}
			}

			public virtual void SpawnSlash(GameObject obj, Collision c, float slashForce, Vector3 slashPressure, ImpactProperties surfaceProperties)
			{
			}

			public virtual void UpdateSlashes()
			{
			}

			private void UnSlash(int i)
			{
			}

			public SlashBlade()
				: base()
			{
			}
		}

		[Serializable]
		public class BladeAudio
		{
			public AudioMixerGroup outputMixer;

			public Transform sourceTran;

			public AudioClip[] hiltImpactSoft;

			public AudioClip[] hiltImpactHard;

			public AudioClip[] bladeImpactSoft;

			public AudioClip[] bladeImpactHard;

			public AudioClip[] fleshCut;

			public AudioClip[] cardboardCut;

			public AudioClip[] woodCut;

			public AudioClip[] metalCut;

			public AudioClip[] cutEnd;

			public Transform whooshTran;

			public AudioClip whooshLoop;

			public Collider[] hiltColliders;

			public float bluntDamageMult;

			public float nativeImpactVelocity;

			public float impactVelocityThresh;

			public float cutAccelThresh;

			private AudioSource source;

			private InteractableHost _host;

			private bool isWhooshing;

			private const float _lowPitchRange = 0.8f;

			private const float _highPitchRange = 1.2f;

			private const float _velToVol = 0.25f;

			private float _minVelSquared;

			private float _cooldownTime;

			public bool cooling
			{
				get
				{
					return default(bool);
				}
			}

			public void Initialize(Transform tran, InteractableHost host)
			{
			}

			public void CutEvent(Vector3 worldPos, float velocity, float accel, ImpactPropertiesVariables.Material iP)
			{
			}

			public void CutEnd(Vector3 worldPos, float velocity)
			{
			}

			public void Whoosh(float velocitySqr)
			{
			}

			public void CollisionEnterSfx(Collision c, ImpactProperties iP, Rigidbody rb)
			{
			}

			public void CollisionStaySfx(Collision c)
			{
			}

			public BladeAudio()
				: base()
			{
			}
		}

		public StabPoint[] stabPoints;

		public SlashBlade[] slashBlades;

		public BladeAudio bladeAudio;

		private InteractableHost _host;

		private Rigidbody rb
		{
			get
			{
				return null;
			}
		}

		private void ProcessCollision(Collision c, bool isStay = false)
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnCollisionStay(Collision c)
		{
		}

		public void InitializePreStab()
		{
		}

		public StabSlash()
			: base()
		{
		}
	}
}
