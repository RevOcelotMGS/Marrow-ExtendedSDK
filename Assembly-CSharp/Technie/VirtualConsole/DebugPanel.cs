using UnityEngine;

namespace Technie.VirtualConsole
{
	public class DebugPanel : MonoBehaviour
	{
		public string panelName;

		private bool isAttached;

		public bool IsAttached()
		{
			return default(bool);
		}

		public void NotifyOnAttach()
		{
		}

		public void NotifyOnDetach()
		{
		}

		public virtual void OnAttach()
		{
		}

		public virtual void OnDetach()
		{
		}

		public virtual void OnResized(VrDebugDisplay.State size)
		{
		}

		public DebugPanel()
			: base()
		{
		}
	}
}
