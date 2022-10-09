using System.Runtime.CompilerServices;

namespace RayFire
{
	public class RFSliceEvent
	{
		public delegate void EventAction(RayfireBlade blade);

		public static void InvokeGlobalEvent(RayfireBlade blade)
		{
		}

		public void InvokeLocalEvent(RayfireBlade blade)
		{
		}

		public RFSliceEvent()
			: base()
		{
		}

		public static event EventAction GlobalEvent;

		public event EventAction LocalEvent;
	}
}
