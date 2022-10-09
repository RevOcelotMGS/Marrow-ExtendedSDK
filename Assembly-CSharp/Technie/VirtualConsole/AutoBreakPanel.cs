using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace Technie.VirtualConsole
{
	public class AutoBreakPanel : DebugPanel
	{
		public float breakTimerDelaySecs;

		public Text timerDelayDisplay;

		public Text countdownDisplay;

		private void Start()
		{
		}

		public override void OnAttach()
		{
		}

		public override void OnDetach()
		{
		}

		public override void OnResized(VrDebugDisplay.State size)
		{
		}

		public void OnAutoBreak()
		{
		}

		public void OnIncBreakTimer()
		{
		}

		public void OnDecBreakTimer()
		{
		}

		public void OnStartBreakTimer()
		{
		}

		private IEnumerator BreakTimerRoutine()
		{
			return null;
		}

		public AutoBreakPanel()
			: base()
		{
		}
	}
}
