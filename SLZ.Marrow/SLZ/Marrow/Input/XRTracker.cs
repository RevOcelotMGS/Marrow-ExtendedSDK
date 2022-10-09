using UnityEngine.InputSystem;

namespace SLZ.Marrow.Input
{
	public class XRTracker : XRDevice
	{
		public readonly string name;

		public XRTracker(string name)
			: base()
		{
		}

		public void ReadPoseContext(InputAction.CallbackContext context)
		{
		}

		public void ReadTrackingStateContext(InputAction.CallbackContext context)
		{
		}
	}
}
