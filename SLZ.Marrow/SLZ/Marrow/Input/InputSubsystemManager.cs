using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	public class InputSubsystemManager : SubsystemManager<XRInputSubsystem, XRInputSubsystemDescriptor>
	{
		public void TryRecenter()
		{
		}

		public bool HasFocus()
		{
			return default(bool);
		}

		public InputSubsystemManager()
			: base()
		{
		}
	}
}
