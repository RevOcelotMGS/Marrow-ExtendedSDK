using System.ComponentModel;

namespace Oculus.Platform
{
	public enum AbuseReportVideoMode
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("COLLECT")]
		Collect = 1,
		[Description("OPTIONAL")]
		Optional = 2,
		[Description("SKIP")]
		Skip = 3
	}
}
