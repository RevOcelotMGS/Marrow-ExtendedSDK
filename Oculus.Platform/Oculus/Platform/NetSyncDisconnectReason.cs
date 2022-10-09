using System.ComponentModel;

namespace Oculus.Platform
{
	public enum NetSyncDisconnectReason
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("LOCAL_TERMINATED")]
		LocalTerminated = 1,
		[Description("SERVER_TERMINATED")]
		ServerTerminated = 2,
		[Description("FAILED")]
		Failed = 3,
		[Description("LOST")]
		Lost = 4
	}
}
