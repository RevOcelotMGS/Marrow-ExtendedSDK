using System.Runtime.CompilerServices;

namespace RayFire
{
	public class RFRestrictionEvent : RFEvent
	{
		public static void InvokeGlobalEvent(RayfireRigid rigid)
		{
		}

		public RFRestrictionEvent()
			: base()
		{
		}

		public static event EventAction GlobalEvent;
	}
}
