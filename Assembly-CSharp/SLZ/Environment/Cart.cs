using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Environment
{
	public class Cart : MonoBehaviour
	{
		[Header("Options")]
		public float maxSpeed;

		public float acceleration;

		public float launchReturnSeconds;

		public Vector3 gateEndPoint;

		public AudioClip launchClip;

		public AudioClip startClip;

		public AudioClip stopClip;

		public AudioMixerGroup mixergroup;

		[Header("References")]
		public Transform gateTransform;

		public Transform endTransform;

		public ConfigurableJoint joint;

		public Rigidbody rb;

		private Coroutine _gateCoroutine;

		private Coroutine _moveCoroutine;

		private Quaternion _startRotation;

		private Vector3 _gateStartPoint;

		private float _lastDirection;

		private float _speed;

		private float _distance;

		private float _halfDistance;

		private float _linearTargetPosition;

		private float _velocity;

		private float _gatePerc;

		public void Reset()
		{
		}

		public void Awake()
		{
		}

		public void Update()
		{
		}

		public IEnumerator CoMoveTargetTransform(float direction)
		{
			return null;
		}

		public void Drop()
		{
		}

		public void GoForward()
		{
		}

		public void GoBackward()
		{
		}

		public void Go()
		{
		}

		public void Launch()
		{
		}

		public IEnumerator CoLaunch()
		{
			return null;
		}

		public IEnumerator CoMoveGate(float direction)
		{
			return null;
		}

		private bool AlreadyAtTarget(float direction)
		{
			return default(bool);
		}

		public Cart()
			: base()
		{
		}
	}
}
