using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Technie.VirtualConsole
{
	public class AutoScreenshot : DebugPanel
	{
		public string screenshotOutputFolder;

		public float screenshotTimerDelaySecs;

		public int supersamplingAmount;

		public bool hidePanelsOnScreenshot;

		public Text timerDelayDisplay;

		public Text countdownDisplay;

		public Text lastScreenshotPathDisplay;

		public Text captureModeDisplay;

		public Toggle hidePanelsToggle;

		public GameObject[] captureModeUiElements;

		public HandAbstraction handAbstraction;

		public PanelManager panelManager;

		private ScreenCapture.StereoScreenCaptureMode captureMode;

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

		public void OnIncTimer()
		{
		}

		public void OnDecTimer()
		{
		}

		public void OnIncSupersampling()
		{
		}

		public void OnDecSupersampling()
		{
		}

		public void OnHidePanelsToggled()
		{
		}

		public void OnNextCaptureMode()
		{
		}

		public void OnPrevCaptureMode()
		{
		}

		private void UpdateCaptureModeDisplay()
		{
		}

		public void OnStartTimer()
		{
		}

		private IEnumerator TimerRoutine()
		{
			return null;
		}

		public AutoScreenshot()
			: base()
		{
		}
	}
}
