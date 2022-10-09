using System.ComponentModel;

namespace Oculus.Platform
{
	public enum SystemVoipStatus
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("UNAVAILABLE")]
		Unavailable = 1,
		[Description("SUPPRESSED")]
		Suppressed = 2,
		[Description("ACTIVE")]
		Active = 3
	}
}
