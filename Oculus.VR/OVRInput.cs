using System;
using UnityEngine;

public static class OVRInput
{
	[Flags]
	public enum Button
	{
		None = 0,
		One = 1,
		Two = 2,
		Three = 4,
		Four = 8,
		Start = 0x100,
		Back = 0x200,
		PrimaryShoulder = 0x1000,
		PrimaryIndexTrigger = 0x2000,
		PrimaryHandTrigger = 0x4000,
		PrimaryThumbstick = 0x8000,
		PrimaryThumbstickUp = 0x10000,
		PrimaryThumbstickDown = 0x20000,
		PrimaryThumbstickLeft = 0x40000,
		PrimaryThumbstickRight = 0x80000,
		PrimaryTouchpad = 0x400,
		SecondaryShoulder = 0x100000,
		SecondaryIndexTrigger = 0x200000,
		SecondaryHandTrigger = 0x400000,
		SecondaryThumbstick = 0x800000,
		SecondaryThumbstickUp = 0x1000000,
		SecondaryThumbstickDown = 0x2000000,
		SecondaryThumbstickLeft = 0x4000000,
		SecondaryThumbstickRight = 0x8000000,
		SecondaryTouchpad = 0x800,
		DpadUp = 0x10,
		DpadDown = 0x20,
		DpadLeft = 0x40,
		DpadRight = 0x80,
		Up = 0x10000000,
		Down = 0x20000000,
		Left = 0x40000000,
		Right = int.MinValue,
		Any = -1
	}

	[Flags]
	public enum RawButton
	{
		None = 0,
		A = 1,
		B = 2,
		X = 0x100,
		Y = 0x200,
		Start = 0x100000,
		Back = 0x200000,
		LShoulder = 0x800,
		LIndexTrigger = 0x10000000,
		LHandTrigger = 0x20000000,
		LThumbstick = 0x400,
		LThumbstickUp = 0x10,
		LThumbstickDown = 0x20,
		LThumbstickLeft = 0x40,
		LThumbstickRight = 0x80,
		LTouchpad = 0x40000000,
		RShoulder = 8,
		RIndexTrigger = 0x4000000,
		RHandTrigger = 0x8000000,
		RThumbstick = 4,
		RThumbstickUp = 0x1000,
		RThumbstickDown = 0x2000,
		RThumbstickLeft = 0x4000,
		RThumbstickRight = 0x8000,
		RTouchpad = int.MinValue,
		DpadUp = 0x10000,
		DpadDown = 0x20000,
		DpadLeft = 0x40000,
		DpadRight = 0x80000,
		Any = -1
	}

	[Flags]
	public enum Touch
	{
		None = 0,
		One = 1,
		Two = 2,
		Three = 4,
		Four = 8,
		PrimaryIndexTrigger = 0x2000,
		PrimaryThumbstick = 0x8000,
		PrimaryThumbRest = 0x1000,
		PrimaryTouchpad = 0x400,
		SecondaryIndexTrigger = 0x200000,
		SecondaryThumbstick = 0x800000,
		SecondaryThumbRest = 0x100000,
		SecondaryTouchpad = 0x800,
		Any = -1
	}

	[Flags]
	public enum RawTouch
	{
		None = 0,
		A = 1,
		B = 2,
		X = 0x100,
		Y = 0x200,
		LIndexTrigger = 0x1000,
		LThumbstick = 0x400,
		LThumbRest = 0x800,
		LTouchpad = 0x40000000,
		RIndexTrigger = 0x10,
		RThumbstick = 4,
		RThumbRest = 8,
		RTouchpad = int.MinValue,
		Any = -1
	}

	[Flags]
	public enum RawNearTouch
	{
		None = 0,
		LIndexTrigger = 1,
		LThumbButtons = 2,
		RIndexTrigger = 4,
		RThumbButtons = 8,
		Any = -1
	}

	[Flags]
	public enum Axis1D
	{
		None = 0,
		PrimaryIndexTrigger = 1,
		PrimaryHandTrigger = 4,
		SecondaryIndexTrigger = 2,
		SecondaryHandTrigger = 8,
		Any = -1
	}

