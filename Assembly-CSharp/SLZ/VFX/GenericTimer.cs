using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.VFX
{
	public class GenericTimer : MonoBehaviour
	{
		private enum TimeType
		{
			Realtime = 0,
			ScaledTime = 1
		}

		[SerializeField]
		[Tooltip("Consider in scaled time or realtime")]
		private TimeType CountingType;

		[SerializeField]
		private float Timer;

		public bool PlayOnEnable;

		[SerializeField]
		private UnityEvent TimerUp;

		private void OnEnable()
		{
		}

		public void PlayTimer()
		{
		}

		private IEnumerator Realtime()
		{
			return null;
		}

		private IEnumerator ScaledTime()
		{
			return null;
		}

		public GenericTimer()
			: base()
		{
		}
	}
}
