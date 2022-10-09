using System.ComponentModel;

namespace Oculus.Platform
{
	public enum MatchmakingStatApproach
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("TRAILING")]
		Trailing = 1,
		[Description("SWINGY")]
		Swingy = 2
	}
}
