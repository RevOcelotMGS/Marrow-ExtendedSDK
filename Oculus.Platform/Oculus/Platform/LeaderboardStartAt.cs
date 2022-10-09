using System.ComponentModel;

namespace Oculus.Platform
{
	public enum LeaderboardStartAt
	{
		[Description("TOP")]
		Top = 0,
		[Description("CENTERED_ON_VIEWER")]
		CenteredOnViewer = 1,
		[Description("CENTERED_ON_VIEWER_OR_TOP")]
		CenteredOnViewerOrTop = 2,
		[Description("UNKNOWN")]
		Unknown = 3
	}
}
