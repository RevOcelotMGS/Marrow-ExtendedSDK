using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.VFX
{
	public class GenericFrameTimer : MonoBehaviour
	{
		private enum FrameType
		{
			FixedUpdate = 0,
			EndOfFrame = 1
		}

		[SerializeField]
		private FrameType CountingType;

		[SerializeField]
		private int FramesToCount;

		[SerializeField]
		private UnityEvent TimerUp;

		private void OnEnable()
		{
		}

		private IEnumerator FrameCounter()
		{
			return null;
		}

		private IEnumerator FixedFrameCounter()
		{
			return null;
		}

		public GenericFrameTimer()
			: base()
		{
		}
	}
}
