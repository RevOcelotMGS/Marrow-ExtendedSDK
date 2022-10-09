using System.Runtime.CompilerServices;

namespace RayFire
{
	public class RFConnectivityEvent
	{
		public delegate void EventAction(RayfireConnectivity connectivity);

		public static void InvokeGlobalEvent(RayfireConnectivity connectivity)
		{
		}

		public void InvokeLocalEvent(RayfireConnectivity connectivity)
		{
		}

		public RFConnectivityEvent()
			: base()
		{
		}

		public static event EventAction GlobalEvent;

		public event EventAction LocalEvent;
	}
}
