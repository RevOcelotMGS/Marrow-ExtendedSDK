using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Rooms
	{
		public static Request<Room> UpdateDataStore(ulong roomID, Dictionary<string, string> data)
		{
			return null;
		}

		[Obsolete("Deprecated in favor of SetRoomInviteAcceptedNotificationCallback")]
		public static void SetRoomInviteNotificationCallback(Message<string>.Callback callback)
		{
		}

		public static Request<Room> CreateAndJoinPrivate(RoomJoinPolicy joinPolicy, uint maxUsers, bool subscribeToUpdates = false)
		{
			return null;
		}

		public static Request<Room> CreateAndJoinPrivate2(RoomJoinPolicy joinPolicy, uint maxUsers, RoomOptions roomOptions)
		{
			return null;
		}

		public static Request<Room> Get(ulong roomID)
		{
			return null;
		}

		public static Request<Room> GetCurrent()
		{
			return null;
		}

		public static Request<Room> GetCurrentForUser(ulong userID)
		{
			return null;
		}

		public static Request<UserList> GetInvitableUsers()
		{
			return null;
		}

		public static Request<UserList> GetInvitableUsers2(RoomOptions roomOptions = default(RoomOptions))
		{
			return null;
		}

		public static Request<RoomList> GetModeratedRooms()
		{
			return null;
		}

		public static Request<Room> InviteUser(ulong roomID, string inviteToken)
		{
			return null;
		}

		public static Request<Room> Join(ulong roomID, bool subscribeToUpdates = false)
		{
			return null;
		}

		public static Request<Room> Join2(ulong roomID, RoomOptions roomOptions)
		{
			return null;
		}

		public static Request<Room> KickUser(ulong roomID, ulong userID, int kickDurationSeconds)
		{
			return null;
		}

		public static Request LaunchInvitableUserFlow(ulong roomID)
		{
			return null;
		}

		public static Request<Room> Leave(ulong roomID)
		{
			return null;
		}

		public static Request<Room> SetDescription(ulong roomID, string description)
		{
			return null;
		}

		public static Request<Room> UpdateMembershipLockStatus(ulong roomID, RoomMembershipLockStatus membershipLockStatus)
		{
			return null;
		}

		public static Request UpdateOwner(ulong roomID, ulong userID)
		{
			return null;
		}

		public static Request<Room> UpdatePrivateRoomJoinPolicy(ulong roomID, RoomJoinPolicy newJoinPolicy)
		{
			return null;
		}

		public static void SetRoomInviteAcceptedNotificationCallback(Message<string>.Callback callback)
		{
		}

		public static void SetRoomInviteReceivedNotificationCallback(Message<RoomInviteNotification>.Callback callback)
		{
		}

		public static void SetUpdateNotificationCallback(Message<Room>.Callback callback)
		{
		}

		public static Request<RoomList> GetNextRoomListPage(RoomList list)
		{
			return null;
		}
	}
}
