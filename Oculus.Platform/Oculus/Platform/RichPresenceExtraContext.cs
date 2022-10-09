using System.ComponentModel;

namespace Oculus.Platform
{
	public enum RichPresenceExtraContext
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("NONE")]
		None = 1,
		[Description("CURRENT_CAPACITY")]
		CurrentCapacity = 2,
		[Description("STARTED_AGO")]
		StartedAgo = 3,
		[Description("ENDING_IN")]
		EndingIn = 4,
		[Description("LOOKING_FOR_A_MATCH")]
		LookingForAMatch = 5
	}
}
