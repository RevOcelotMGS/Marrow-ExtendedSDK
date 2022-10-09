using System.ComponentModel;

namespace Oculus.Platform
{
	public enum RoomJoinPolicy
	{
		[Description("NONE")]
		None = 0,
		[Description("EVERYONE")]
		Everyone = 1,
		[Description("FRIENDS_OF_MEMBERS")]
		FriendsOfMembers = 2,
		[Description("FRIENDS_OF_OWNER")]
		FriendsOfOwner = 3,
		[Description("INVITED_USERS")]
		InvitedUsers = 4,
		[Description("UNKNOWN")]
		Unknown = 5
	}
}
