using System.ComponentModel;

namespace Oculus.Platform
{
	public enum RoomJoinability
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("ARE_IN")]
		AreIn = 1,
		[Description("ARE_KICKED")]
		AreKicked = 2,
		[Description("CAN_JOIN")]
		CanJoin = 3,
		[Description("IS_FULL")]
		IsFull = 4,
		[Description("NO_VIEWER")]
		NoViewer = 5,
		[Description("POLICY_PREVENTS")]
		PolicyPrevents = 6
	}
}
