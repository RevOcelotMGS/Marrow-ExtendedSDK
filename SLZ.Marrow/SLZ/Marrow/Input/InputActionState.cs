using UnityEngine;

namespace SLZ.Marrow.Input
{
	public class InputActionState
	{
		public bool isDeviceConnectedHmd;

		public bool isDeviceTrackingHmd;

		public Vector3 devicePositionHmd;

		public Quaternion deviceRotationHmd;

		public Vector3 deviceVelocityHmd;

		public Vector3 deviceAngularVelocityHmd;

		public double deviceUpdateTimeHmd;

		public double lastDeviceUpdateTimeHmd;

		public bool isDeviceConnectedL;

		public bool isDeviceTrackingL;

		public Vector3 devicePositionL;

		public Quaternion deviceRotationL;

		public Vector3 deviceVelocityL;

		public Vector3 deviceAngularVelocityL;

		public double deviceUpdateTimeL;

		public double lastDeviceUpdateTimeL;

		public bool isDeviceConnectedR;

		public bool isDeviceTrackingR;

		public Vector3 devicePositionR;

		public Quaternion deviceRotationR;

		public Vector3 deviceVelocityR;

		public Vector3 deviceAngularVelocityR;

		public double deviceUpdateTimeR;

		public double lastDeviceUpdateTimeR;

		public Vector2 joystick2DAxisL;

		public Vector2 joystick2DAxisR;

		public bool joystickButtonL;

		public bool joystickButtonUpL;

		public bool joystickButtonDownL;

		public bool joystickButtonR;

		public bool joystickButtonUpR;

		public bool joystickButtonDownR;

		public bool joystickTouchL;

		public bool joystickTouchR;

		public float triggerL;

		public float triggerR;

		public bool triggerButtonL;

		public bool triggerButtonUpL;

		public bool triggerButtonDownL;

		public bool triggerButtonR;

		public bool triggerButtonUpR;

		public bool triggerButtonDownR;

		public bool triggerTouchedL;

		public bool triggerTouchedR;

		public bool gripButtonL;

		public bool gripButtonUpL;

		public bool gripButtonDownL;

		public bool gripButtonR;

		public bool gripButtonUpR;

		public bool gripButtonDownR;

		public float gripL;

		public float gripForceL;

		public float gripVelocityL;

		public float gripR;

		public float gripForceR;

		public float gripVelocityR;

		public bool primaryButtonL;

		public bool primaryButtonR;

		public bool primaryButtonUpL;

		public bool primaryButtonUpR;

		public bool primaryButtonDownL;

		public bool primaryButtonDownR;

		public bool primaryTouchL;

		public bool primaryTouchR;

		public bool secondaryButtonL;

		public bool secondaryButtonR;

		public bool secondaryButtonUpL;

		public bool secondaryButtonUpR;

		public bool secondaryButtonDownL;

		public bool secondaryButtonDownR;

		public bool secondaryTouchL;

		public bool secondaryTouchR;

		public bool thumbTouchL;

		public bool thumbTouchR;

		public float ringFingerL;

		public float indexFingerL;

		public float pinkyFingerL;

		public float middleFingerL;

		public float thumbFingerL;

		public float ringFingerR;

		public float indexFingerR;

		public float pinkyFingerR;

		public float middleFingerR;

		public float thumbFingerR;

		public InputActionState()
			: base()
		{
		}
	}
}
