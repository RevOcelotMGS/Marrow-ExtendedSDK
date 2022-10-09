using System.ComponentModel;

namespace Oculus.Platform
{
	public enum LaunchType
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("NORMAL")]
		Normal = 1,
		[Description("INVITE")]
		Invite = 2,
		[Description("COORDINATED")]
		Coordinated = 3,
		[Description("DEEPLINK")]
		Deeplink = 4
	}
}
