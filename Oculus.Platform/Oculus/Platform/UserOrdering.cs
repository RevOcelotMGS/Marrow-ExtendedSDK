using System.ComponentModel;

namespace Oculus.Platform
{
	public enum UserOrdering
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("NONE")]
		None = 1,
		[Description("PRESENCE_ALPHABETICAL")]
		PresenceAlphabetical = 2
	}
}
