using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(Animator))]
	public class SoccerDemo : MonoBehaviour
	{
		private Animator animator;

		private Vector3 defaultPosition;

		private Quaternion defaultRotation;

		private void Start()
		{
		}

		private IEnumerator ResetDelayed()
		{
			return null;
		}

		public SoccerDemo()
			: base()
		{
		}
	}
}
