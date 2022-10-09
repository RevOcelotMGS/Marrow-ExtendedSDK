using System.ComponentModel;

namespace Oculus.Platform
{
	public enum MatchmakingCriterionImportance
	{
		[Description("REQUIRED")]
		Required = 0,
		[Description("HIGH")]
		High = 1,
		[Description("MEDIUM")]
		Medium = 2,
		[Description("LOW")]
		Low = 3,
		[Description("UNKNOWN")]
		Unknown = 4
	}
}
