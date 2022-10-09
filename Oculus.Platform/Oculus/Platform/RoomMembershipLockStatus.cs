using System.ComponentModel;

namespace Oculus.Platform
{
	public enum RoomMembershipLockStatus
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("LOCK")]
		Lock = 1,
		[Description("UNLOCK")]
		Unlock = 2
	}
}
