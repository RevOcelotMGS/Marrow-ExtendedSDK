using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnitySA.Utility
{
	[Serializable]
	public class FOVZoom
	{
		public Camera Camera;

		[HideInInspector]
		public float originalFov;

		public float FOVIncrease;

		public float TimeToIncrease;

		public float TimeToDecrease;

		public AnimationCurve IncreaseCurve;

		public void Setup(Camera camera)
		{
		}

		private void CheckStatus(Camera camera)
		{
		}

		public void ChangeCamera(Camera camera)
		{
		}

		public IEnumerator FOVKickUp()
		{
			return null;
		}

		public IEnumerator FOVKickDown()
		{
			return null;
		}

		public FOVZoom()
			: base()
		{
		}
	}
}
