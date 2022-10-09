using System.ComponentModel;

namespace Oculus.Platform
{
	public enum ChallengeCreationType
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("USER_CREATED")]
		UserCreated = 1,
		[Description("DEVELOPER_CREATED")]
		DeveloperCreated = 2
	}
}
