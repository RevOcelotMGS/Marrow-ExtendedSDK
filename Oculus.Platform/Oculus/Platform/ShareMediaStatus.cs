using System.ComponentModel;

namespace Oculus.Platform
{
	public enum ShareMediaStatus
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("SHARED")]
		Shared = 1,
		[Description("CANCELED")]
		Canceled = 2
	}
}
