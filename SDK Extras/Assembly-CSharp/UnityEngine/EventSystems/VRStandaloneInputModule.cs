using System;

namespace UnityEngine.EventSystems
{
	[AddComponentMenu("Event/Standalone Input Module")]
	public class VRStandaloneInputModule : VRInputModule
	{
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode
		{
			Mouse = 0,
			Buttons = 1
		}

		private float m_NextAction;

		private Vector2 m_LastMousePosition;

		private Vector2 m_MousePosition;

		public static bool hasHitUIElement;

		[SerializeField]
		private string m_HorizontalAxis;

		[SerializeField]
		private string m_VerticalAxis;

		[SerializeField]
		private string m_SubmitButton;

		[SerializeField]
		private string m_CancelButton;

		[SerializeField]
		private float m_InputActionsPerSecond;

		[SerializeField]
		private bool m_AllowActivationOnMobileDevice;

		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public InputMode inputMode
		{
			get
			{
				return default(InputMode);
			}
		}

		public bool allowActivationOnMobileDevice
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float inputActionsPerSecond
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public string horizontalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string verticalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string submitButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string cancelButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected VRStandaloneInputModule()
			: base()
		{
		}

		public override void UpdateModule()
		{
		}

		public override bool IsModuleSupported()
		{
			return default(bool);
		}

		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		public override void ActivateModule()
		{
		}

		public override void DeactivateModule()
		{
		}

		public override void Process()
		{
		}

		private bool SendSubmitEventToSelectedObject()
		{
			return default(bool);
		}

		private bool AllowMoveEventProcessing(float time)
		{
			return default(bool);
		}

		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		private bool SendMoveEventToSelectedObject()
		{
			return default(bool);
		}

		private void ProcessMouseEvent()
		{
		}

		private static bool UseMouse(bool pressed, bool released, PointerEventData pointerData)
		{
			return default(bool);
		}

		private bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		private void ProcessMousePress(MouseButtonEventData data)
		{
		}
	}
}
