using System.ComponentModel;

namespace Oculus.Platform
{
	public enum NetSyncConnectionStatus
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("CONNECTING")]
		Connecting = 1,
		[Description("DISCONNECTED")]
		Disconnected = 2,
		[Description("CONNECTED")]
		Connected = 3
	}
}
