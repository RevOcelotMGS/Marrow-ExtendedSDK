using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Environment
{
	public class SimpleDoorControl : MonoBehaviour
	{
		[Header("Options")]
		public bool isLocked;

		[Header("Audio Clips")]
		public AudioClip[] closeClip;

		public AudioClip[] slamClip;

		public AudioClip[] openClip;

		public AudioClip[] audioClip;

		public AudioClip[] lockClip;

		[Header("References")]
		public ConfigurableJoint joint;

		public Rigidbody doorRigidbody;

		public Transform hingeBack;

		public Transform hingeForward;

		public Transform connectedHingeBack;

		public Transform connectedHingeForward;

		public Transform hingeArtTransform;

		public Collider[] ignoreColliders;

		[Header("Events")]
		public UnityEvent onLocked;

		public UnityEvent onUnlocked;

		public UnityEvent onClose;

		private float _neutralDriveSpring;

		private float _neutralDriveDamper;

		private float _neutralDriveMaxForce;

		private float _neutralHighLimit;

		private float _neutralLowLimit;

		private Collider[] _colliders;

		private Coroutine _overrideDoorCoroutine;

		private bool _isHingeForward;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public void Update()
		{
		}

		public void Lock()
		{
		}

		public void Unlock()
		{
		}

		public void Relax()
		{
		}

		public void Open(bool isPositiveDirection)
		{
		}

		public void Close()
		{
		}

		private void SetNeutralDrive()
		{
		}

		private IEnumerator CoCloseDoor()
		{
			return null;
		}

		private IEnumerator CoOpenDoor(bool isPositiveDirection)
		{
			return null;
		}

		public void CalculateHinge()
		{
		}

		public SimpleDoorControl()
			: base()
		{
		}
	}
}
