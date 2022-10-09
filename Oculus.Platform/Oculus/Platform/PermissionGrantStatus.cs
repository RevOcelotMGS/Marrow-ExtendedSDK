using System.ComponentModel;

namespace Oculus.Platform
{
	public enum PermissionGrantStatus
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("GRANTED")]
		Granted = 1,
		[Description("DENIED")]
		Denied = 2,
		[Description("BLOCKED")]
		Blocked = 3
	}
}
