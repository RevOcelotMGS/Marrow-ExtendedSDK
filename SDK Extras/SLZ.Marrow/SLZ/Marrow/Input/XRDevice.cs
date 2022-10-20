using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	public class XRDevice
	{
		private List<InputDevice> _xrDevices;

		protected InputDevice _xrDevice;

		private double _lastUpdateTime;

		private Vector3 _lastPosition;

		private Quaternion _lastRotation;

		public virtual InputDeviceCharacteristics Characteristics { get; protected set; }

		public virtual string DeviceInfo { get; protected set; }

		public bool IsConnected { get; protected set; }

		public bool IsTracking { get; protected set; }

		public Vector3 Position { get; protected set; }

		public Quaternion Rotation { get; protected set; }

		public Vector3 Velocity { get; protected set; }

		public Vector3 AngularVelocity { get; protected set; }

		public double UpdateTime { get; protected set; }

		public virtual void OnFrameStart()
		{
		}

		public virtual void OnPreNewInputUpdate()
		{
		}

		public virtual void OnPostNewInputUpdate()
		{
		}

		public virtual void Refresh()
		{
		}

		public SimpleTransform GetPoseAtFixedTime(double fixedTime)
		{
			return default(SimpleTransform);
		}

		public XRDevice()
			: base()
		{
		}
	}
}
