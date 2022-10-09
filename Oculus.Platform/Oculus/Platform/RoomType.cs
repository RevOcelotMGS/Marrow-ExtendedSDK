using System.ComponentModel;

namespace Oculus.Platform
{
	public enum RoomType
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("MATCHMAKING")]
		Matchmaking = 1,
		[Description("MODERATED")]
		Moderated = 2,
		[Description("PRIVATE")]
		Private = 3,
		[Description("SOLO")]
		Solo = 4
	}
}
