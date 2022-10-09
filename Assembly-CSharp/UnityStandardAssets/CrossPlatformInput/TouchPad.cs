using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UnityStandardAssets.CrossPlatformInput
{
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public enum AxisOption
		{
			Both = 0,
			OnlyHorizontal = 1,
			OnlyVertical = 2
		}

		public enum ControlStyle
		{
			Absolute = 0,
			Relative = 1,
			Swipe = 2
		}

		public AxisOption axesToUse;

		public ControlStyle controlStyle;

		public string horizontalAxisName;

		public string verticalAxisName;

		public float Xsensitivity;

		public float Ysensitivity;

		private Vector3 m_StartPos;

		private Vector2 m_PreviousDelta;

		private Vector3 m_JoytickOutput;

		private bool m_UseX;

		private bool m_UseY;

		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		private bool m_Dragging;

		private int m_Id;

		private Vector2 m_PreviousTouchPos;

		private Vector3 m_Center;

		private Image m_Image;

		private void OnEnable()
		{
		}

		private void CreateVirtualAxes()
		{
		}

		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		private void Update()
		{
		}

		public void OnPointerUp(PointerEventData data)
		{
		}

		private void OnDisable()
		{
		}

		public TouchPad()
			: base()
		{
		}
	}
}
