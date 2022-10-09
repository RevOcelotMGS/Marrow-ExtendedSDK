using System.ComponentModel;

namespace Oculus.Platform
{
	public enum LivestreamingStartStatus
	{
		[Description("SUCCESS")]
		Success = 1,
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("NO_PACKAGE_SET")]
		NoPackageSet = -1,
		[Description("NO_FB_CONNECT")]
		NoFbConnect = -2,
		[Description("NO_SESSION_ID")]
		NoSessionId = -3,
		[Description("MISSING_PARAMETERS")]
		MissingParameters = -4
	}
}
