using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	public class XRController : XRDevice
	{
		public virtual XRControllerType Type { get; protected set; }

		public Vector2 Joystick2DAxis { get; protected set; }

		public bool JoystickButton { get; protected set; }

		public bool JoystickButtonUp { get; protected set; }

		public bool JoystickButtonDown { get; protected set; }

		public bool JoystickTouch { get; protected set; }

		public Vector2 Touchpad2DAxis { get; protected set; }

		public bool TouchpadButton { get; protected set; }

		public bool TouchpadButtonUp { get; protected set; }

		public bool TouchpadButtonDown { get; protected set; }

		public bool TouchpadTouch { get; protected set; }

		public float Trigger { get; protected set; }

		public bool TriggerButton { get; protected set; }

		public bool TriggerButtonUp { get; protected set; }

		public bool TriggerButtonDown { get; protected set; }

		public bool TriggerTouched { get; protected set; }

		public bool GripButton { get; protected set; }

		public bool GripButtonUp { get; protected set; }

		public bool GripButtonDown { get; protected set; }

		public float Grip { get; protected set; }

		public float GripForce { get; protected set; }

		public float GripVelocity { get; protected set; }

		public bool AButton { get; protected set; }

		public bool AButtonUp { get; protected set; }

		public bool AButtonDown { get; protected set; }

		public bool ATouch { get; protected set; }

		public bool BButton { get; protected set; }

		public bool BButtonUp { get; protected set; }

		public bool BButtonDown { get; protected set; }

		public bool BTouch { get; protected set; }

		public bool MenuButton { get; protected set; }

		public bool MenuButtonUp { get; protected set; }

		public bool MenuButtonDown { get; protected set; }

		public float RingFinger { get; protected set; }

		public float IndexFinger { get; protected set; }

		public float PinkyFinger { get; protected set; }

		public float MiddleFinger { get; protected set; }

		public float ThumbFinger { get; protected set; }

		public virtual void SetHaptic(float secondsFromNow, float durationSeconds, float frequency, float amplitude)
		{
		}

		public XRController()
			: base()
		{
		}
	}
}
