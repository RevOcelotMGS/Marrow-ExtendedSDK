using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ
{
	public class DisableDelayOnLoad : MonoBehaviour
	{
		public float secondsUntilDisable;

		[HideInInspector]
		public Transform returnParent;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private IEnumerator CoDelayedDisable()
		{
			return null;
		}

		public DisableDelayOnLoad()
			: base()
		{
		}
	}
}
