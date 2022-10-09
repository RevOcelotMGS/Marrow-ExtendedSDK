using System.Runtime.CompilerServices;

namespace RayFire
{
	public class RFExplosionEvent
	{
		public delegate void EventAction(RayfireBomb bomb);

		public static void InvokeGlobalEvent(RayfireBomb bomb)
		{
		}

		public void InvokeLocalEvent(RayfireBomb bomb)
		{
		}

		public RFExplosionEvent()
			: base()
		{
		}

		public static event EventAction GlobalEvent;

		public event EventAction LocalEvent;
	}
}
