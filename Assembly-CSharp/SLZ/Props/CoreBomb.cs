using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Props.Weapons;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Props
{
	public class CoreBomb : MonoBehaviour
	{
		private static MaterialPropertyBlock _propertyBlock;

		private static int _colorID;

		[ColorUsage(true, true)]
		public Color defaultColor;

		[ColorUsage(true, true)]
		public Color hotColor;

		public AudioMixerGroup outputMixer;

		public AudioClip strongHitClip;

		public AudioClip unstableLoopClip;

		private static ComponentCache<CoreBomb> _cache;

		public float duration;

		public float cooldown;

		public Action OnCriticalHitOneTime;

		public Action OnDeactivateCore;

		[Header("References")]
		public MeshRenderer meshRenderer;

		public Grip grip;

		public Rigidbody rb;

		public GravityManipulatorJob gravityManipulator;

		private List<Collider> _colliders;

		private float _lastTimeHitActive;

		private float _lastCooldownTime;

		private float _lastSFXHit;

		private bool _canBeActive;

		private AudioPlayer _loopAudioPlayer;

		private Coroutine _hitCoroutine;

		private Coroutine _antigravCoroutine;

		public static ComponentCache<CoreBomb> Cache
		{
			get
			{
				return null;
			}
		}

		public bool IsActive { get; private set; }

		private void Awake()
		{
		}

		private void OnGripAttached(Hand hand)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		private void ActivateAntigrav(InteractableHostManager manager)
		{
		}

		private void DeactivateAntigrav()
		{
		}

		public void DeactivateCore()
		{
		}

		public void ActivateCore()
		{
		}

		private IEnumerator CoHitColor()
		{
			return null;
		}

		private IEnumerator CoAntigravColor()
		{
			return null;
		}

		public CoreBomb()
			: base()
		{
		}
	}
}
