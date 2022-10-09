using System.ComponentModel;

namespace Oculus.Platform
{
	public enum SendPolicy
	{
		[Description("UNRELIABLE")]
		Unreliable = 0,
		[Description("RELIABLE")]
		Reliable = 1,
		[Description("UNKNOWN")]
		Unknown = 2
	}
}
