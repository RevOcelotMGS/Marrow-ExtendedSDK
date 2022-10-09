using System.ComponentModel;

namespace Oculus.Platform
{
	public enum AbuseReportType
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("OBJECT")]
		Object = 1,
		[Description("USER")]
		User = 2
	}
}
