using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	public class ResetInteractionObject : MonoBehaviour
	{
		public float resetDelay;

		private Vector3 defaultPosition;

		private Quaternion defaultRotation;

		private Transform defaultParent;

		private Rigidbody r;

		private void Start()
		{
		}

		private void OnPickUp(Transform t)
		{
		}

		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		public ResetInteractionObject()
			: base()
		{
		}
	}
}
