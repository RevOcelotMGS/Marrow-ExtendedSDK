using System.ComponentModel;

namespace Oculus.Platform
{
	public enum ChallengeViewerFilter
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("ALL_VISIBLE")]
		AllVisible = 1,
		[Description("PARTICIPATING")]
		Participating = 2,
		[Description("INVITED")]
		Invited = 3,
		[Description("PARTICIPATING_OR_INVITED")]
		ParticipatingOrInvited = 4
	}
}
