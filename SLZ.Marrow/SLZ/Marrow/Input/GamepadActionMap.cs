using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

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

		public void OnLeftJoystick2DAxis(InputAction.CallbackContext context)
		{
		}

		public void OnLeftTrigger1DAxis(InputAction.CallbackContext context)
		{
		}

		public void OnLeftJoystickButton(InputAction.CallbackContext context)
		{
		}

		public void OnLeftShoulderButton(InputAction.CallbackContext context)
		{
		}

		public void OnLeftNorthButton(InputAction.CallbackContext context)
		{
		}

		public void OnLeftEastButton(InputAction.CallbackContext context)
		{
		}

		public void OnLeftSouthButton(InputAction.CallbackContext context)
		{
		}

		public void OnLeftWestButton(InputAction.CallbackContext context)
		{
		}

		public void OnSelectButton(InputAction.CallbackContext context)
		{
		}

		public void OnRightJoystick2DAxis(InputAction.CallbackContext context)
		{
		}

		public void OnRightTrigger1DAxis(InputAction.CallbackContext context)
		{
		}

		public void OnRightJoystickButton(InputAction.CallbackContext context)
		{
		}

		public void OnRightShoulderButton(InputAction.CallbackContext context)
		{
		}

		public void OnRightNorthButton(InputAction.CallbackContext context)
		{
		}

		public void OnRightEastButton(InputAction.CallbackContext context)
		{
		}

		public void OnRightSouthButton(InputAction.CallbackContext context)
		{
		}

		public void OnRightWestButton(InputAction.CallbackContext context)
		{
		}

		public void OnStartButton(InputAction.CallbackContext context)
		{
		}

		public GamepadActionMap()
			: base()
		{
		}
	}
}
