using System.ComponentModel;

namespace Oculus.Platform
{
	public enum AchievementType
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("SIMPLE")]
		Simple = 1,
		[Description("BITFIELD")]
		Bitfield = 2,
		[Description("COUNT")]
		Count = 3
	}
}
