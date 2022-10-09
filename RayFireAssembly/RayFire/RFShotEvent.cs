using System.Runtime.CompilerServices;

namespace RayFire
{
	public class RFShotEvent
	{
		public delegate void EventAction(RayfireGun gun);

		public static void InvokeGlobalEvent(RayfireGun gun)
		{
		}

		public void InvokeLocalEvent(RayfireGun gun)
		{
		}

		public RFShotEvent()
			: base()
		{
		}

		public static event EventAction GlobalEvent;

		public event EventAction LocalEvent;
	}
}
