using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Props;
using SLZ.SFX;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public class ProjectileBalloon : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		private static ComponentCache<ProjectileBalloon> _cache;

		[Header("Options")]
		public LayerMask collisionLayers;

		[Tooltip("Effective Range of Raycast")]
		public float effectiveRange;

		[Tooltip("Max Velocity After Impact")]
		public float maxVelocity;

		[Tooltip("Balloon's Up Force")]
		public float constantBuoyantForce;

		[Tooltip("Impact Force Before Popping")]
		public float maxImpactForce;

		[Header("References")]
		public Spawnable balloonPopVfxSpawnable;

		public GameObject balloonArt;

		public Transform stringStartTransform;

		public Transform forceTargetTransform;

		public AudioMixerGroup outputMixer;

		public AudioClip[] inflateSFX;

		private AudioPlayer ap;

		private float sqrMaxVelocity;

		private float sqrMaxImpactForce;

		private ConfigurableJoint joint;

		private MeshRenderer artRenderer;

		private LineRenderer lineRenderer;

		private Rigidbody rb;

		private ImpactSFX impactSFX;

		private float _scaledBuoyantForce;

		private float defaultDrag;

		private bool hasConnectedBody;

		private bool isWarmingUp;

		private static float s_flLastDeathSound;

		public static ComponentCache<ProjectileBalloon> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
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

		private void FreeJoint()
		{
		}

		private void AttachJoint(Rigidbody connectedBody, Vector3 impactPosition)
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private IEnumerator CoDelayFire(Vector3 position, Vector3 forward)
		{
			return null;
		}

		private IEnumerator CoWarmupAttach()
		{
			return null;
		}

		private void TakeDamage()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		public void SetColor(SLZ.Props.Balloon.BalloonColor color)
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		public ProjectileBalloon()
			: base()
		{
		}
	}
}