	[Flags]
	public enum RawAxis1D
	{
		None = 0,
		LIndexTrigger = 1,
		LHandTrigger = 4,
		RIndexTrigger = 2,
		RHandTrigger = 8,
		Any = -1
	}

	[Flags]
	public enum Axis2D
	{
		None = 0,
		PrimaryThumbstick = 1,
		PrimaryTouchpad = 4,
		SecondaryThumbstick = 2,
		SecondaryTouchpad = 8,
		Any = -1
	}

	[Flags]
	public enum RawAxis2D
	{
		None = 0,
		LThumbstick = 1,
		LTouchpad = 4,
		RThumbstick = 2,
		RTouchpad = 8,
		Any = -1
	}

	[Flags]
	public enum Controller
	{
		None = 0,
		LTouch = 1,
		RTouch = 2,
		Touch = 3,
		Remote = 4,
		Gamepad = 0x10,
		Hands = 0x60,
		LHand = 0x20,
		RHand = 0x40,
		Active = int.MinValue,
		All = -1
	}

	private class HapticInfo
	{
		public HapticInfo()
			: base()
		{
		}
	}

	public abstract class OVRControllerBase
	{
		public class VirtualButtonMap
		{
			public RawButton None;

			public RawButton One;

			public RawButton Two;

			public RawButton Three;

			public RawButton Four;

			public RawButton Start;

			public RawButton Back;

			public RawButton PrimaryShoulder;

			public RawButton PrimaryIndexTrigger;

			public RawButton PrimaryHandTrigger;

			public RawButton PrimaryThumbstick;

			public RawButton PrimaryThumbstickUp;

			public RawButton PrimaryThumbstickDown;

			public RawButton PrimaryThumbstickLeft;

			public RawButton PrimaryThumbstickRight;

			public RawButton PrimaryTouchpad;

			public RawButton SecondaryShoulder;

			public RawButton SecondaryIndexTrigger;

			public RawButton SecondaryHandTrigger;

			public RawButton SecondaryThumbstick;

			public RawButton SecondaryThumbstickUp;

			public RawButton SecondaryThumbstickDown;

			public RawButton SecondaryThumbstickLeft;

			public RawButton SecondaryThumbstickRight;

			public RawButton SecondaryTouchpad;

			public RawButton DpadUp;

			public RawButton DpadDown;

			public RawButton DpadLeft;

			public RawButton DpadRight;

			public RawButton Up;

			public RawButton Down;

			public RawButton Left;

			public RawButton Right;

			public RawButton ToRawMask(Button virtualMask)
			{
				return default(RawButton);
			}

			public VirtualButtonMap()
				: base()
			{
			}
		}

		public class VirtualTouchMap
		{
			public RawTouch None;

			public RawTouch One;

			public RawTouch Two;

			public RawTouch Three;

			public RawTouch Four;

			public RawTouch PrimaryIndexTrigger;

			public RawTouch PrimaryThumbstick;

			public RawTouch PrimaryThumbRest;

			public RawTouch PrimaryTouchpad;

			public RawTouch SecondaryIndexTrigger;

			public RawTouch SecondaryThumbstick;

			public RawTouch SecondaryThumbRest;

			public RawTouch SecondaryTouchpad;

			public RawTouch ToRawMask(Touch virtualMask)
			{
				return default(RawTouch);
			}

			public VirtualTouchMap()
				: base()
			{
			}
		}

		public class VirtualNearTouchMap
		{
			public RawNearTouch None;

			public RawNearTouch PrimaryIndexTrigger;

			public RawNearTouch PrimaryThumbButtons;

			public RawNearTouch SecondaryIndexTrigger;

			public RawNearTouch SecondaryThumbButtons;

			public VirtualNearTouchMap()
				: base()
			{
			}
		}

		public class VirtualAxis1DMap
		{
			public RawAxis1D None;

			public RawAxis1D PrimaryIndexTrigger;

			public RawAxis1D PrimaryHandTrigger;

			public RawAxis1D SecondaryIndexTrigger;

			public RawAxis1D SecondaryHandTrigger;

			public RawAxis1D ToRawMask(Axis1D virtualMask)
			{
				return default(RawAxis1D);
			}

			public VirtualAxis1DMap()
				: base()
			{
			}
		}

