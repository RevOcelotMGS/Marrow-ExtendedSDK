using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Props.Weapons
{
	public class FlyingGun : MonoBehaviour
	{
		public bool canNoClip;

		public float maxSpeed;

		public Grip triggerGrip;

		public Transform firePoint;

		[Tooltip("Highter exponential makes a small trigger pull slower. 1 = linear")]
		[Range(1f, 3f)]
		public float speedCurveExponential;

		[Header("References")]
		public GravGunSFX sfx;

		public Transform ringA;

		public Transform ringB;

		public Transform ringC;

		private float _targetAcceleration;

		private Vector3 _smoothedDirection;

		private Vector3 _directionVel;

		private float _targetSpeed;

		private float _ringAngularDisplacement;

		private bool _noClipping;

		private float _lastFixedTime;

		private Rigidbody[] _playerRbs;

		private InteractableHost _host;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private IEnumerator FunctionDelay(Action callback)
		{
			return null;
		}

		private void OnTriggerHandAttached(Hand hand)
		{
		}

		private void EnableNoClip()
		{
		}

		private void DisableNoClip(Hand hand)
		{
		}

		private void OnTriggerHandDetached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		public FlyingGun()
			: base()
		{
		}
	}
}
