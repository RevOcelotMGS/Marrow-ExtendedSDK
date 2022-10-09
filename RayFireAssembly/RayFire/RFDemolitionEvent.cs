using System.Runtime.CompilerServices;

namespace RayFire
{
	public class RFDemolitionEvent : RFEvent
	{
		public static void InvokeGlobalEvent(RayfireRigid rigid)
		{
		}

		public RFDemolitionEvent()
			: base()
		{
		}

		public static event EventAction GlobalEvent;
	}
}
