using Assets.Marrow_ExtendedSDK.StubClasses;

namespace SLZ.Marrow.Input
{
	public class XRTracker : XRDevice
	{
		public readonly string name;

		public XRTracker(string name)
			: base()
		{
		}

		public void ReadPoseContext(CallbackContext context)
		{
		}

		public void ReadTrackingStateContext(CallbackContext context)
		{
		}
	}
}
