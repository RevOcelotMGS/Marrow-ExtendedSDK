using UnityEngine;

namespace SLZ.Interaction
{
	public class StaticSlideVirtualController : VirtualControllerOverride
	{
		public ConfigurableJoint joint;

		private Vector3 _inputMagCache;

		protected void Reset()
		{
		}

		public override void OnVirtualControllerStart(VirtualControlerPayload payload)
		{
		}

		public override void OnVirtualControllerSolve(VirtualControlerPayload payload)
		{
		}

		public StaticSlideVirtualController()
			: base()
		{
		}
	}
}
