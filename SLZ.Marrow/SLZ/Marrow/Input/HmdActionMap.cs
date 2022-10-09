using Assets.Marrow_ExtendedSDK.StubClasses;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

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

		void InputActions.IHMDActions.OnTrackingState(CallbackContext context)
		{
		}

		void InputActions.IHMDActions.OnPosition(CallbackContext context)
		{
		}

		void InputActions.IHMDActions.OnRotation(CallbackContext context)
		{
		}

		void InputActions.IHMDActions.OnVelocity(CallbackContext context)
		{
		}

		void InputActions.IHMDActions.OnAngularVelocity(CallbackContext context)
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
