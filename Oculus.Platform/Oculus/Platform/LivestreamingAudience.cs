using System.ComponentModel;

namespace Oculus.Platform
{
	public enum LivestreamingAudience
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("PUBLIC")]
		Public = 1,
		[Description("FRIENDS")]
		Friends = 2,
		[Description("ONLY_ME")]
		OnlyMe = 3
	}
}
