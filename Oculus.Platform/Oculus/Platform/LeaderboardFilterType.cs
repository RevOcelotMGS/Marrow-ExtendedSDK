using System.ComponentModel;

namespace Oculus.Platform
{
	public enum LeaderboardFilterType
	{
		[Description("NONE")]
		None = 0,
		[Description("FRIENDS")]
		Friends = 1,
		[Description("UNKNOWN")]
		Unknown = 2,
		[Description("USER_IDS")]
		UserIds = 3
	}
}
