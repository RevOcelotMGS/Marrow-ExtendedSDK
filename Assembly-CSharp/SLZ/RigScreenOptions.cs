using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Data.SaveData;
using UnityEngine;

namespace SLZ
{
	public class RigScreenOptions : ScreenOptions
	{
		[Header("Spectator settings")]
		public float tiltAngle;

		public EyeTarget eyeTarget;

		public SpectatorCameraMode cameraMode;

		private Vector3 SpecCamLocalpos;

		[Header("References")]
		public Camera cam;

		public Transform TargetTransform;

		public Camera OverlayCam;

		private void Start()
		{
		}

		private void GetMainCam()
		{
		}

		private void startCo()
		{
		}

		private IEnumerator StartingLogic()
		{
			return null;
		}

		private SpectatorSettings GetSettings()
		{
			return null;
		}

		public void SetCameraLocation(EyeTarget location)
		{
		}

		public void SetPassthroughLocation(EyeTarget location)
		{
		}

		public void SetSpectatorCamera(SpectatorCameraMode mode, EyeTarget location)
		{
		}

		private void RenderOverlay()
		{
		}

		private void TurnOffOverlayCam()
		{
		}

		[ContextMenu("Enable Fisheye")]
		public void EnableFisheye()
		{
		}

		public RigScreenOptions()
			: base()
		{
		}
	}
}
