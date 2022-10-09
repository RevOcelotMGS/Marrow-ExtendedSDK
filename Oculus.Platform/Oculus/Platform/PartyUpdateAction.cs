using System.ComponentModel;

namespace Oculus.Platform
{
	public enum PartyUpdateAction
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("Join")]
		Join = 1,
		[Description("Leave")]
		Leave = 2,
		[Description("Invite")]
		Invite = 3,
		[Description("Uninvite")]
		Uninvite = 4
	}
}
