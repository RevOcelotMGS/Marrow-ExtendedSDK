using System.ComponentModel;

namespace Oculus.Platform
{
	public enum LaunchResult
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("SUCCESS")]
		Success = 1,
		[Description("FAILED_ROOM_FULL")]
		FailedRoomFull = 2,
		[Description("FAILED_GAME_ALREADY_STARTED")]
		FailedGameAlreadyStarted = 3,
		[Description("FAILED_ROOM_NOT_FOUND")]
		FailedRoomNotFound = 4,
		[Description("FAILED_USER_DECLINED")]
		FailedUserDeclined = 5,
		[Description("FAILED_OTHER_REASON")]
		FailedOtherReason = 6
	}
}
