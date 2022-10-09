using System.ComponentModel;

namespace Oculus.Platform
{
	public enum UserPresenceStatus
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("ONLINE")]
		Online = 1,
		[Description("OFFLINE")]
		Offline = 2
	}
}
