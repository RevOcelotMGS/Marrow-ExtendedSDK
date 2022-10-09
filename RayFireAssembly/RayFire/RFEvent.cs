using System.Runtime.CompilerServices;

namespace RayFire
{
	public class RFEvent
	{
		public delegate void EventAction(RayfireRigid rigid);

		public delegate void EventActionRoot(RayfireRigidRoot root);

		public void InvokeLocalEvent(RayfireRigid rigid)
		{
		}

		public void InvokeLocalEventRoot(RayfireRigidRoot root)
		{
		}

		public RFEvent()
			: base()
		{
		}

		public event EventAction LocalEvent;

		public event EventActionRoot LocalEventRoot;
	}
}
