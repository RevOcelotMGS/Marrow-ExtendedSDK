using System.ComponentModel;

namespace Oculus.Platform
{
	public enum ChallengeVisibility
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("INVITE_ONLY")]
		InviteOnly = 1,
		[Description("PUBLIC")]
		Public = 2,
		[Description("PRIVATE")]
		Private = 3
	}
}
