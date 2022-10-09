using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.EventSystems
{
	public abstract class VRInputModule : BaseInputModule
	{
		protected class ButtonState
		{
			private PointerEventData.InputButton m_Button;

			private MouseButtonEventData m_EventData;

			public MouseButtonEventData eventData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public PointerEventData.InputButton button
			{
				get
				{
					return default(PointerEventData.InputButton);
				}
				set
				{
				}
			}

			public ButtonState()
				: base()
			{
			}
		}

		protected class MouseState
		{
			private List<ButtonState> m_TrackedButtons;

			public bool hasHitUIElement;

			public bool AnyPressesThisFrame()
			{
				return default(bool);
			}

			public bool AnyReleasesThisFrame()
			{
				return default(bool);
			}

			public ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				return null;
			}

			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
			}

			public MouseState()
				: base()
			{
			}
		}

		public class MouseButtonEventData
		{
			public PointerEventData.FramePressState buttonState;

			public PointerEventData buttonData;

			public bool PressedThisFrame()
			{
				return default(bool);
			}

			public bool ReleasedThisFrame()
			{
				return default(bool);
			}

			public MouseButtonEventData()
				: base()
			{
			}
		}

		public const int kMouseLeftId = -1;

		public const int kMouseRightId = -2;

		public const int kMouseMiddleId = -3;

		public const int kFakeTouchesId = -4;

		protected Dictionary<int, PointerEventData> m_PointerData;

		private Vector3 m_RaycastOrigin;

		private Vector3 m_RaycastNormal;

		private bool m_InputPressed;

		private readonly MouseState m_MouseState;

		public void UpdateRaycastPosition(Vector3 position, Vector3 normal, bool isPressed)
		{
		}

		protected bool GetPointerData(int id, [Out] PointerEventData data, bool create)
		{
			return default(bool);
		}

		protected void RemovePointerData(PointerEventData data)
		{
		}

		protected PointerEventData GetTouchPointerEventData(Touch input, [Out] bool pressed, [Out] bool released)
		{
			return null;
		}

		private void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		protected static PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			return default(PointerEventData.FramePressState);
		}

		protected virtual MouseState GetMousePointerEventData()
		{
			return null;
		}

		protected PointerEventData GetLastPointerEventData(int id)
		{
			return null;
		}

		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		protected virtual void ProcessDrag(PointerEventData pointerEvent)
		{
		}

		public override bool IsPointerOverGameObject(int pointerId)
		{
			return default(bool);
		}

		protected void ClearSelection()
		{
		}

		public override string ToString()
		{
			return null;
		}

		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		public VRInputModule()
			: base()
		{
		}
	}
}
