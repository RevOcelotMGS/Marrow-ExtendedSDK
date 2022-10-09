using System.ComponentModel;

namespace Oculus.Platform
{
	public enum TimeWindow
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("ONE_HOUR")]
		OneHour = 1,
		[Description("ONE_DAY")]
		OneDay = 2,
		[Description("ONE_WEEK")]
		OneWeek = 3,
		[Description("THIRTY_DAYS")]
		ThirtyDays = 4,
		[Description("NINETY_DAYS")]
		NinetyDays = 5
	}
}
