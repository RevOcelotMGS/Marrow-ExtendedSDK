using System.Runtime.InteropServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Users
	{
		public static string GetLoggedInUserLocale()
		{
			return null;
		}

		public static Request<User> Get(ulong userID)
		{
			return null;
		}

		public static Request<string> GetAccessToken()
		{
			return null;
		}

		public static Request<User> GetLoggedInUser()
		{
			return null;
		}

		public static Request<UserList> GetLoggedInUserFriends()
		{
			return null;
		}

		public static Request<UserAndRoomList> GetLoggedInUserFriendsAndRooms()
		{
			return null;
		}

		public static Request<UserAndRoomList> GetLoggedInUserRecentlyMetUsersAndRooms(UserOptions userOptions = default(UserOptions))
		{
			return null;
		}

		public static Request<OrgScopedID> GetOrgScopedID(ulong userID)
		{
			return null;
		}

		public static Request<SdkAccountList> GetSdkAccounts()
		{
			return null;
		}

		public static Request<UserProof> GetUserProof()
		{
			return null;
		}

		public static Request<LaunchFriendRequestFlowResult> LaunchFriendRequestFlow(ulong userID)
		{
			return null;
		}

		public static Request<UserAndRoomList> GetNextUserAndRoomListPage(UserAndRoomList list)
		{
			return null;
		}

		public static Request<UserList> GetNextUserListPage(UserList list)
		{
			return null;
		}
	}
}
