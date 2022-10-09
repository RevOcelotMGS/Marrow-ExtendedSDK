using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		public enum AxisOption
		{
			Both = 0,
			OnlyHorizontal = 1,
			OnlyVertical = 2
		}

		public int MovementRange;

		public AxisOption axesToUse;

		public string horizontalAxisName;

		public string verticalAxisName;

		private Vector3 m_StartPos;

		private bool m_UseX;

		private bool m_UseY;

		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		private void OnEnable()
		{
		}

		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		private void CreateVirtualAxes()
		{
		}

		public void OnDrag(PointerEventData data)
		{
		}

		public void OnPointerUp(PointerEventData data)
		{
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		private void OnDisable()
		{
		}

		public Joystick()
			: base()
		{
		}
	}
}
