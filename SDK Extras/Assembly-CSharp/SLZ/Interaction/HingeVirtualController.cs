using UnityEngine;

namespace SLZ.Interaction
{
	public class HingeVirtualController : VirtualControllerOverride
	{
		public ConfigurableJoint joint;

		private Vector3 _inputMagCache;

		private Quaternion _initialRotation;

		private float _lastTwist;

		protected void Reset()
		{
		}

		protected void Start()
		{
		}

		public override void OnVirtualControllerStart(VirtualControlerPayload payload)
		{
		}

		public override void OnVirtualControllerSolve(VirtualControlerPayload payload)
		{
		}

		public HingeVirtualController()
			: base()
		{
		}
	}
}
