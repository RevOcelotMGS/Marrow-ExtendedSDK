using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ
{
	public class DisableDelay : MonoBehaviour
	{
		public float secondsUntilDisable;

		[HideInInspector]
		public Transform returnParent;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private IEnumerator CoDelayedDisable()
		{
			return null;
		}

		public DisableDelay()
			: base()
		{
		}
	}
}
