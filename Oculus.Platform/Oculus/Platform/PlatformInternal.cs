using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class PlatformInternal
	{
		public enum MessageTypeInternal : uint
		{
			AbuseReport_LaunchAdvancedReportFlow = 1286683246u,
			Application_ExecuteCoordinatedLaunch = 645772532u,
			Application_GetInstalledApplications = 1376744524u,
			Avatar_UpdateMetaData = 2077219214u,
			Cal_FinalizeApplication = 497667029u,
			Cal_GetSuggestedApplications = 1450209301u,
			Cal_ProposeApplication = 1317270237u,
			Colocation_GetCurrentMapUuid = 878018226u,
			Colocation_RequestMap = 840263277u,
			Colocation_ShareMap = 409847005u,
			GraphAPI_Get = 822018158u,
			GraphAPI_Post = 1990567876u,
			HTTP_Get = 1874211363u,
			HTTP_GetToFile = 1317133401u,
			HTTP_MultiPartPost = 1480774160u,
			HTTP_Post = 1798743375u,
			Livestreaming_IsAllowedForApplication = 191729014u,
			Livestreaming_StartPartyStream = 2066701532u,
			Livestreaming_StartStream = 1343932350u,
			Livestreaming_StopPartyStream = 661065560u,
			Livestreaming_StopStream = 1155796426u,
			Livestreaming_UpdateMicStatus = 475495815u,
			NetSync_Connect = 1684899167u,
			NetSync_Disconnect = 359268021u,
			NetSync_GetSessions = 1859521077u,
			NetSync_GetVoipAttenuation = 288016919u,
			NetSync_GetVoipAttenuationDefault = 1467721888u,
			NetSync_SetVoipAttenuation = 882366454u,
			NetSync_SetVoipAttenuationModel = 1788128654u,
			NetSync_SetVoipChannelCfg = 1553310963u,
			NetSync_SetVoipGroup = 1477614734u,
			NetSync_SetVoipListentoChannels = 1590749746u,
			NetSync_SetVoipMicSource = 855832432u,
			NetSync_SetVoipSessionMuted = 1434844938u,
			NetSync_SetVoipSpeaktoChannels = 766496213u,
			NetSync_SetVoipStreamMode = 1742839095u,
			Party_Create = 450042703u,
			Party_GatherInApplication = 1921499523u,
			Party_Get = 1586058173u,
			Party_GetCurrentForUser = 1489764138u,
			Party_Invite = 901104867u,
			Party_Join = 1744993395u,
			Party_Leave = 848430801u,
			RichPresence_SetDestination = 1328734477u,
			RichPresence_SetIsJoinable = 1050353505u,
			RichPresence_SetLobbySession = 1895893271u,
			RichPresence_SetMatchSession = 1675623566u,
			Room_CreateOrUpdateAndJoinNamed = 2089683601u,
			Room_GetNamedRooms = 125660812u,
			Room_GetSocialRooms = 1636310390u,
			User_CancelRecordingForReportFlow = 65065289u,
			User_GetLinkedAccounts = 1469314134u,
			User_LaunchBlockFlow = 1876305192u,
			User_LaunchReportFlow = 1449304081u,
			User_LaunchReportFlow2 = 2139314275u,
			User_LaunchUnblockFlow = 346172055u,
			User_NewEntitledTestUser = 292822787u,
			User_NewTestUser = 921194380u,
			User_NewTestUserFriends = 517416647u,
			User_StartRecordingForReportFlow = 1819161571u,
			User_StopRecordingAndLaunchReportFlow = 1618513035u,
			User_StopRecordingAndLaunchReportFlow2 = 432190251u,
			User_TestUserCreateDeviceManifest = 1701884605u
		}

		public static class HTTP
		{
			public static void SetHttpTransferUpdateCallback(Message<HttpTransferUpdate>.Callback callback)
			{
			}
		}

		public static class Users
		{
			public static Request<LinkedAccountList> GetLinkedAccounts(ServiceProvider[] providers)
			{
				return null;
			}
		}

		public static void CrashApplication()
		{
		}

		internal static Message ParseMessageHandle(IntPtr messageHandle, Message.MessageType messageType)
		{
			return null;
		}

		public static Request<PlatformInitialize> InitializeStandaloneAsync(ulong appID, string accessToken)
		{
			return null;
		}
	}
}
