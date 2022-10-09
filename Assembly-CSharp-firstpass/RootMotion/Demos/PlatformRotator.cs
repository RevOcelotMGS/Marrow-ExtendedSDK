using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	public class PlatformRotator : MonoBehaviour
	{
		public float maxAngle;

		public float switchRotationTime;

		public float random;

		public float rotationSpeed;

		public Vector3 movePosition;

		public float moveSpeed;

		public int characterLayer;

		private Quaternion defaultRotation;

		private Quaternion targetRotation;

		private Vector3 targetPosition;

		private Vector3 velocity;

		private Rigidbody r;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private IEnumerator SwitchRotation()
		{
			return null;
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionExit(Collision collision)
		{
		}

		public PlatformRotator()
			: base()
		{
		}
	}
}
