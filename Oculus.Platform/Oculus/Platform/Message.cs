using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public abstract class Message<T> : Message
	{
		public new delegate void Callback(Message<T> message);

		private T data;

		public T Data
		{
			get
			{
				return (T)default(T);
			}
		}

		public Message(IntPtr c_message)
			: base(c_message)
		{
		}

		protected abstract T GetDataFromMessage(IntPtr c_message);
	}
	public class Message
	{
		public delegate void Callback(Message message);

		public enum MessageType : uint
		{
			Unknown = 0u,
			Achievements_AddCount = 65495601u,
			Achievements_AddFields = 346693929u,
			Achievements_GetAllDefinitions = 64177549u,
			Achievements_GetAllProgress = 1335877149u,
			Achievements_GetDefinitionsByName = 1653670332u,
			Achievements_GetNextAchievementDefinitionArrayPage = 712888917u,
			Achievements_GetNextAchievementProgressArrayPage = 792913703u,
			Achievements_GetProgressByName = 354837425u,
			Achievements_Unlock = 1497156573u,
			ApplicationLifecycle_GetRegisteredPIDs = 82169698u,
			ApplicationLifecycle_GetSessionKey = 984570141u,
			ApplicationLifecycle_RegisterSessionKey = 1303818232u,
			Application_GetVersion = 1751583246u,
			Application_LaunchOtherApp = 1424151032u,
			AssetFile_Delete = 1834842246u,
			AssetFile_DeleteById = 1525206354u,
			AssetFile_DeleteByName = 1108001231u,
			AssetFile_Download = 289710021u,
			AssetFile_DownloadById = 755009938u,
			AssetFile_DownloadByName = 1664536314u,
			AssetFile_DownloadCancel = 134927303u,
			AssetFile_DownloadCancelById = 1365611796u,
			AssetFile_DownloadCancelByName = 1147858170u,
			AssetFile_GetList = 1258057588u,
			AssetFile_Status = 47394656u,
			AssetFile_StatusById = 1570069816u,
			AssetFile_StatusByName = 1104140880u,
			Challenges_Create = 1750718017u,
			Challenges_DeclineInvite = 1452177088u,
			Challenges_Delete = 642287050u,
			Challenges_Get = 2002276083u,
			Challenges_GetEntries = 303739999u,
			Challenges_GetEntriesAfterRank = 143202943u,
			Challenges_GetEntriesByIds = 828705244u,
			Challenges_GetList = 1126581078u,
			Challenges_GetNextChallenges = 1534894518u,
			Challenges_GetNextEntries = 2135728326u,
			Challenges_GetPreviousChallenges = 246678541u,
			Challenges_GetPreviousEntries = 2026439792u,
			Challenges_Join = 556040297u,
			Challenges_Leave = 694228709u,
			Challenges_UpdateInfo = 292929120u,
			CloudStorage2_GetUserDirectoryPath = 1990471406u,
			CloudStorage_Delete = 685393261u,
			CloudStorage_GetNextCloudStorageMetadataArrayPage = 1544004335u,
			CloudStorage_Load = 1082420033u,
			CloudStorage_LoadBucketMetadata = 1931977997u,
			CloudStorage_LoadConflictMetadata = 1146770162u,
			CloudStorage_LoadHandle = 845863478u,
			CloudStorage_LoadMetadata = 65446546u,
			CloudStorage_ResolveKeepLocal = 811109637u,
			CloudStorage_ResolveKeepRemote = 1965400838u,
			CloudStorage_Save = 1270570030u,
			Entitlement_GetIsViewerEntitled = 409688241u,
			GroupPresence_Clear = 1839897795u,
			GroupPresence_GetInvitableUsers = 592167921u,
			GroupPresence_GetNextApplicationInviteArrayPage = 83411186u,
			GroupPresence_GetSentInvites = 136710833u,
			GroupPresence_LaunchInvitePanel = 262066079u,
			GroupPresence_LaunchMultiplayerErrorDialog = 693481252u,
			GroupPresence_LaunchRejoinDialog = 360121199u,
			GroupPresence_LaunchRosterPanel = 896698498u,
			GroupPresence_SendInvites = 231461732u,
			GroupPresence_Set = 1734302756u,
			GroupPresence_SetDestination = 1281042058u,
			GroupPresence_SetIsJoinable = 714018901u,
			GroupPresence_SetLobbySession = 1224693182u,
			GroupPresence_SetMatchSession = 827098296u,
			IAP_ConsumePurchase = 532378329u,
			IAP_GetNextProductArrayPage = 467225263u,
			IAP_GetNextPurchaseArrayPage = 1196886677u,
			IAP_GetProductsBySKU = 2124073717u,
			IAP_GetViewerPurchases = 974095385u,
			IAP_GetViewerPurchasesDurableCache = 1666817579u,
			IAP_LaunchCheckoutFlow = 1067126029u,
			LanguagePack_GetCurrent = 529592533u,
			LanguagePack_SetCurrent = 1531952096u,
			Leaderboard_Get = 1792298744u,
			Leaderboard_GetEntries = 1572030284u,
			Leaderboard_GetEntriesAfterRank = 406293487u,
			Leaderboard_GetEntriesByIds = 962624508u,
			Leaderboard_GetNextEntries = 1310751961u,
			Leaderboard_GetNextLeaderboardArrayPage = 905344667u,
			Leaderboard_GetPreviousEntries = 1224858304u,
			Leaderboard_WriteEntry = 293587198u,
			Leaderboard_WriteEntryWithSupplementaryMetric = 1925616378u,
			Matchmaking_Browse = 509948616u,
			Matchmaking_Browse2 = 1715641947u,
			Matchmaking_Cancel = 543705519u,
			Matchmaking_Cancel2 = 285117908u,
			Matchmaking_CreateAndEnqueueRoom = 1615617480u,
			Matchmaking_CreateAndEnqueueRoom2 = 693889755u,
			Matchmaking_CreateRoom = 54203178u,
			Matchmaking_CreateRoom2 = 1231922052u,
			Matchmaking_Enqueue = 1086418033u,
			Matchmaking_Enqueue2 = 303174325u,
			Matchmaking_EnqueueRoom = 1888108644u,
			Matchmaking_EnqueueRoom2 = 1428741028u,
			Matchmaking_GetAdminSnapshot = 1008820116u,
			Matchmaking_GetStats = 1123849272u,
			Matchmaking_JoinRoom = 1295177725u,
			Matchmaking_ReportResultInsecure = 439800205u,
			Matchmaking_StartMatch = 1154746693u,
			Media_ShareToFacebook = 14912239u,
			Notification_GetNextRoomInviteNotificationArrayPage = 102890359u,
			Notification_GetRoomInvites = 1871801234u,
			Notification_MarkAsRead = 1903319523u,
			Party_GetCurrent = 1200830304u,
			RichPresence_Clear = 1471632051u,
			RichPresence_GetDestinations = 1483681044u,
			RichPresence_GetNextDestinationArrayPage = 1731624773u,
			RichPresence_Set = 1007973641u,
			Room_CreateAndJoinPrivate = 1977017207u,
			Room_CreateAndJoinPrivate2 = 1513775683u,
			Room_Get = 1704628152u,
			Room_GetCurrent = 161916164u,
			Room_GetCurrentForUser = 234887141u,
			Room_GetInvitableUsers = 506615698u,
			Room_GetInvitableUsers2 = 1330899120u,
			Room_GetModeratedRooms = 159645047u,
			Room_GetNextRoomArrayPage = 1317239238u,
			Room_InviteUser = 1093266451u,
			Room_Join = 382373641u,
			Room_Join2 = 1303059522u,
			Room_KickUser = 1233344310u,
			Room_LaunchInvitableUserFlow = 843047539u,
			Room_Leave = 1916281973u,
			Room_SetDescription = 809796911u,
			Room_UpdateDataStore = 40779816u,
			Room_UpdateMembershipLockStatus = 923514796u,
			Room_UpdateOwner = 850803997u,
			Room_UpdatePrivateRoomJoinPolicy = 289473179u,
			UserDataStore_PrivateDeleteEntryByKey = 1552510782u,
			UserDataStore_PrivateGetEntries = 1821016616u,
			UserDataStore_PrivateGetEntryByKey = 470188825u,
			UserDataStore_PrivateWriteEntry = 1104315019u,
			UserDataStore_PublicDeleteEntryByKey = 500557307u,
			UserDataStore_PublicGetEntries = 377310146u,
			UserDataStore_PublicGetEntryByKey = 425486022u,
			UserDataStore_PublicWriteEntry = 875973130u,
			User_Get = 1808768583u,
			User_GetAccessToken = 111696574u,
			User_GetLoggedInUser = 1131361373u,
			User_GetLoggedInUserFriends = 1484532365u,
			User_GetLoggedInUserFriendsAndRooms = 1585908615u,
			User_GetLoggedInUserRecentlyMetUsersAndRooms = 694139440u,
			User_GetNextUserAndRoomArrayPage = 2143146719u,
			User_GetNextUserArrayPage = 645723971u,
			User_GetOrgScopedID = 418426907u,
			User_GetSdkAccounts = 1733454467u,
			User_GetUserProof = 578880643u,
			User_LaunchFriendRequestFlow = 151303576u,
			Voip_GetMicrophoneAvailability = 1951195973u,
			Voip_SetSystemVoipSuppressed = 1161808298u,
			Notification_ApplicationLifecycle_LaunchIntentChanged = 78859427u,
			Notification_AssetFile_DownloadUpdate = 803015885u,
			Notification_Cal_FinalizeApplication = 1963741337u,
			Notification_Cal_ProposeApplication = 779375093u,
			Notification_GroupPresence_InvitationsSent = 1738179766u,
			Notification_GroupPresence_JoinIntentReceived = 2000194038u,
			Notification_GroupPresence_LeaveIntentReceived = 1194846749u,
			Notification_HTTP_Transfer = 2111073839u,
			Notification_Livestreaming_StatusChange = 575101294u,
			Notification_Matchmaking_MatchFound = 197393623u,
			Notification_NetSync_ConnectionStatusChanged = 120882378u,
			Notification_NetSync_SessionsChanged = 947814198u,
			Notification_Networking_ConnectionStateChange = 1577243802u,
			Notification_Networking_PeerConnectRequest = 1295114959u,
			Notification_Networking_PingResult = 1360343058u,
			Notification_Party_PartyUpdate = 487688882u,
			Notification_Room_InviteAccepted = 1829794225u,
			Notification_Room_InviteReceived = 1783209300u,
			Notification_Room_RoomUpdate = 1626094639u,
			Notification_Session_InvitationsSent = 133810304u,
			Notification_Voip_ConnectRequest = 908343318u,
			Notification_Voip_MicrophoneAvailabilityStateUpdate = 1042336599u,
			Notification_Voip_StateChange = 888120928u,
			Notification_Voip_SystemVoipState = 1490179237u,
			Notification_Vrcamera_GetDataChannelMessageUpdate = 1860498236u,
			Notification_Vrcamera_GetSurfaceUpdate = 938610820u,
			Platform_InitializeWithAccessToken = 896085803u,
			Platform_InitializeStandaloneOculus = 1375260172u,
			Platform_InitializeAndroidAsynchronous = 450037684u,
			Platform_InitializeWindowsAsynchronous = 1839708815u
		}

		internal delegate Message ExtraMessageTypesHandler(IntPtr messageHandle, MessageType message_type);

		private MessageType type;

		private ulong requestID;

		private Error error;

		public MessageType Type
		{
			get
			{
				return default(MessageType);
			}
		}

		public bool IsError
		{
			get
			{
				return default(bool);
			}
		}

		public ulong RequestID
		{
			get
			{
				return default(ulong);
			}
		}

		internal static ExtraMessageTypesHandler HandleExtraMessageTypes { private get; set; }

		public Message(IntPtr c_message)
			: base()
		{
		}

		~Message()
		{
		}

		public virtual Error GetError()
		{
			return null;
		}

		public virtual PingResult GetPingResult()
		{
			return null;
		}

		public virtual NetworkingPeer GetNetworkingPeer()
		{
			return null;
		}

		public virtual HttpTransferUpdate GetHttpTransferUpdate()
		{
			return null;
		}

		public virtual PlatformInitialize GetPlatformInitialize()
		{
			return null;
		}

		public virtual AbuseReportRecording GetAbuseReportRecording()
		{
			return null;
		}

		public virtual AchievementDefinitionList GetAchievementDefinitions()
		{
			return null;
		}

		public virtual AchievementProgressList GetAchievementProgressList()
		{
			return null;
		}

		public virtual AchievementUpdate GetAchievementUpdate()
		{
			return null;
		}

		public virtual ApplicationInviteList GetApplicationInviteList()
		{
			return null;
		}

		public virtual ApplicationVersion GetApplicationVersion()
		{
			return null;
		}

		public virtual AssetDetails GetAssetDetails()
		{
			return null;
		}

		public virtual AssetDetailsList GetAssetDetailsList()
		{
			return null;
		}

		public virtual AssetFileDeleteResult GetAssetFileDeleteResult()
		{
			return null;
		}

		public virtual AssetFileDownloadCancelResult GetAssetFileDownloadCancelResult()
		{
			return null;
		}

		public virtual AssetFileDownloadResult GetAssetFileDownloadResult()
		{
			return null;
		}

		public virtual AssetFileDownloadUpdate GetAssetFileDownloadUpdate()
		{
			return null;
		}

		public virtual CalApplicationFinalized GetCalApplicationFinalized()
		{
			return null;
		}

		public virtual CalApplicationProposed GetCalApplicationProposed()
		{
			return null;
		}

		public virtual CalApplicationSuggestionList GetCalApplicationSuggestionList()
		{
			return null;
		}

		public virtual Challenge GetChallenge()
		{
			return null;
		}

		public virtual ChallengeEntryList GetChallengeEntryList()
		{
			return null;
		}

		public virtual ChallengeList GetChallengeList()
		{
			return null;
		}

		public virtual CloudStorageConflictMetadata GetCloudStorageConflictMetadata()
		{
			return null;
		}

		public virtual CloudStorageData GetCloudStorageData()
		{
			return null;
		}

		public virtual CloudStorageMetadata GetCloudStorageMetadata()
		{
			return null;
		}

		public virtual CloudStorageMetadataList GetCloudStorageMetadataList()
		{
			return null;
		}

		public virtual CloudStorageUpdateResponse GetCloudStorageUpdateResponse()
		{
			return null;
		}

		public virtual Dictionary<string, string> GetDataStore()
		{
			return null;
		}

		public virtual DestinationList GetDestinationList()
		{
			return null;
		}

		public virtual GroupPresenceJoinIntent GetGroupPresenceJoinIntent()
		{
			return null;
		}

		public virtual GroupPresenceLeaveIntent GetGroupPresenceLeaveIntent()
		{
			return null;
		}

		public virtual InstalledApplicationList GetInstalledApplicationList()
		{
			return null;
		}

		public virtual InvitePanelResultInfo GetInvitePanelResultInfo()
		{
			return null;
		}

		public virtual LaunchBlockFlowResult GetLaunchBlockFlowResult()
		{
			return null;
		}

		public virtual LaunchFriendRequestFlowResult GetLaunchFriendRequestFlowResult()
		{
			return null;
		}

		public virtual LaunchInvitePanelFlowResult GetLaunchInvitePanelFlowResult()
		{
			return null;
		}

		public virtual LaunchReportFlowResult GetLaunchReportFlowResult()
		{
			return null;
		}

		public virtual LaunchUnblockFlowResult GetLaunchUnblockFlowResult()
		{
			return null;
		}

		public virtual bool GetLeaderboardDidUpdate()
		{
			return default(bool);
		}

		public virtual LeaderboardEntryList GetLeaderboardEntryList()
		{
			return null;
		}

		public virtual LeaderboardList GetLeaderboardList()
		{
			return null;
		}

		public virtual LinkedAccountList GetLinkedAccountList()
		{
			return null;
		}

		public virtual LivestreamingApplicationStatus GetLivestreamingApplicationStatus()
		{
			return null;
		}

		public virtual LivestreamingStartResult GetLivestreamingStartResult()
		{
			return null;
		}

		public virtual LivestreamingStatus GetLivestreamingStatus()
		{
			return null;
		}

		public virtual LivestreamingVideoStats GetLivestreamingVideoStats()
		{
			return null;
		}

		public virtual MatchmakingAdminSnapshot GetMatchmakingAdminSnapshot()
		{
			return null;
		}

		public virtual MatchmakingBrowseResult GetMatchmakingBrowseResult()
		{
			return null;
		}

		public virtual MatchmakingEnqueueResult GetMatchmakingEnqueueResult()
		{
			return null;
		}

		public virtual MatchmakingEnqueueResultAndRoom GetMatchmakingEnqueueResultAndRoom()
		{
			return null;
		}

		public virtual MatchmakingStats GetMatchmakingStats()
		{
			return null;
		}

		public virtual MicrophoneAvailabilityState GetMicrophoneAvailabilityState()
		{
			return null;
		}

		public virtual NetSyncConnection GetNetSyncConnection()
		{
			return null;
		}

		public virtual NetSyncSessionList GetNetSyncSessionList()
		{
			return null;
		}

		public virtual NetSyncSessionsChangedNotification GetNetSyncSessionsChangedNotification()
		{
			return null;
		}

		public virtual NetSyncSetSessionPropertyResult GetNetSyncSetSessionPropertyResult()
		{
			return null;
		}

		public virtual NetSyncVoipAttenuationValueList GetNetSyncVoipAttenuationValueList()
		{
			return null;
		}

		public virtual OrgScopedID GetOrgScopedID()
		{
			return null;
		}

		public virtual Party GetParty()
		{
			return null;
		}

		public virtual PartyID GetPartyID()
		{
			return null;
		}

		public virtual PartyUpdateNotification GetPartyUpdateNotification()
		{
			return null;
		}

		public virtual PidList GetPidList()
		{
			return null;
		}

		public virtual ProductList GetProductList()
		{
			return null;
		}

		public virtual Purchase GetPurchase()
		{
			return null;
		}

		public virtual PurchaseList GetPurchaseList()
		{
			return null;
		}

		public virtual RejoinDialogResult GetRejoinDialogResult()
		{
			return null;
		}

		public virtual Room GetRoom()
		{
			return null;
		}

		public virtual RoomInviteNotification GetRoomInviteNotification()
		{
			return null;
		}

		public virtual RoomInviteNotificationList GetRoomInviteNotificationList()
		{
			return null;
		}

		public virtual RoomList GetRoomList()
		{
			return null;
		}

		public virtual SdkAccountList GetSdkAccountList()
		{
			return null;
		}

		public virtual SendInvitesResult GetSendInvitesResult()
		{
			return null;
		}

		public virtual ShareMediaResult GetShareMediaResult()
		{
			return null;
		}

		public virtual string GetString()
		{
			return null;
		}

		public virtual SystemVoipState GetSystemVoipState()
		{
			return null;
		}

		public virtual User GetUser()
		{
			return null;
		}

		public virtual UserAndRoomList GetUserAndRoomList()
		{
			return null;
		}

		public virtual UserDataStoreUpdateResponse GetUserDataStoreUpdateResponse()
		{
			return null;
		}

		public virtual UserList GetUserList()
		{
			return null;
		}

		public virtual UserProof GetUserProof()
		{
			return null;
		}

		public virtual UserReportID GetUserReportID()
		{
			return null;
		}

		internal static Message ParseMessageHandle(IntPtr messageHandle)
		{
			return null;
		}

		public static Message PopMessage()
		{
			return null;
		}
	}
}
