using UnityEngine.EventSystems;

namespace Technie.VirtualConsole
{
	public class IsolatedEventSystem : EventSystem
	{
		protected override void OnEnable()
		{
		}

		protected override void Update()
		{
		}

		public IsolatedEventSystem()
			: base()
		{
		}
	}
}
