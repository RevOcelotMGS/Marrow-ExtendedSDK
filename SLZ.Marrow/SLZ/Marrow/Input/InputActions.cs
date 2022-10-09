using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace SLZ.Marrow.Input
{
	public class InputActions : IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		public struct HMDActions
		{
			private InputActions m_Wrapper;

			public InputAction TrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction Position
			{
				get
				{
					return null;
				}
			}

			public InputAction Rotation
			{
				get
				{
					return null;
				}
			}

			public InputAction Velocity
			{
				get
				{
					return null;
				}
			}

			public InputAction AngularVelocity
			{
				get
				{
					return null;
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
			}

			public HMDActions(InputActions wrapper)
			{
				this.m_Wrapper = default(InputActions);
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(HMDActions set)
			{
				return null;
			}

			public void SetCallbacks(IHMDActions instance)
			{
			}
		}

		public struct ControllerLActions
		{
			private InputActions m_Wrapper;

			public InputAction TrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction Position
			{
				get
				{
					return null;
				}
			}

			public InputAction Rotation
			{
				get
				{
					return null;
				}
			}

			public InputAction Velocity
			{
				get
				{
					return null;
				}
			}

			public InputAction AngularVelocity
			{
				get
				{
					return null;
				}
			}

			public InputAction Primary2DAxis
			{
				get
				{
					return null;
				}
			}

			public InputAction Primary2DAxisClick
			{
				get
				{
					return null;
				}
			}

			public InputAction Primary2DAxisTouch
			{
				get
				{
					return null;
				}
			}

			public InputAction Touchpad
			{
				get
				{
					return null;
				}
			}

			public InputAction TouchpadClick
			{
				get
				{
					return null;
				}
			}

			public InputAction TouchpadTouch
			{
				get
				{
					return null;
				}
			}

			public InputAction Trigger
			{
				get
				{
					return null;
				}
			}

			public InputAction TriggerPress
			{
				get
				{
					return null;
				}
			}

			public InputAction TriggerTouch
			{
				get
				{
					return null;
				}
			}

			public InputAction Grip
			{
				get
				{
					return null;
				}
			}

			public InputAction GripPress
			{
				get
				{
					return null;
				}
			}

			public InputAction GripForce
			{
				get
				{
					return null;
				}
			}

			public InputAction PrimaryButton
			{
				get
				{
					return null;
				}
			}

			public InputAction PrimaryTouch
			{
				get
				{
					return null;
				}
			}

			public InputAction SecondaryButton
			{
				get
				{
					return null;
				}
			}

			public InputAction SecondaryTouch
			{
				get
				{
					return null;
				}
			}

			public InputAction MenuButton
			{
				get
				{
					return null;
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
			}

			public ControllerLActions(InputActions wrapper)
			{
				this.m_Wrapper = default(InputActions);
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(ControllerLActions set)
			{
				return null;
			}

			public void SetCallbacks(IControllerLActions instance)
			{
			}
		}

		public struct ControllerRActions
		{
			private InputActions m_Wrapper;

			public InputAction TrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction Position
			{
				get
				{
					return null;
				}
			}

			public InputAction Rotation
			{
				get
				{
					return null;
				}
			}

			public InputAction Velocity
			{
				get
				{
					return null;
				}
			}

			public InputAction AngularVelocity
			{
				get
				{
					return null;
				}
			}

			public InputAction Primary2DAxis
			{
				get
				{
					return null;
				}
			}

			public InputAction Primary2DAxisClick
			{
				get
				{
					return null;
				}
			}

			public InputAction Primary2DAxisTouch
			{
				get
				{
					return null;
				}
			}

			public InputAction Touchpad
			{
				get
				{
					return null;
				}
			}

			public InputAction TouchpadClick
			{
				get
				{
					return null;
				}
			}

			public InputAction TouchpadTouch
			{
				get
				{
					return null;
				}
			}

			public InputAction Trigger
			{
				get
				{
					return null;
				}
			}

			public InputAction TriggerPress
			{
				get
				{
					return null;
				}
			}

			public InputAction TriggerTouch
			{
				get
				{
					return null;
				}
			}

			public InputAction Grip
			{
				get
				{
					return null;
				}
			}

			public InputAction GripPress
			{
				get
				{
					return null;
				}
			}

			public InputAction GripForce
			{
				get
				{
					return null;
				}
			}

			public InputAction PrimaryButton
			{
				get
				{
					return null;
				}
			}

			public InputAction PrimaryTouch
			{
				get
				{
					return null;
				}
			}

			public InputAction SecondaryButton
			{
				get
				{
					return null;
				}
			}

			public InputAction SecondaryTouch
			{
				get
				{
					return null;
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
			}

			public ControllerRActions(InputActions wrapper)
			{
				this.m_Wrapper = default(InputActions);
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(ControllerRActions set)
			{
				return null;
			}

			public void SetCallbacks(IControllerRActions instance)
			{
			}
		}

		public struct GamepadActions
		{
			private InputActions m_Wrapper;

			public InputAction LeftJoystick2DAxis
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftTrigger1DAxis
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftJoystickButton
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftShoulderButton
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftNorthButton
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftEastButton
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftSouthButton
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftWestButton
			{
				get
				{
					return null;
				}
			}

			public InputAction SelectButton
			{
				get
				{
					return null;
				}
			}

			public InputAction RightJoystick2DAxis
			{
				get
				{
					return null;
				}
			}

			public InputAction RightTrigger1DAxis
			{
				get
				{
					return null;
				}
			}

			public InputAction RightJoystickButton
			{
				get
				{
					return null;
				}
			}

			public InputAction RightShoulderButton
			{
				get
				{
					return null;
				}
			}

			public InputAction RightNorthButton
			{
				get
				{
					return null;
				}
			}

			public InputAction RightEastButton
			{
				get
				{
					return null;
				}
			}

			public InputAction RightSouthButton
			{
				get
				{
					return null;
				}
			}

			public InputAction RightWestButton
			{
				get
				{
					return null;
				}
			}

			public InputAction StartButton
			{
				get
				{
					return null;
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
			}

			public GamepadActions(InputActions wrapper)
			{
				this.m_Wrapper = default(InputActions);
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(GamepadActions set)
			{
				return null;
			}

			public void SetCallbacks(IGamepadActions instance)
			{
			}
		}

		public struct MouseActions
		{
			private InputActions m_Wrapper;

			public InputAction Mouse_ForwardButton
			{
				get
				{
					return null;
				}
			}

			public InputAction Mouse_BackButton
			{
				get
				{
					return null;
				}
			}

			public InputAction Mouse_RButton
			{
				get
				{
					return null;
				}
			}

			public InputAction Mouse_MButton
			{
				get
				{
					return null;
				}
			}

			public InputAction Mouse_LButton
			{
				get
				{
					return null;
				}
			}

			public InputAction Mouse_Delta
			{
				get
				{
					return null;
				}
			}

			public InputAction Mouse_Scroll
			{
				get
				{
					return null;
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
			}

			public MouseActions(InputActions wrapper)
			{
				this.m_Wrapper = default(InputActions);
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(MouseActions set)
			{
				return null;
			}

			public void SetCallbacks(IMouseActions instance)
			{
			}
		}

		public struct PositionalKeyboardActions
		{
			private InputActions m_Wrapper;

			public InputAction Positional_Escape
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Space
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Enter
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Tab
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Backquote
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Quote
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Semicolon
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Comma
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Period
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Slash
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Backslash
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_LeftBracket
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_RightBracket
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Minus
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Equals
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_UpArrow
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_DownArrow
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_LeftArrow
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_RightArrow
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_A
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_B
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_C
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_D
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_E
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_G
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_H
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_I
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_J
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_K
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_L
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_M
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_N
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_O
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_P
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Q
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_R
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_S
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_T
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_U
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_V
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_W
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_X
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Y
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Z
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_1
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_2
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_3
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_4
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_5
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_6
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_7
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_8
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_9
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_0
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_LeftShift
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_RightShift
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_LeftAlt
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_RightAlt
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_LeftCtrl
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_RightCtrl
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_LeftMeta
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_RightMeta
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_ContextMenu
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Backspace
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_PageDown
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_PageUp
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Home
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_End
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Insert
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Delete
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_CapsLock
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_NumLock
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_PrintScreen
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_ScrollLock
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Pause
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_NumpadEnter
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_NumpadDivide
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_NumpadMultiply
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_NumpadPlus
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_NumpadMinus
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_NumpadPeriod
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_NumpadEquals
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Numpad1
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Numpad2
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Numpad3
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Numpad4
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Numpad5
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Numpad6
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Numpad7
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Numpad8
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Numpad9
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_Numpad0
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F1
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F2
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F3
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F4
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F5
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F6
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F7
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F8
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F9
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F10
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F11
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_F12
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_OEM1
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_OEM2
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_OEM3
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_OEM4
			{
				get
				{
					return null;
				}
			}

			public InputAction Positional_OEM5
			{
				get
				{
					return null;
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
			}

			public PositionalKeyboardActions(InputActions wrapper)
			{
				this.m_Wrapper = default(InputActions);
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(PositionalKeyboardActions set)
			{
				return null;
			}

			public void SetCallbacks(IPositionalKeyboardActions instance)
			{
			}
		}

		public struct JoystickActions
		{
			private InputActions m_Wrapper;

			public InputAction Stick
			{
				get
				{
					return null;
				}
			}

			public InputAction Trigger
			{
				get
				{
					return null;
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
			}

			public JoystickActions(InputActions wrapper)
			{
				this.m_Wrapper = default(InputActions);
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(JoystickActions set)
			{
				return null;
			}

			public void SetCallbacks(IJoystickActions instance)
			{
			}
		}

		public struct TrackersActions
		{
			private InputActions m_Wrapper;

			public InputAction LeftFoot
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftFootTrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction RightFoot
			{
				get
				{
					return null;
				}
			}

			public InputAction RightFootTrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftShoulder
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftShoulderTrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction RightShoulder
			{
				get
				{
					return null;
				}
			}

			public InputAction RightShoulderTrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftElbow
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftElbowTrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction RightElbow
			{
				get
				{
					return null;
				}
			}

			public InputAction RightElbowTrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftKnee
			{
				get
				{
					return null;
				}
			}

			public InputAction LeftKneeTrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction RightKnee
			{
				get
				{
					return null;
				}
			}

			public InputAction RightKneeTrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction Waist
			{
				get
				{
					return null;
				}
			}

			public InputAction WaistTrackingState
			{
				get
				{
					return null;
				}
			}

			public InputAction Chest
			{
				get
				{
					return null;
				}
			}

			public InputAction ChestTrackingState
			{
				get
				{
					return null;
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
			}

			public TrackersActions(InputActions wrapper)
			{
				this.m_Wrapper = default(InputActions);
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(TrackersActions set)
			{
				return null;
			}

			public void SetCallbacks(ITrackersActions instance)
			{
			}
		}

		public interface IHMDActions
		{
			void OnTrackingState(InputAction.CallbackContext context);

			void OnPosition(InputAction.CallbackContext context);

			void OnRotation(InputAction.CallbackContext context);

			void OnVelocity(InputAction.CallbackContext context);

			void OnAngularVelocity(InputAction.CallbackContext context);
		}

		public interface IControllerLActions
		{
			void OnTrackingState(InputAction.CallbackContext context);

			void OnPosition(InputAction.CallbackContext context);

			void OnRotation(InputAction.CallbackContext context);

			void OnVelocity(InputAction.CallbackContext context);

			void OnAngularVelocity(InputAction.CallbackContext context);

			void OnPrimary2DAxis(InputAction.CallbackContext context);

			void OnPrimary2DAxisClick(InputAction.CallbackContext context);

			void OnPrimary2DAxisTouch(InputAction.CallbackContext context);

			void OnTouchpad(InputAction.CallbackContext context);

			void OnTouchpadClick(InputAction.CallbackContext context);

			void OnTouchpadTouch(InputAction.CallbackContext context);

			void OnTrigger(InputAction.CallbackContext context);

			void OnTriggerPress(InputAction.CallbackContext context);

			void OnTriggerTouch(InputAction.CallbackContext context);

			void OnGrip(InputAction.CallbackContext context);

			void OnGripPress(InputAction.CallbackContext context);

			void OnGripForce(InputAction.CallbackContext context);

			void OnPrimaryButton(InputAction.CallbackContext context);

			void OnPrimaryTouch(InputAction.CallbackContext context);

			void OnSecondaryButton(InputAction.CallbackContext context);

			void OnSecondaryTouch(InputAction.CallbackContext context);

			void OnMenuButton(InputAction.CallbackContext context);
		}

		public interface IControllerRActions
		{
			void OnTrackingState(InputAction.CallbackContext context);

			void OnPosition(InputAction.CallbackContext context);

			void OnRotation(InputAction.CallbackContext context);

			void OnVelocity(InputAction.CallbackContext context);

			void OnAngularVelocity(InputAction.CallbackContext context);

			void OnPrimary2DAxis(InputAction.CallbackContext context);

			void OnPrimary2DAxisClick(InputAction.CallbackContext context);

			void OnPrimary2DAxisTouch(InputAction.CallbackContext context);

			void OnTouchpad(InputAction.CallbackContext context);

			void OnTouchpadClick(InputAction.CallbackContext context);

			void OnTouchpadTouch(InputAction.CallbackContext context);

			void OnTrigger(InputAction.CallbackContext context);

			void OnTriggerPress(InputAction.CallbackContext context);

			void OnTriggerTouch(InputAction.CallbackContext context);

			void OnGrip(InputAction.CallbackContext context);

			void OnGripPress(InputAction.CallbackContext context);

			void OnGripForce(InputAction.CallbackContext context);

			void OnPrimaryButton(InputAction.CallbackContext context);

			void OnPrimaryTouch(InputAction.CallbackContext context);

			void OnSecondaryButton(InputAction.CallbackContext context);

			void OnSecondaryTouch(InputAction.CallbackContext context);
		}

		public interface IGamepadActions
		{
			void OnLeftJoystick2DAxis(InputAction.CallbackContext context);

			void OnLeftTrigger1DAxis(InputAction.CallbackContext context);

			void OnLeftJoystickButton(InputAction.CallbackContext context);

			void OnLeftShoulderButton(InputAction.CallbackContext context);

			void OnLeftNorthButton(InputAction.CallbackContext context);

			void OnLeftEastButton(InputAction.CallbackContext context);

			void OnLeftSouthButton(InputAction.CallbackContext context);

			void OnLeftWestButton(InputAction.CallbackContext context);

			void OnSelectButton(InputAction.CallbackContext context);

			void OnRightJoystick2DAxis(InputAction.CallbackContext context);

			void OnRightTrigger1DAxis(InputAction.CallbackContext context);

			void OnRightJoystickButton(InputAction.CallbackContext context);

			void OnRightShoulderButton(InputAction.CallbackContext context);

			void OnRightNorthButton(InputAction.CallbackContext context);

			void OnRightEastButton(InputAction.CallbackContext context);

			void OnRightSouthButton(InputAction.CallbackContext context);

			void OnRightWestButton(InputAction.CallbackContext context);

			void OnStartButton(InputAction.CallbackContext context);
		}

		public interface IMouseActions
		{
			void OnMouse_ForwardButton(InputAction.CallbackContext context);

			void OnMouse_BackButton(InputAction.CallbackContext context);

			void OnMouse_RButton(InputAction.CallbackContext context);

			void OnMouse_MButton(InputAction.CallbackContext context);

			void OnMouse_LButton(InputAction.CallbackContext context);

			void OnMouse_Delta(InputAction.CallbackContext context);

			void OnMouse_Scroll(InputAction.CallbackContext context);
		}

		public interface IPositionalKeyboardActions
		{
			void OnPositional_Escape(InputAction.CallbackContext context);

			void OnPositional_Space(InputAction.CallbackContext context);

			void OnPositional_Enter(InputAction.CallbackContext context);

			void OnPositional_Tab(InputAction.CallbackContext context);

			void OnPositional_Backquote(InputAction.CallbackContext context);

			void OnPositional_Quote(InputAction.CallbackContext context);

			void OnPositional_Semicolon(InputAction.CallbackContext context);

			void OnPositional_Comma(InputAction.CallbackContext context);

			void OnPositional_Period(InputAction.CallbackContext context);

			void OnPositional_Slash(InputAction.CallbackContext context);

			void OnPositional_Backslash(InputAction.CallbackContext context);

			void OnPositional_LeftBracket(InputAction.CallbackContext context);

			void OnPositional_RightBracket(InputAction.CallbackContext context);

			void OnPositional_Minus(InputAction.CallbackContext context);

			void OnPositional_Equals(InputAction.CallbackContext context);

			void OnPositional_UpArrow(InputAction.CallbackContext context);

			void OnPositional_DownArrow(InputAction.CallbackContext context);

			void OnPositional_LeftArrow(InputAction.CallbackContext context);

			void OnPositional_RightArrow(InputAction.CallbackContext context);

			void OnPositional_A(InputAction.CallbackContext context);

			void OnPositional_B(InputAction.CallbackContext context);

			void OnPositional_C(InputAction.CallbackContext context);

			void OnPositional_D(InputAction.CallbackContext context);

			void OnPositional_E(InputAction.CallbackContext context);

			void OnPositional_F(InputAction.CallbackContext context);

			void OnPositional_G(InputAction.CallbackContext context);

			void OnPositional_H(InputAction.CallbackContext context);

			void OnPositional_I(InputAction.CallbackContext context);

			void OnPositional_J(InputAction.CallbackContext context);

			void OnPositional_K(InputAction.CallbackContext context);

			void OnPositional_L(InputAction.CallbackContext context);

			void OnPositional_M(InputAction.CallbackContext context);

			void OnPositional_N(InputAction.CallbackContext context);

			void OnPositional_O(InputAction.CallbackContext context);

			void OnPositional_P(InputAction.CallbackContext context);

			void OnPositional_Q(InputAction.CallbackContext context);

			void OnPositional_R(InputAction.CallbackContext context);

			void OnPositional_S(InputAction.CallbackContext context);

			void OnPositional_T(InputAction.CallbackContext context);

			void OnPositional_U(InputAction.CallbackContext context);

			void OnPositional_V(InputAction.CallbackContext context);

			void OnPositional_W(InputAction.CallbackContext context);

			void OnPositional_X(InputAction.CallbackContext context);

			void OnPositional_Y(InputAction.CallbackContext context);

			void OnPositional_Z(InputAction.CallbackContext context);

			void OnPositional_1(InputAction.CallbackContext context);

			void OnPositional_2(InputAction.CallbackContext context);

			void OnPositional_3(InputAction.CallbackContext context);

			void OnPositional_4(InputAction.CallbackContext context);

			void OnPositional_5(InputAction.CallbackContext context);

			void OnPositional_6(InputAction.CallbackContext context);

			void OnPositional_7(InputAction.CallbackContext context);

			void OnPositional_8(InputAction.CallbackContext context);

			void OnPositional_9(InputAction.CallbackContext context);

			void OnPositional_0(InputAction.CallbackContext context);

			void OnPositional_LeftShift(InputAction.CallbackContext context);

			void OnPositional_RightShift(InputAction.CallbackContext context);

			void OnPositional_LeftAlt(InputAction.CallbackContext context);

			void OnPositional_RightAlt(InputAction.CallbackContext context);

			void OnPositional_LeftCtrl(InputAction.CallbackContext context);

			void OnPositional_RightCtrl(InputAction.CallbackContext context);

			void OnPositional_LeftMeta(InputAction.CallbackContext context);

			void OnPositional_RightMeta(InputAction.CallbackContext context);

			void OnPositional_ContextMenu(InputAction.CallbackContext context);

			void OnPositional_Backspace(InputAction.CallbackContext context);

			void OnPositional_PageDown(InputAction.CallbackContext context);

			void OnPositional_PageUp(InputAction.CallbackContext context);

			void OnPositional_Home(InputAction.CallbackContext context);

			void OnPositional_End(InputAction.CallbackContext context);

			void OnPositional_Insert(InputAction.CallbackContext context);

			void OnPositional_Delete(InputAction.CallbackContext context);

			void OnPositional_CapsLock(InputAction.CallbackContext context);

			void OnPositional_NumLock(InputAction.CallbackContext context);

			void OnPositional_PrintScreen(InputAction.CallbackContext context);

			void OnPositional_ScrollLock(InputAction.CallbackContext context);

			void OnPositional_Pause(InputAction.CallbackContext context);

			void OnPositional_NumpadEnter(InputAction.CallbackContext context);

			void OnPositional_NumpadDivide(InputAction.CallbackContext context);

			void OnPositional_NumpadMultiply(InputAction.CallbackContext context);

			void OnPositional_NumpadPlus(InputAction.CallbackContext context);

			void OnPositional_NumpadMinus(InputAction.CallbackContext context);

			void OnPositional_NumpadPeriod(InputAction.CallbackContext context);

			void OnPositional_NumpadEquals(InputAction.CallbackContext context);

			void OnPositional_Numpad1(InputAction.CallbackContext context);

			void OnPositional_Numpad2(InputAction.CallbackContext context);

			void OnPositional_Numpad3(InputAction.CallbackContext context);

			void OnPositional_Numpad4(InputAction.CallbackContext context);

			void OnPositional_Numpad5(InputAction.CallbackContext context);

			void OnPositional_Numpad6(InputAction.CallbackContext context);

			void OnPositional_Numpad7(InputAction.CallbackContext context);

			void OnPositional_Numpad8(InputAction.CallbackContext context);

			void OnPositional_Numpad9(InputAction.CallbackContext context);

			void OnPositional_Numpad0(InputAction.CallbackContext context);

			void OnPositional_F1(InputAction.CallbackContext context);

			void OnPositional_F2(InputAction.CallbackContext context);

			void OnPositional_F3(InputAction.CallbackContext context);

			void OnPositional_F4(InputAction.CallbackContext context);

			void OnPositional_F5(InputAction.CallbackContext context);

			void OnPositional_F6(InputAction.CallbackContext context);

			void OnPositional_F7(InputAction.CallbackContext context);

			void OnPositional_F8(InputAction.CallbackContext context);

			void OnPositional_F9(InputAction.CallbackContext context);

			void OnPositional_F10(InputAction.CallbackContext context);

			void OnPositional_F11(InputAction.CallbackContext context);

			void OnPositional_F12(InputAction.CallbackContext context);

			void OnPositional_OEM1(InputAction.CallbackContext context);

			void OnPositional_OEM2(InputAction.CallbackContext context);

			void OnPositional_OEM3(InputAction.CallbackContext context);

			void OnPositional_OEM4(InputAction.CallbackContext context);

			void OnPositional_OEM5(InputAction.CallbackContext context);
		}

		public interface IJoystickActions
		{
			void OnStick(InputAction.CallbackContext context);

			void OnTrigger(InputAction.CallbackContext context);
		}

		public interface ITrackersActions
		{
			void OnLeftFoot(InputAction.CallbackContext context);

			void OnLeftFootTrackingState(InputAction.CallbackContext context);

			void OnRightFoot(InputAction.CallbackContext context);

			void OnRightFootTrackingState(InputAction.CallbackContext context);

			void OnLeftShoulder(InputAction.CallbackContext context);

			void OnLeftShoulderTrackingState(InputAction.CallbackContext context);

			void OnRightShoulder(InputAction.CallbackContext context);

			void OnRightShoulderTrackingState(InputAction.CallbackContext context);

			void OnLeftElbow(InputAction.CallbackContext context);

			void OnLeftElbowTrackingState(InputAction.CallbackContext context);

			void OnRightElbow(InputAction.CallbackContext context);

			void OnRightElbowTrackingState(InputAction.CallbackContext context);

			void OnLeftKnee(InputAction.CallbackContext context);

			void OnLeftKneeTrackingState(InputAction.CallbackContext context);

			void OnRightKnee(InputAction.CallbackContext context);

			void OnRightKneeTrackingState(InputAction.CallbackContext context);

			void OnWaist(InputAction.CallbackContext context);

			void OnWaistTrackingState(InputAction.CallbackContext context);

			void OnChest(InputAction.CallbackContext context);

			void OnChestTrackingState(InputAction.CallbackContext context);
		}

		private readonly InputActionMap m_HMD;

		private IHMDActions m_HMDActionsCallbackInterface;

		private readonly InputAction m_HMD_TrackingState;

		private readonly InputAction m_HMD_Position;

		private readonly InputAction m_HMD_Rotation;

		private readonly InputAction m_HMD_Velocity;

		private readonly InputAction m_HMD_AngularVelocity;

		private readonly InputActionMap m_ControllerL;

		private IControllerLActions m_ControllerLActionsCallbackInterface;

		private readonly InputAction m_ControllerL_TrackingState;

		private readonly InputAction m_ControllerL_Position;

		private readonly InputAction m_ControllerL_Rotation;

		private readonly InputAction m_ControllerL_Velocity;

		private readonly InputAction m_ControllerL_AngularVelocity;

		private readonly InputAction m_ControllerL_Primary2DAxis;

		private readonly InputAction m_ControllerL_Primary2DAxisClick;

		private readonly InputAction m_ControllerL_Primary2DAxisTouch;

		private readonly InputAction m_ControllerL_Touchpad;

		private readonly InputAction m_ControllerL_TouchpadClick;

		private readonly InputAction m_ControllerL_TouchpadTouch;

		private readonly InputAction m_ControllerL_Trigger;

		private readonly InputAction m_ControllerL_TriggerPress;

		private readonly InputAction m_ControllerL_TriggerTouch;

		private readonly InputAction m_ControllerL_Grip;

		private readonly InputAction m_ControllerL_GripPress;

		private readonly InputAction m_ControllerL_GripForce;

		private readonly InputAction m_ControllerL_PrimaryButton;

		private readonly InputAction m_ControllerL_PrimaryTouch;

		private readonly InputAction m_ControllerL_SecondaryButton;

		private readonly InputAction m_ControllerL_SecondaryTouch;

		private readonly InputAction m_ControllerL_MenuButton;

		private readonly InputActionMap m_ControllerR;

		private IControllerRActions m_ControllerRActionsCallbackInterface;

		private readonly InputAction m_ControllerR_TrackingState;

		private readonly InputAction m_ControllerR_Position;

		private readonly InputAction m_ControllerR_Rotation;

		private readonly InputAction m_ControllerR_Velocity;

		private readonly InputAction m_ControllerR_AngularVelocity;

		private readonly InputAction m_ControllerR_Primary2DAxis;

		private readonly InputAction m_ControllerR_Primary2DAxisClick;

		private readonly InputAction m_ControllerR_Primary2DAxisTouch;

		private readonly InputAction m_ControllerR_Touchpad;

		private readonly InputAction m_ControllerR_TouchpadClick;

		private readonly InputAction m_ControllerR_TouchpadTouch;

		private readonly InputAction m_ControllerR_Trigger;

		private readonly InputAction m_ControllerR_TriggerPress;

		private readonly InputAction m_ControllerR_TriggerTouch;

		private readonly InputAction m_ControllerR_Grip;

		private readonly InputAction m_ControllerR_GripPress;

		private readonly InputAction m_ControllerR_GripForce;

		private readonly InputAction m_ControllerR_PrimaryButton;

		private readonly InputAction m_ControllerR_PrimaryTouch;

		private readonly InputAction m_ControllerR_SecondaryButton;

		private readonly InputAction m_ControllerR_SecondaryTouch;

		private readonly InputActionMap m_Gamepad;

		private IGamepadActions m_GamepadActionsCallbackInterface;

		private readonly InputAction m_Gamepad_LeftJoystick2DAxis;

		private readonly InputAction m_Gamepad_LeftTrigger1DAxis;

		private readonly InputAction m_Gamepad_LeftJoystickButton;

		private readonly InputAction m_Gamepad_LeftShoulderButton;

		private readonly InputAction m_Gamepad_LeftNorthButton;

		private readonly InputAction m_Gamepad_LeftEastButton;

		private readonly InputAction m_Gamepad_LeftSouthButton;

		private readonly InputAction m_Gamepad_LeftWestButton;

		private readonly InputAction m_Gamepad_SelectButton;

		private readonly InputAction m_Gamepad_RightJoystick2DAxis;

		private readonly InputAction m_Gamepad_RightTrigger1DAxis;

		private readonly InputAction m_Gamepad_RightJoystickButton;

		private readonly InputAction m_Gamepad_RightShoulderButton;

		private readonly InputAction m_Gamepad_RightNorthButton;

		private readonly InputAction m_Gamepad_RightEastButton;

		private readonly InputAction m_Gamepad_RightSouthButton;

		private readonly InputAction m_Gamepad_RightWestButton;

		private readonly InputAction m_Gamepad_StartButton;

		private readonly InputActionMap m_Mouse;

		private IMouseActions m_MouseActionsCallbackInterface;

		private readonly InputAction m_Mouse_Mouse_ForwardButton;

		private readonly InputAction m_Mouse_Mouse_BackButton;

		private readonly InputAction m_Mouse_Mouse_RButton;

		private readonly InputAction m_Mouse_Mouse_MButton;

		private readonly InputAction m_Mouse_Mouse_LButton;

		private readonly InputAction m_Mouse_Mouse_Delta;

		private readonly InputAction m_Mouse_Mouse_Scroll;

		private readonly InputActionMap m_PositionalKeyboard;

		private IPositionalKeyboardActions m_PositionalKeyboardActionsCallbackInterface;

		private readonly InputAction m_PositionalKeyboard_Positional_Escape;

		private readonly InputAction m_PositionalKeyboard_Positional_Space;

		private readonly InputAction m_PositionalKeyboard_Positional_Enter;

		private readonly InputAction m_PositionalKeyboard_Positional_Tab;

		private readonly InputAction m_PositionalKeyboard_Positional_Backquote;

		private readonly InputAction m_PositionalKeyboard_Positional_Quote;

		private readonly InputAction m_PositionalKeyboard_Positional_Semicolon;

		private readonly InputAction m_PositionalKeyboard_Positional_Comma;

		private readonly InputAction m_PositionalKeyboard_Positional_Period;

		private readonly InputAction m_PositionalKeyboard_Positional_Slash;

		private readonly InputAction m_PositionalKeyboard_Positional_Backslash;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftBracket;

		private readonly InputAction m_PositionalKeyboard_Positional_RightBracket;

		private readonly InputAction m_PositionalKeyboard_Positional_Minus;

		private readonly InputAction m_PositionalKeyboard_Positional_Equals;

		private readonly InputAction m_PositionalKeyboard_Positional_UpArrow;

		private readonly InputAction m_PositionalKeyboard_Positional_DownArrow;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftArrow;

		private readonly InputAction m_PositionalKeyboard_Positional_RightArrow;

		private readonly InputAction m_PositionalKeyboard_Positional_A;

		private readonly InputAction m_PositionalKeyboard_Positional_B;

		private readonly InputAction m_PositionalKeyboard_Positional_C;

		private readonly InputAction m_PositionalKeyboard_Positional_D;

		private readonly InputAction m_PositionalKeyboard_Positional_E;

		private readonly InputAction m_PositionalKeyboard_Positional_F;

		private readonly InputAction m_PositionalKeyboard_Positional_G;

		private readonly InputAction m_PositionalKeyboard_Positional_H;

		private readonly InputAction m_PositionalKeyboard_Positional_I;

		private readonly InputAction m_PositionalKeyboard_Positional_J;

		private readonly InputAction m_PositionalKeyboard_Positional_K;

		private readonly InputAction m_PositionalKeyboard_Positional_L;

		private readonly InputAction m_PositionalKeyboard_Positional_M;

		private readonly InputAction m_PositionalKeyboard_Positional_N;

		private readonly InputAction m_PositionalKeyboard_Positional_O;

		private readonly InputAction m_PositionalKeyboard_Positional_P;

		private readonly InputAction m_PositionalKeyboard_Positional_Q;

		private readonly InputAction m_PositionalKeyboard_Positional_R;

		private readonly InputAction m_PositionalKeyboard_Positional_S;

		private readonly InputAction m_PositionalKeyboard_Positional_T;

		private readonly InputAction m_PositionalKeyboard_Positional_U;

		private readonly InputAction m_PositionalKeyboard_Positional_V;

		private readonly InputAction m_PositionalKeyboard_Positional_W;

		private readonly InputAction m_PositionalKeyboard_Positional_X;

		private readonly InputAction m_PositionalKeyboard_Positional_Y;

		private readonly InputAction m_PositionalKeyboard_Positional_Z;

		private readonly InputAction m_PositionalKeyboard_Positional_1;

		private readonly InputAction m_PositionalKeyboard_Positional_2;

		private readonly InputAction m_PositionalKeyboard_Positional_3;

		private readonly InputAction m_PositionalKeyboard_Positional_4;

		private readonly InputAction m_PositionalKeyboard_Positional_5;

		private readonly InputAction m_PositionalKeyboard_Positional_6;

		private readonly InputAction m_PositionalKeyboard_Positional_7;

		private readonly InputAction m_PositionalKeyboard_Positional_8;

		private readonly InputAction m_PositionalKeyboard_Positional_9;

		private readonly InputAction m_PositionalKeyboard_Positional_0;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftShift;

		private readonly InputAction m_PositionalKeyboard_Positional_RightShift;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftAlt;

		private readonly InputAction m_PositionalKeyboard_Positional_RightAlt;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftCtrl;

		private readonly InputAction m_PositionalKeyboard_Positional_RightCtrl;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftMeta;

		private readonly InputAction m_PositionalKeyboard_Positional_RightMeta;

		private readonly InputAction m_PositionalKeyboard_Positional_ContextMenu;

		private readonly InputAction m_PositionalKeyboard_Positional_Backspace;

		private readonly InputAction m_PositionalKeyboard_Positional_PageDown;

		private readonly InputAction m_PositionalKeyboard_Positional_PageUp;

		private readonly InputAction m_PositionalKeyboard_Positional_Home;

		private readonly InputAction m_PositionalKeyboard_Positional_End;

		private readonly InputAction m_PositionalKeyboard_Positional_Insert;

		private readonly InputAction m_PositionalKeyboard_Positional_Delete;

		private readonly InputAction m_PositionalKeyboard_Positional_CapsLock;

		private readonly InputAction m_PositionalKeyboard_Positional_NumLock;

		private readonly InputAction m_PositionalKeyboard_Positional_PrintScreen;

		private readonly InputAction m_PositionalKeyboard_Positional_ScrollLock;

		private readonly InputAction m_PositionalKeyboard_Positional_Pause;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadEnter;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadDivide;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadMultiply;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadPlus;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadMinus;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadPeriod;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadEquals;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad1;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad2;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad3;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad4;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad5;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad6;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad7;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad8;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad9;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad0;

		private readonly InputAction m_PositionalKeyboard_Positional_F1;

		private readonly InputAction m_PositionalKeyboard_Positional_F2;

		private readonly InputAction m_PositionalKeyboard_Positional_F3;

		private readonly InputAction m_PositionalKeyboard_Positional_F4;

		private readonly InputAction m_PositionalKeyboard_Positional_F5;

		private readonly InputAction m_PositionalKeyboard_Positional_F6;

		private readonly InputAction m_PositionalKeyboard_Positional_F7;

		private readonly InputAction m_PositionalKeyboard_Positional_F8;

		private readonly InputAction m_PositionalKeyboard_Positional_F9;

		private readonly InputAction m_PositionalKeyboard_Positional_F10;

		private readonly InputAction m_PositionalKeyboard_Positional_F11;

		private readonly InputAction m_PositionalKeyboard_Positional_F12;

		private readonly InputAction m_PositionalKeyboard_Positional_OEM1;

		private readonly InputAction m_PositionalKeyboard_Positional_OEM2;

		private readonly InputAction m_PositionalKeyboard_Positional_OEM3;

		private readonly InputAction m_PositionalKeyboard_Positional_OEM4;

		private readonly InputAction m_PositionalKeyboard_Positional_OEM5;

		private readonly InputActionMap m_Joystick;

		private IJoystickActions m_JoystickActionsCallbackInterface;

		private readonly InputAction m_Joystick_Stick;

		private readonly InputAction m_Joystick_Trigger;

		private readonly InputActionMap m_Trackers;

		private ITrackersActions m_TrackersActionsCallbackInterface;

		private readonly InputAction m_Trackers_LeftFoot;

		private readonly InputAction m_Trackers_LeftFootTrackingState;

		private readonly InputAction m_Trackers_RightFoot;

		private readonly InputAction m_Trackers_RightFootTrackingState;

		private readonly InputAction m_Trackers_LeftShoulder;

		private readonly InputAction m_Trackers_LeftShoulderTrackingState;

		private readonly InputAction m_Trackers_RightShoulder;

		private readonly InputAction m_Trackers_RightShoulderTrackingState;

		private readonly InputAction m_Trackers_LeftElbow;

		private readonly InputAction m_Trackers_LeftElbowTrackingState;

		private readonly InputAction m_Trackers_RightElbow;

		private readonly InputAction m_Trackers_RightElbowTrackingState;

		private readonly InputAction m_Trackers_LeftKnee;

		private readonly InputAction m_Trackers_LeftKneeTrackingState;

		private readonly InputAction m_Trackers_RightKnee;

		private readonly InputAction m_Trackers_RightKneeTrackingState;

		private readonly InputAction m_Trackers_Waist;

		private readonly InputAction m_Trackers_WaistTrackingState;

		private readonly InputAction m_Trackers_Chest;

		private readonly InputAction m_Trackers_ChestTrackingState;

		private int m_XRUsageSchemeIndex;

		private int m_GamepadSchemeIndex;

		private int m_PositionalKeyboardMouseSchemeIndex;

		public InputActionAsset asset { get; }

		public InputBinding? bindingMask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ReadOnlyArray<InputDevice>? devices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ReadOnlyArray<InputControlScheme> controlSchemes
		{
			get
			{
				return default(ReadOnlyArray<InputControlScheme>);
			}
		}

		public IEnumerable<InputBinding> bindings
		{
			get
			{
				return null;
			}
		}

		public HMDActions HMD
		{
			get
			{
				return default(HMDActions);
			}
		}

		public ControllerLActions ControllerL
		{
			get
			{
				return default(ControllerLActions);
			}
		}

		public ControllerRActions ControllerR
		{
			get
			{
				return default(ControllerRActions);
			}
		}

		public GamepadActions Gamepad
		{
			get
			{
				return default(GamepadActions);
			}
		}

		public MouseActions Mouse
		{
			get
			{
				return default(MouseActions);
			}
		}

		public PositionalKeyboardActions PositionalKeyboard
		{
			get
			{
				return default(PositionalKeyboardActions);
			}
		}

		public JoystickActions Joystick
		{
			get
			{
				return default(JoystickActions);
			}
		}

		public TrackersActions Trackers
		{
			get
			{
				return default(TrackersActions);
			}
		}

		public InputControlScheme XRUsageScheme
		{
			get
			{
				return default(InputControlScheme);
			}
		}

		public InputControlScheme GamepadScheme
		{
			get
			{
				return default(InputControlScheme);
			}
		}

		public InputControlScheme PositionalKeyboardMouseScheme
		{
			get
			{
				return default(InputControlScheme);
			}
		}

		public void Dispose()
		{
		}

		public bool Contains(InputAction action)
		{
			return default(bool);
		}

		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		public int FindBinding(InputBinding bindingMask, [Out] InputAction action)
		{
			return default(int);
		}

		public InputActions()
			: base()
		{
		}
	}
}
