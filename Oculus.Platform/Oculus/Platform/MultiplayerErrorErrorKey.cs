using System.ComponentModel;

namespace Oculus.Platform
{
	public enum MultiplayerErrorErrorKey
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("DESTINATION_UNAVAILABLE")]
		DestinationUnavailable = 1,
		[Description("DLC_REQUIRED")]
		DlcRequired = 2,
		[Description("GENERAL")]
		General = 3,
		[Description("GROUP_FULL")]
		GroupFull = 4,
		[Description("INVITER_NOT_JOINABLE")]
		InviterNotJoinable = 5,
		[Description("LEVEL_NOT_HIGH_ENOUGH")]
		LevelNotHighEnough = 6,
		[Description("LEVEL_NOT_UNLOCKED")]
		LevelNotUnlocked = 7,
		[Description("NETWORK_TIMEOUT")]
		NetworkTimeout = 8,
		[Description("NO_LONGER_AVAILABLE")]
		NoLongerAvailable = 9,
		[Description("UPDATE_REQUIRED")]
		UpdateRequired = 10,
		[Description("TUTORIAL_REQUIRED")]
		TutorialRequired = 11
	}
}
