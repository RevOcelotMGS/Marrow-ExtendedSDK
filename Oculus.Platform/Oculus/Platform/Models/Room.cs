using System;
using System.Collections.Generic;

namespace Oculus.Platform.Models
{
	public class Room
	{
		public readonly ulong ApplicationID;

		public readonly Dictionary<string, string> DataStore;

		public readonly string Description;

		public readonly ulong ID;

		public readonly UserList InvitedUsersOptional;

		[Obsolete("Deprecated in favor of InvitedUsersOptional")]
		public readonly UserList InvitedUsers;

		public readonly bool IsMembershipLocked;

		public readonly RoomJoinPolicy JoinPolicy;

		public readonly RoomJoinability Joinability;

		public readonly MatchmakingEnqueuedUserList MatchedUsersOptional;

		[Obsolete("Deprecated in favor of MatchedUsersOptional")]
		public readonly MatchmakingEnqueuedUserList MatchedUsers;

		public readonly uint MaxUsers;

		public readonly string Name;

		public readonly User OwnerOptional;

		[Obsolete("Deprecated in favor of OwnerOptional")]
		public readonly User Owner;

		public readonly TeamList TeamsOptional;

		[Obsolete("Deprecated in favor of TeamsOptional")]
		public readonly TeamList Teams;

		public readonly RoomType Type;

		public readonly UserList UsersOptional;

		[Obsolete("Deprecated in favor of UsersOptional")]
		public readonly UserList Users;

		public readonly uint Version;

		public Room(IntPtr o)
			: base()
		{
		}
	}
}
