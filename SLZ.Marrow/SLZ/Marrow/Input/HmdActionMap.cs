using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace SLZ.Marrow.Input
{
	public class HmdActionMap : XRHMD, InputActions.IHMDActions
	{
		private InputDevice _isDevice;

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

		public override void OnPostNewInputUpdate()
		{
		}

		void InputActions.IHMDActions.OnTrackingState(InputAction.CallbackContext context)
		{
		}

		void InputActions.IHMDActions.OnPosition(InputAction.CallbackContext context)
		{
		}

		void InputActions.IHMDActions.OnRotation(InputAction.CallbackContext context)
		{
		}

		void InputActions.IHMDActions.OnVelocity(InputAction.CallbackContext context)
		{
		}

		void InputActions.IHMDActions.OnAngularVelocity(InputAction.CallbackContext context)
		{
		}

		public override void Refresh()
		{
		}

		public HmdActionMap()
			: base()
		{
		}
	}
}
