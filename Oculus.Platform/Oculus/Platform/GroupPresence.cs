using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class GroupPresence
	{
		public static Request Clear()
		{
			return null;
		}

		public static Request<UserList> GetInvitableUsers(InviteOptions options)
		{
			return null;
		}

		public static Request<ApplicationInviteList> GetSentInvites()
		{
			return null;
		}

		public static Request<InvitePanelResultInfo> LaunchInvitePanel(InviteOptions options)
		{
			return null;
		}

		public static Request LaunchMultiplayerErrorDialog(MultiplayerErrorOptions options)
		{
			return null;
		}

		public static Request<RejoinDialogResult> LaunchRejoinDialog(string lobby_session_id, string match_session_id, string destination_api_name)
		{
			return null;
		}

		public static Request LaunchRosterPanel(RosterOptions options)
		{
			return null;
		}

		public static Request<SendInvitesResult> SendInvites(ulong[] userIDs)
		{
			return null;
		}

		public static Request Set(GroupPresenceOptions groupPresenceOptions)
		{
			return null;
		}

		public static Request SetDestination(string api_name)
		{
			return null;
		}

		public static Request SetIsJoinable(bool is_joinable)
		{
			return null;
		}

		public static Request SetLobbySession(string id)
		{
			return null;
		}

		public static Request SetMatchSession(string id)
		{
			return null;
		}

		public static void SetInvitationsSentNotificationCallback(Message<LaunchInvitePanelFlowResult>.Callback callback)
		{
		}

		public static void SetJoinIntentReceivedNotificationCallback(Message<GroupPresenceJoinIntent>.Callback callback)
		{
		}

		public static void SetLeaveIntentReceivedNotificationCallback(Message<GroupPresenceLeaveIntent>.Callback callback)
		{
		}

		public static Request<ApplicationInviteList> GetNextApplicationInviteListPage(ApplicationInviteList list)
		{
			return null;
		}
	}
}
