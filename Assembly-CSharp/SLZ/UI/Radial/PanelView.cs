using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.UI.Radial
{
	public class PanelView : MonoBehaviour
	{
		public PopUpMenuView popUpMenu;

		protected bool m_isActive;

		private bool m_IsActiveThisFrame;

		private VRStandaloneInputModule _module;

		public bool IsActive
		{
			get
			{
				return default(bool);
			}
		}

		private VRStandaloneInputModule module
		{
			get
			{
				return null;
			}
		}

		public virtual void CloseMenu()
		{
		}

		public virtual void Activate()
		{
		}

		public virtual void Deactivate()
		{
		}

		public virtual bool Trigger()
		{
			return default(bool);
		}

		public void UpdateCursor(Vector3 origin, Vector3 forward, bool isPressed)
		{
		}

		public void Clear()
		{
		}

		public PanelView()
			: base()
		{
		}
	}
}
