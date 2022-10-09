using System.ComponentModel;

namespace Oculus.Platform
{
	public enum PeerConnectionState
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("CONNECTED")]
		Connected = 1,
		[Description("TIMEOUT")]
		Timeout = 2,
		[Description("CLOSED")]
		Closed = 3
	}
}
