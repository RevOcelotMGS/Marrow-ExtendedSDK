using Assets.Marrow_ExtendedSDK.StubClasses;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	public class GamepadActionMap : ActionMap, InputActions.IGamepadActions
	{
		public bool IsConnected { get; private set; }

		public double UpdateTime { get; private set; }

		public double LastUpdateTime { get; private set; }

		public Vector2 LeftJoystick2DAxis { get; private set; }

		public bool LeftJoystickButton { get; private set; }

		public bool LeftJoystickButtonUp { get; private set; }

		public bool LeftJoystickButtonDown { get; private set; }

		public float LeftTrigger1DAxis { get; private set; }

		public bool LeftTriggerButton { get; private set; }

		public bool LeftTriggerButtonUp { get; private set; }

		public bool LeftTriggerButtonDown { get; private set; }

		public bool LeftShoulderButton { get; private set; }

		public bool LeftShoulderButtonUp { get; private set; }

		public bool LeftShoulderButtonDown { get; private set; }

		public bool LeftNorthButton { get; private set; }

		public bool LeftNorthButtonUp { get; private set; }

		public bool LeftNorthButtonDown { get; private set; }

		public bool LeftEastButton { get; private set; }

		public bool LeftEastButtonUp { get; private set; }

		public bool LeftEastButtonDown { get; private set; }

		public bool LeftSouthButton { get; private set; }

		public bool LeftSouthButtonUp { get; private set; }

		public bool LeftSouthButtonDown { get; private set; }

		public bool LeftWestButton { get; private set; }

		public bool LeftWestButtonUp { get; private set; }

		public bool LeftWestButtonDown { get; private set; }

		public bool SelectButton { get; private set; }

		public bool SelectButtonUp { get; private set; }

		public bool SelectButtonDown { get; private set; }

		public Vector2 RightJoystick2DAxis { get; private set; }

		public bool RightJoystickButton { get; private set; }

		public bool RightJoystickButtonUp { get; private set; }

		public bool RightJoystickButtonDown { get; private set; }

		public float RightTrigger1DAxis { get; private set; }

		public bool RightTriggerButton { get; private set; }

		public bool RightTriggerButtonUp { get; private set; }

		public bool RightTriggerButtonDown { get; private set; }

		public bool RightShoulderButton { get; private set; }

		public bool RightShoulderButtonUp { get; private set; }

		public bool RightShoulderButtonDown { get; private set; }

		public bool RightNorthButton { get; private set; }

		public bool RightNorthButtonUp { get; private set; }

		public bool RightNorthButtonDown { get; private set; }

		public bool RightEastButton { get; private set; }

		public bool RightEastButtonUp { get; private set; }

		public bool RightEastButtonDown { get; private set; }

		public bool RightSouthButton { get; private set; }

		public bool RightSouthButtonUp { get; private set; }

		public bool RightSouthButtonDown { get; private set; }

		public bool RightWestButton { get; private set; }

		public bool RightWestButtonUp { get; private set; }

		public bool RightWestButtonDown { get; private set; }

		public bool StartButton { get; private set; }

		public bool StartButtonUp { get; private set; }

		public bool StartButtonDown { get; private set; }

		public override void OnPreNewInputUpdate()
		{
		}

		public override void OnPostNewInputUpdate()
		{
		}

		public void OnLeftJoystick2DAxis(CallbackContext context)
		{
		}

		public void OnLeftTrigger1DAxis(CallbackContext context)
		{
		}

		public void OnLeftJoystickButton(CallbackContext context)
		{
		}

		public void OnLeftShoulderButton(CallbackContext context)
		{
		}

		public void OnLeftNorthButton(CallbackContext context)
		{
		}

		public void OnLeftEastButton(CallbackContext context)
		{
		}

		public void OnLeftSouthButton(CallbackContext context)
		{
		}

		public void OnLeftWestButton(CallbackContext context)
		{
		}

		public void OnSelectButton(CallbackContext context)
		{
		}

		public void OnRightJoystick2DAxis(CallbackContext context)
		{
		}

		public void OnRightTrigger1DAxis(CallbackContext context)
		{
		}

		public void OnRightJoystickButton(CallbackContext context)
		{
		}

		public void OnRightShoulderButton(CallbackContext context)
		{
		}

		public void OnRightNorthButton(CallbackContext context)
		{
		}

		public void OnRightEastButton(CallbackContext context)
		{
		}

		public void OnRightSouthButton(CallbackContext context)
		{
		}

		public void OnRightWestButton(CallbackContext context)
		{
		}

		public void OnStartButton(CallbackContext context)
		{
		}

		public GamepadActionMap()
			: base()
		{
		}
	}
}
