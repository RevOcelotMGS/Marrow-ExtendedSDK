using Assets.Marrow_ExtendedSDK.StubClasses;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	public class ControllerActionMap : XRController
	{
		private InputDevice _isDevice;

		private float _simIndexTouch;

		private Vector3 _position;

		private Quaternion _rotation;

		private double _poseUpdateTime;

		private double _lastPoseUpdateTime;

		public override string DeviceInfo
		{
			get
			{
				return null;
			}
		}

		private void ProcessDeviceInfo(InputDevice device)
		{
		}

		public override void OnPreNewInputUpdate()
		{
		}

		public override void OnPostNewInputUpdate()
		{
		}

		public override void SetHaptic(float secondsFromNow, float duration, float frequency, float amplitude)
		{
		}

		public void OnPosition(CallbackContext context)
		{
		}

		public void OnRotation(CallbackContext context)
		{
		}

		public void OnTrackingState(CallbackContext context)
		{
		}

		public void OnVelocity(CallbackContext context)
		{
		}

		public void OnAngularVelocity(CallbackContext context)
		{
		}

		public void OnPrimary2DAxis(CallbackContext context)
		{
		}

		public void OnPrimary2DAxisClick(CallbackContext context)
		{
		}

		public void OnPrimary2DAxisTouch(CallbackContext context)
		{
		}

		public void OnTouchpad(CallbackContext context)
		{
		}

		public void OnTouchpadClick(CallbackContext context)
		{
		}

		public void OnTouchpadTouch(CallbackContext context)
		{
		}

		public void OnTrigger(CallbackContext context)
		{
		}

		public void OnTriggerPress(CallbackContext context)
		{
		}

		public void OnTriggerTouch(CallbackContext context)
		{
		}

		public void OnGrip(CallbackContext context)
		{
		}

		public void OnGripPress(CallbackContext context)
		{
		}

		public void OnGripForce(CallbackContext context)
		{
		}

		public void OnPrimaryButton(CallbackContext context)
		{
		}

		public void OnPrimaryTouch(CallbackContext context)
		{
		}

		public void OnSecondaryButton(CallbackContext context)
		{
		}

		public void OnSecondaryTouch(CallbackContext context)
		{
		}

		public void OnMenuButton(CallbackContext context)
		{
		}

		public override void Refresh()
		{
		}

		public ControllerActionMap()
			: base()
		{
		}
	}
}
