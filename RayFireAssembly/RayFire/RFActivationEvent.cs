using System.Runtime.CompilerServices;

namespace RayFire
{
	public class RFActivationEvent : RFEvent
	{
		public static void InvokeGlobalEvent(RayfireRigid rigid)
		{
		}

		public static void InvokeGlobalEventRoot(RayfireRigidRoot root)
		{
		}

		public RFActivationEvent()
			: base()
		{
		}

		public static event EventAction GlobalEvent;

		public static event EventActionRoot GlobalEventRoot;
	}
}
