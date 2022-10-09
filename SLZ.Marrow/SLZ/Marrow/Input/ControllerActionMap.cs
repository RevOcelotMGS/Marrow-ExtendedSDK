using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

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

		public void OnPosition(InputAction.CallbackContext context)
		{
		}

		public void OnRotation(InputAction.CallbackContext context)
		{
		}

		public void OnTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnVelocity(InputAction.CallbackContext context)
		{
		}

		public void OnAngularVelocity(InputAction.CallbackContext context)
		{
		}

		public void OnPrimary2DAxis(InputAction.CallbackContext context)
		{
		}

		public void OnPrimary2DAxisClick(InputAction.CallbackContext context)
		{
		}

		public void OnPrimary2DAxisTouch(InputAction.CallbackContext context)
		{
		}

		public void OnTouchpad(InputAction.CallbackContext context)
		{
		}

		public void OnTouchpadClick(InputAction.CallbackContext context)
		{
		}

		public void OnTouchpadTouch(InputAction.CallbackContext context)
		{
		}

		public void OnTrigger(InputAction.CallbackContext context)
		{
		}

		public void OnTriggerPress(InputAction.CallbackContext context)
		{
		}

		public void OnTriggerTouch(InputAction.CallbackContext context)
		{
		}

		public void OnGrip(InputAction.CallbackContext context)
		{
		}

		public void OnGripPress(InputAction.CallbackContext context)
		{
		}

		public void OnGripForce(InputAction.CallbackContext context)
		{
		}

		public void OnPrimaryButton(InputAction.CallbackContext context)
		{
		}

		public void OnPrimaryTouch(InputAction.CallbackContext context)
		{
		}

		public void OnSecondaryButton(InputAction.CallbackContext context)
		{
		}

		public void OnSecondaryTouch(InputAction.CallbackContext context)
		{
		}

		public void OnMenuButton(InputAction.CallbackContext context)
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
