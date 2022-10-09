using System.ComponentModel;

namespace Oculus.Platform
{
	public enum VoipMuteState
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("MUTED")]
		Muted = 1,
		[Description("UNMUTED")]
		Unmuted = 2
	}
}
