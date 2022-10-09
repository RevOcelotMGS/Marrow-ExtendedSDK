using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public string axisName;

		public float axisValue;

		public float responseSpeed;

		public float returnToCentreSpeed;

		private AxisTouchButton m_PairedWith;

		private CrossPlatformInputManager.VirtualAxis m_Axis;

		private void OnEnable()
		{
		}

		private void FindPairedButton()
		{
		}

		private void OnDisable()
		{
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		public void OnPointerUp(PointerEventData data)
		{
		}

		public AxisTouchButton()
			: base()
		{
		}
	}
}