		public class VirtualAxis2DMap
		{
			public RawAxis2D None;

			public RawAxis2D PrimaryThumbstick;

			public RawAxis2D PrimaryTouchpad;

			public RawAxis2D SecondaryThumbstick;

			public RawAxis2D SecondaryTouchpad;

			public RawAxis2D ToRawMask(Axis2D virtualMask)
			{
				return default(RawAxis2D);
			}

			public VirtualAxis2DMap()
				: base()
			{
			}
		}

		public Controller controllerType;

		public VirtualButtonMap buttonMap;

		public VirtualTouchMap touchMap;

		public VirtualNearTouchMap nearTouchMap;

		public VirtualAxis1DMap axis1DMap;

		public VirtualAxis2DMap axis2DMap;

		public OVRPlugin.ControllerState4 previousState;

		public OVRPlugin.ControllerState4 currentState;

		public bool shouldApplyDeadzone;

		public OVRControllerBase()
			: base()
		{
		}

		public virtual Controller Update()
		{
			return default(Controller);
		}

		public virtual void SetControllerVibration(float frequency, float amplitude)
		{
		}

		public abstract void ConfigureButtonMap();

		public abstract void ConfigureTouchMap();

		public abstract void ConfigureNearTouchMap();

		public abstract void ConfigureAxis1DMap();

		public abstract void ConfigureAxis2DMap();

		public RawButton ResolveToRawMask(Button virtualMask)
		{
			return default(RawButton);
		}

		public RawTouch ResolveToRawMask(Touch virtualMask)
		{
			return default(RawTouch);
		}

		public RawAxis1D ResolveToRawMask(Axis1D virtualMask)
		{
			return default(RawAxis1D);
		}

		public RawAxis2D ResolveToRawMask(Axis2D virtualMask)
		{
			return default(RawAxis2D);
		}
	}

	public class OVRControllerLTouch : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}

		public OVRControllerLTouch()
			: base()
		{
		}
	}

	public class OVRControllerRTouch : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}

		public OVRControllerRTouch()
			: base()
		{
		}
	}

	private static readonly float AXIS_AS_BUTTON_THRESHOLD;

	private static readonly float AXIS_DEADZONE_THRESHOLD;

	private static Controller activeControllerType;

	private static Controller connectedControllerTypes;

	private static OVRPlugin.Step stepType;

	private static int fixedUpdateCount;

	private static bool _pluginSupportsActiveController;

	private static bool _pluginSupportsActiveControllerCached;

	private static Version _pluginSupportsActiveControllerMinVersion;

	private static int NUM_HAPTIC_CHANNELS;

	private static HapticInfo[] hapticInfos;

	private static float HAPTIC_VIBRATION_DURATION_SECONDS;

	static OVRInput()
	{
	}

	public static bool Get(OVRControllerBase controller, Button virtualMask)
	{
		return default(bool);
	}

	private static bool GetResolvedButton(OVRControllerBase controller, Button virtualMask, RawButton rawMask)
	{
		return default(bool);
	}

	public static bool Get(OVRControllerBase controller, Touch virtualMask)
	{
		return default(bool);
	}

	private static bool GetResolvedTouch(OVRControllerBase controller, Touch virtualMask, RawTouch rawMask)
	{
		return default(bool);
	}

	public static float Get(OVRControllerBase controller, Axis1D virtualMask)
	{
		return default(float);
	}

	private static float GetResolvedAxis1D(OVRControllerBase controller, Axis1D virtualMask, RawAxis1D rawMask)
	{
		return default(float);
	}

	public static Vector2 Get(OVRControllerBase controller, Axis2D virtualMask)
	{
		return default(Vector2);
	}

	private static Vector2 GetResolvedAxis2D(OVRControllerBase controller, Axis2D virtualMask, RawAxis2D rawMask)
	{
		return default(Vector2);
	}

	private static void InitHapticInfo()
	{
	}

	private static Vector2 CalculateAbsMax(Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	private static float CalculateAbsMax(float a, float b)
	{
		return default(float);
	}

	private static Vector2 CalculateDeadzone(Vector2 a, float deadzone)
	{
		return default(Vector2);
	}

	private static float CalculateDeadzone(float a, float deadzone)
	{
		return default(float);
	}
}
