using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Oculus.Platform
{
	public class CAPI
	{
		public struct ovrKeyValuePair
		{
			public string key_;

			private KeyValuePairType valueType_;

			public string stringValue_;

			public int intValue_;

			public double doubleValue_;

			public ovrKeyValuePair(string key, string value)
			{
				this.doubleValue_ = default(double);
				this.intValue_ = default(int);
				this.stringValue_ = default(string);
				this.valueType_ = default(KeyValuePairType);
				this.key_ = default(string);
			}

			public ovrKeyValuePair(string key, int value)
			{
				this.doubleValue_ = default(double);
				this.intValue_ = default(int);
				this.stringValue_ = default(string);
				this.valueType_ = default(KeyValuePairType);
				this.key_ = default(string);
			}

			public ovrKeyValuePair(string key, double value)
			{
				this.doubleValue_ = default(double);
				this.intValue_ = default(int);
				this.stringValue_ = default(string);
				this.valueType_ = default(KeyValuePairType);
				this.key_ = default(string);
			}
		}

		public struct ovrNetSyncVec3
		{
			public float x;

			public float y;

			public float z;
		}

		public struct ovrMatchmakingCriterion
		{
			public string key_;

			public MatchmakingCriterionImportance importance_;

			public IntPtr parameterArray;

			public uint parameterArrayCount;

			public ovrMatchmakingCriterion(string key, MatchmakingCriterionImportance importance)
			{
				this.parameterArrayCount = default(uint);
				this.parameterArray = default(IntPtr);
				this.importance_ = default(MatchmakingCriterionImportance);
				this.key_ = default(string);
			}
		}

		public struct ovrMatchmakingCustomQueryData
		{
			public IntPtr dataArray;

			public uint dataArrayCount;

			public IntPtr criterionArray;

			public uint criterionArrayCount;
		}

		public struct OculusInitParams
		{
			public int sType;

			public string email;

			public string password;

			public ulong appId;

			public string uriPrefixOverride;
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void FilterCallback([In][Out] short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels);

		public const string DLL_NAME = "ovrplatformloader";

		private static UTF8Encoding nativeStringEncoding;

		public const int VoipFilterBufferSize = 480;

		public static IntPtr ArrayOfStructsToIntPtr(Array ar)
		{
			return default(IntPtr);
		}

		public static ovrKeyValuePair[] DictionaryToOVRKeyValuePairs(Dictionary<string, object> dict)
		{
			return null;
		}

		public static byte[] IntPtrToByteArray(IntPtr data, ulong size)
		{
			return null;
		}

		public static Dictionary<string, string> DataStoreFromNative(IntPtr pointer)
		{
			return null;
		}

		public static string StringFromNative(IntPtr pointer)
		{
			return null;
		}

		public static int GetNativeStringLengthNotIncludingNullTerminator(IntPtr pointer)
		{
			return default(int);
		}

		public static DateTime DateTimeFromNative(ulong seconds_since_the_one_true_epoch)
		{
			return default(DateTime);
		}

		public static ulong DateTimeToNative(DateTime dt)
		{
			return default(ulong);
		}

		public static byte[] BlobFromNative(uint size, IntPtr pointer)
		{
			return null;
		}

		public static byte[] FiledataFromNative(uint size, IntPtr pointer)
		{
			return null;
		}

		public static IntPtr StringToNative(string s)
		{
			return default(IntPtr);
		}

		public static extern bool ovr_UnityInitWrapper(string appId);

		public static extern void ovr_UnityInitGlobals(IntPtr loggingCB);

		public static extern ulong ovr_UnityInitWrapperAsynchronous(string appId);

		public static extern bool ovr_UnityInitWrapperStandalone(string accessToken, IntPtr loggingCB);

		public static extern ulong ovr_Platform_InitializeStandaloneOculus(OculusInitParams init);

		public static extern ulong ovr_PlatformInitializeWithAccessToken(ulong appId, string accessToken);

		public static extern bool ovr_UnityInitWrapperWindows(string appId, IntPtr loggingCB);

		public static extern ulong ovr_UnityInitWrapperWindowsAsynchronous(string appId, IntPtr loggingCB);

		public static extern bool ovr_SetDeveloperAccessToken(string accessToken);

		public static string ovr_GetLoggedInUserLocale()
		{
			return null;
		}

		private static extern IntPtr ovr_GetLoggedInUserLocale_Native();

		public static extern IntPtr ovr_PopMessage();

		public static extern void ovr_FreeMessage(IntPtr message);

		public static extern IntPtr ovr_Voip_CreateEncoder();

		public static extern void ovr_Voip_DestroyEncoder(IntPtr encoder);

		public static extern IntPtr ovr_Voip_CreateDecoder();

		public static extern void ovr_Voip_DestroyDecoder(IntPtr decoder);

		public static extern void ovr_VoipDecoder_Decode(IntPtr obj, byte[] compressedData, ulong compressedSize);

		public static extern IntPtr ovr_Microphone_Create();

		public static extern void ovr_Microphone_Destroy(IntPtr obj);

		public static extern void ovr_Voip_SetSystemVoipPassthrough(bool passthrough);

		public static extern void ovr_Voip_SetSystemVoipMicrophoneMuted(VoipMuteState muted);

		public static extern void ovr_UnityResetTestPlatform();

		public static extern ulong ovr_HTTP_GetWithMessageType(string url, int messageType);

		public static extern void ovr_CrashApplication();

		public static extern void ovr_Voip_SetMicrophoneFilterCallback(FilterCallback cb);

		public static extern void ovr_Voip_SetMicrophoneFilterCallbackWithFixedSizeBuffer(FilterCallback cb, UIntPtr bufferSizeElements);

		public static void LogNewEvent(string eventName, Dictionary<string, string> values)
		{
		}

		public static extern void ovr_Log_NewEvent(IntPtr eventName, IntPtr[] values, UIntPtr length);

		public static extern IntPtr ovr_ApplicationLifecycle_GetLaunchDetails();

		public static void ovr_ApplicationLifecycle_LogDeeplinkResult(string trackingID, LaunchResult result)
		{
		}

		private static extern void ovr_ApplicationLifecycle_LogDeeplinkResult_Native(IntPtr trackingID, LaunchResult result);

		public static ulong ovr_HTTP_StartTransfer(string url, ovrKeyValuePair[] headers)
		{
			return default(ulong);
		}

		private static extern ulong ovr_HTTP_StartTransfer_Native(IntPtr url, ovrKeyValuePair[] headers, UIntPtr numItems);

		public static extern bool ovr_HTTP_Write(ulong transferId, byte[] bytes, UIntPtr length);

		public static extern void ovr_HTTP_WriteEOM(ulong transferId);

		public static string ovr_Message_GetStringForJavascript(IntPtr message)
		{
			return null;
		}

		private static extern IntPtr ovr_Message_GetStringForJavascript_Native(IntPtr message);

		public static extern UIntPtr ovr_NetSync_GetAmbisonicFloatPCM(long connection_id, float[] outputBuffer, UIntPtr outputBufferNumElements);

		public static extern UIntPtr ovr_NetSync_GetAmbisonicInt16PCM(long connection_id, short[] outputBuffer, UIntPtr outputBufferNumElements);

		public static extern UIntPtr ovr_NetSync_GetAmbisonicInterleavedFloatPCM(long connection_id, float[] outputBuffer, UIntPtr outputBufferNumElements);

		public static extern UIntPtr ovr_NetSync_GetAmbisonicInterleavedInt16PCM(long connection_id, short[] outputBuffer, UIntPtr outputBufferNumElements);

		public static extern bool ovr_NetSync_GetListenerPosition(long connection_id, ulong sessionId, ovrNetSyncVec3 position);

		public static extern UIntPtr ovr_NetSync_GetMonostreamFloatPCM(long connection_id, ulong sessionId, float[] outputBuffer, UIntPtr outputBufferNumElements);

		public static extern UIntPtr ovr_NetSync_GetMonostreamInt16PCM(long connection_id, ulong session_id, short[] outputBuffer, UIntPtr outputBufferNumElements);

		public static extern UIntPtr ovr_NetSync_GetPcmBufferMaxSamples();

		public static extern bool ovr_NetSync_GetVoipAmplitude(long connection_id, ulong sessionId, float amplitude);

		public static extern void ovr_NetSync_SetListenerPosition(long connection_id, ovrNetSyncVec3 position);

		public static extern void ovr_Net_Accept(ulong peerID);

		public static extern bool ovr_Net_AcceptForCurrentRoom();

		public static extern void ovr_Net_Close(ulong peerID);

		public static extern void ovr_Net_CloseForCurrentRoom();

		public static extern void ovr_Net_Connect(ulong peerID);

		public static extern bool ovr_Net_IsConnected(ulong peerID);

		public static extern ulong ovr_Net_Ping(ulong peerID);

		public static extern IntPtr ovr_Net_ReadPacket();

		public static extern bool ovr_Net_SendPacket(ulong userID, UIntPtr length, byte[] bytes, SendPolicy policy);

		public static extern bool ovr_Net_SendPacketToCurrentRoom(UIntPtr length, byte[] bytes, SendPolicy policy);

		public static extern int ovr_Party_PluginGetSharedMemHandle();

		public static extern VoipMuteState ovr_Party_PluginGetVoipMicrophoneMuted();

		public static extern bool ovr_Party_PluginGetVoipPassthrough();

		public static extern SystemVoipStatus ovr_Party_PluginGetVoipStatus();

		public static extern void ovr_Voip_Accept(ulong userID);

		public static extern VoipDtxState ovr_Voip_GetIsConnectionUsingDtx(ulong peerID);

		public static extern VoipBitrate ovr_Voip_GetLocalBitrate(ulong peerID);

		public static extern UIntPtr ovr_Voip_GetOutputBufferMaxSize();

		public static extern UIntPtr ovr_Voip_GetPCM(ulong senderID, short[] outputBuffer, UIntPtr outputBufferNumElements);

		public static extern UIntPtr ovr_Voip_GetPCMFloat(ulong senderID, float[] outputBuffer, UIntPtr outputBufferNumElements);

		public static extern UIntPtr ovr_Voip_GetPCMSize(ulong senderID);

		public static extern UIntPtr ovr_Voip_GetPCMWithTimestamp(ulong senderID, short[] outputBuffer, UIntPtr outputBufferNumElements, uint[] timestamp);

		public static extern UIntPtr ovr_Voip_GetPCMWithTimestampFloat(ulong senderID, float[] outputBuffer, UIntPtr outputBufferNumElements, uint[] timestamp);

		public static extern VoipBitrate ovr_Voip_GetRemoteBitrate(ulong peerID);

		public static extern uint ovr_Voip_GetSyncTimestamp(ulong userID);

		public static extern long ovr_Voip_GetSyncTimestampDifference(uint lhs, uint rhs);

		public static extern VoipMuteState ovr_Voip_GetSystemVoipMicrophoneMuted();

		public static extern SystemVoipStatus ovr_Voip_GetSystemVoipStatus();

		public static extern void ovr_Voip_SetMicrophoneMuted(VoipMuteState state);

		public static extern void ovr_Voip_SetNewConnectionOptions(IntPtr voipOptions);

		public static extern void ovr_Voip_SetOutputSampleRate(VoipSampleRate rate);

		public static extern void ovr_Voip_Start(ulong userID);

		public static extern void ovr_Voip_Stop(ulong userID);

		public static extern ulong ovr_AbuseReport_LaunchAdvancedReportFlow(ulong content_id, IntPtr abuse_report_options);

		public static ulong ovr_Achievements_AddCount(string name, ulong count)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Achievements_AddCount_Native(IntPtr name, ulong count);

		public static ulong ovr_Achievements_AddFields(string name, string fields)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Achievements_AddFields_Native(IntPtr name, IntPtr fields);

		public static extern ulong ovr_Achievements_GetAllDefinitions();

		public static extern ulong ovr_Achievements_GetAllProgress();

		public static extern ulong ovr_Achievements_GetDefinitionsByName(string[] names, int count);

		public static extern ulong ovr_Achievements_GetProgressByName(string[] names, int count);

		public static ulong ovr_Achievements_Unlock(string name)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Achievements_Unlock_Native(IntPtr name);

		public static extern ulong ovr_Application_ExecuteCoordinatedLaunch(ulong appID, ulong roomID);

		public static extern ulong ovr_Application_GetInstalledApplications();

		public static extern ulong ovr_Application_GetVersion();

		public static extern ulong ovr_Application_LaunchOtherApp(ulong appID, IntPtr deeplink_options);

		public static extern ulong ovr_ApplicationLifecycle_GetRegisteredPIDs();

		public static extern ulong ovr_ApplicationLifecycle_GetSessionKey();

		public static ulong ovr_ApplicationLifecycle_RegisterSessionKey(string sessionKey)
		{
			return default(ulong);
		}

		private static extern ulong ovr_ApplicationLifecycle_RegisterSessionKey_Native(IntPtr sessionKey);

		public static extern ulong ovr_AssetFile_Delete(ulong assetFileID);

		public static extern ulong ovr_AssetFile_DeleteById(ulong assetFileID);

		public static ulong ovr_AssetFile_DeleteByName(string assetFileName)
		{
			return default(ulong);
		}

		private static extern ulong ovr_AssetFile_DeleteByName_Native(IntPtr assetFileName);

		public static extern ulong ovr_AssetFile_Download(ulong assetFileID);

		public static extern ulong ovr_AssetFile_DownloadById(ulong assetFileID);

		public static ulong ovr_AssetFile_DownloadByName(string assetFileName)
		{
			return default(ulong);
		}

		private static extern ulong ovr_AssetFile_DownloadByName_Native(IntPtr assetFileName);

		public static extern ulong ovr_AssetFile_DownloadCancel(ulong assetFileID);

		public static extern ulong ovr_AssetFile_DownloadCancelById(ulong assetFileID);

		public static ulong ovr_AssetFile_DownloadCancelByName(string assetFileName)
		{
			return default(ulong);
		}

		private static extern ulong ovr_AssetFile_DownloadCancelByName_Native(IntPtr assetFileName);

		public static extern ulong ovr_AssetFile_GetList();

		public static extern ulong ovr_AssetFile_Status(ulong assetFileID);

		public static extern ulong ovr_AssetFile_StatusById(ulong assetFileID);

		public static ulong ovr_AssetFile_StatusByName(string assetFileName)
		{
			return default(ulong);
		}

		private static extern ulong ovr_AssetFile_StatusByName_Native(IntPtr assetFileName);

		public static ulong ovr_Avatar_UpdateMetaData(string avatarMetaData, string imageFilePath)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Avatar_UpdateMetaData_Native(IntPtr avatarMetaData, IntPtr imageFilePath);

		public static extern ulong ovr_Cal_FinalizeApplication(ulong groupingObject, ulong[] userIDs, int numUserIDs, ulong finalized_application_ID);

		public static extern ulong ovr_Cal_GetSuggestedApplications(ulong groupingObject, ulong[] userIDs, int numUserIDs);

		public static extern ulong ovr_Cal_ProposeApplication(ulong groupingObject, ulong[] userIDs, int numUserIDs, ulong proposed_application_ID);

		public static ulong ovr_Challenges_Create(string leaderboardName, IntPtr challengeOptions)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Challenges_Create_Native(IntPtr leaderboardName, IntPtr challengeOptions);

		public static extern ulong ovr_Challenges_DeclineInvite(ulong challengeID);

		public static extern ulong ovr_Challenges_Delete(ulong challengeID);

		public static extern ulong ovr_Challenges_Get(ulong challengeID);

		public static extern ulong ovr_Challenges_GetEntries(ulong challengeID, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt);

		public static extern ulong ovr_Challenges_GetEntriesAfterRank(ulong challengeID, int limit, ulong afterRank);

		public static extern ulong ovr_Challenges_GetEntriesByIds(ulong challengeID, int limit, LeaderboardStartAt startAt, ulong[] userIDs, uint userIDLength);

		public static extern ulong ovr_Challenges_GetList(IntPtr challengeOptions, int limit);

		public static extern ulong ovr_Challenges_GetNextChallenges(IntPtr handle);

		public static extern ulong ovr_Challenges_GetNextEntries(IntPtr handle);

		public static extern ulong ovr_Challenges_GetPreviousChallenges(IntPtr handle);

		public static extern ulong ovr_Challenges_GetPreviousEntries(IntPtr handle);

		public static extern ulong ovr_Challenges_Join(ulong challengeID);

		public static extern ulong ovr_Challenges_Leave(ulong challengeID);

		public static extern ulong ovr_Challenges_UpdateInfo(ulong challengeID, IntPtr challengeOptions);

		public static ulong ovr_CloudStorage_Delete(string bucket, string key)
		{
			return default(ulong);
		}

		private static extern ulong ovr_CloudStorage_Delete_Native(IntPtr bucket, IntPtr key);

		public static ulong ovr_CloudStorage_Load(string bucket, string key)
		{
			return default(ulong);
		}

		private static extern ulong ovr_CloudStorage_Load_Native(IntPtr bucket, IntPtr key);

		public static ulong ovr_CloudStorage_LoadBucketMetadata(string bucket)
		{
			return default(ulong);
		}

		private static extern ulong ovr_CloudStorage_LoadBucketMetadata_Native(IntPtr bucket);

		public static ulong ovr_CloudStorage_LoadConflictMetadata(string bucket, string key)
		{
			return default(ulong);
		}

		private static extern ulong ovr_CloudStorage_LoadConflictMetadata_Native(IntPtr bucket, IntPtr key);

		public static ulong ovr_CloudStorage_LoadHandle(string handle)
		{
			return default(ulong);
		}

		private static extern ulong ovr_CloudStorage_LoadHandle_Native(IntPtr handle);

		public static ulong ovr_CloudStorage_LoadMetadata(string bucket, string key)
		{
			return default(ulong);
		}

		private static extern ulong ovr_CloudStorage_LoadMetadata_Native(IntPtr bucket, IntPtr key);

		public static ulong ovr_CloudStorage_ResolveKeepLocal(string bucket, string key, string remoteHandle)
		{
			return default(ulong);
		}

		private static extern ulong ovr_CloudStorage_ResolveKeepLocal_Native(IntPtr bucket, IntPtr key, IntPtr remoteHandle);

		public static ulong ovr_CloudStorage_ResolveKeepRemote(string bucket, string key, string remoteHandle)
		{
			return default(ulong);
		}

		private static extern ulong ovr_CloudStorage_ResolveKeepRemote_Native(IntPtr bucket, IntPtr key, IntPtr remoteHandle);

		public static ulong ovr_CloudStorage_Save(string bucket, string key, byte[] data, uint dataSize, long counter, string extraData)
		{
			return default(ulong);
		}

		private static extern ulong ovr_CloudStorage_Save_Native(IntPtr bucket, IntPtr key, byte[] data, uint dataSize, long counter, IntPtr extraData);

		public static extern ulong ovr_CloudStorage2_GetUserDirectoryPath();

		public static extern ulong ovr_Colocation_GetCurrentMapUuid();

		public static ulong ovr_Colocation_RequestMap(string uuid)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Colocation_RequestMap_Native(IntPtr uuid);

		public static ulong ovr_Colocation_ShareMap(string uuid)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Colocation_ShareMap_Native(IntPtr uuid);

		public static extern ulong ovr_Entitlement_GetIsViewerEntitled();

		public static ulong ovr_GraphAPI_Get(string url)
		{
			return default(ulong);
		}

		private static extern ulong ovr_GraphAPI_Get_Native(IntPtr url);

		public static ulong ovr_GraphAPI_Post(string url)
		{
			return default(ulong);
		}

		private static extern ulong ovr_GraphAPI_Post_Native(IntPtr url);

		public static extern ulong ovr_GroupPresence_Clear();

		public static extern ulong ovr_GroupPresence_GetInvitableUsers(IntPtr options);

		public static extern ulong ovr_GroupPresence_GetSentInvites();

		public static extern ulong ovr_GroupPresence_LaunchInvitePanel(IntPtr options);

		public static extern ulong ovr_GroupPresence_LaunchMultiplayerErrorDialog(IntPtr options);

		public static ulong ovr_GroupPresence_LaunchRejoinDialog(string lobby_session_id, string match_session_id, string destination_api_name)
		{
			return default(ulong);
		}

		private static extern ulong ovr_GroupPresence_LaunchRejoinDialog_Native(IntPtr lobby_session_id, IntPtr match_session_id, IntPtr destination_api_name);

		public static extern ulong ovr_GroupPresence_LaunchRosterPanel(IntPtr options);

		public static extern ulong ovr_GroupPresence_SendInvites(ulong[] userIDs, uint userIDLength);

		public static extern ulong ovr_GroupPresence_Set(IntPtr groupPresenceOptions);

		public static ulong ovr_GroupPresence_SetDestination(string api_name)
		{
			return default(ulong);
		}

		private static extern ulong ovr_GroupPresence_SetDestination_Native(IntPtr api_name);

		public static extern ulong ovr_GroupPresence_SetIsJoinable(bool is_joinable);

		public static ulong ovr_GroupPresence_SetLobbySession(string id)
		{
			return default(ulong);
		}

		private static extern ulong ovr_GroupPresence_SetLobbySession_Native(IntPtr id);

		public static ulong ovr_GroupPresence_SetMatchSession(string id)
		{
			return default(ulong);
		}

		private static extern ulong ovr_GroupPresence_SetMatchSession_Native(IntPtr id);

		public static ulong ovr_HTTP_Get(string url)
		{
			return default(ulong);
		}

		private static extern ulong ovr_HTTP_Get_Native(IntPtr url);

		public static ulong ovr_HTTP_GetToFile(string url, string diskFile)
		{
			return default(ulong);
		}

		private static extern ulong ovr_HTTP_GetToFile_Native(IntPtr url, IntPtr diskFile);

		public static ulong ovr_HTTP_MultiPartPost(string url, string filepath_param_name, string filepath, string access_token, ovrKeyValuePair[] post_params)
		{
			return default(ulong);
		}

		private static extern ulong ovr_HTTP_MultiPartPost_Native(IntPtr url, IntPtr filepath_param_name, IntPtr filepath, IntPtr access_token, ovrKeyValuePair[] post_params, UIntPtr numItems);

		public static ulong ovr_HTTP_Post(string url)
		{
			return default(ulong);
		}

		private static extern ulong ovr_HTTP_Post_Native(IntPtr url);

		public static ulong ovr_IAP_ConsumePurchase(string sku)
		{
			return default(ulong);
		}

		private static extern ulong ovr_IAP_ConsumePurchase_Native(IntPtr sku);

		public static extern ulong ovr_IAP_GetProductsBySKU(string[] skus, int count);

		public static extern ulong ovr_IAP_GetViewerPurchases();

		public static extern ulong ovr_IAP_GetViewerPurchasesDurableCache();

		public static ulong ovr_IAP_LaunchCheckoutFlow(string sku)
		{
			return default(ulong);
		}

		private static extern ulong ovr_IAP_LaunchCheckoutFlow_Native(IntPtr sku);

		public static extern ulong ovr_LanguagePack_GetCurrent();

		public static ulong ovr_LanguagePack_SetCurrent(string tag)
		{
			return default(ulong);
		}

		private static extern ulong ovr_LanguagePack_SetCurrent_Native(IntPtr tag);

		public static ulong ovr_Leaderboard_Get(string leaderboardName)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Leaderboard_Get_Native(IntPtr leaderboardName);

		public static ulong ovr_Leaderboard_GetEntries(string leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Leaderboard_GetEntries_Native(IntPtr leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt);

		public static ulong ovr_Leaderboard_GetEntriesAfterRank(string leaderboardName, int limit, ulong afterRank)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Leaderboard_GetEntriesAfterRank_Native(IntPtr leaderboardName, int limit, ulong afterRank);

		public static ulong ovr_Leaderboard_GetEntriesByIds(string leaderboardName, int limit, LeaderboardStartAt startAt, ulong[] userIDs, uint userIDLength)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Leaderboard_GetEntriesByIds_Native(IntPtr leaderboardName, int limit, LeaderboardStartAt startAt, ulong[] userIDs, uint userIDLength);

		public static extern ulong ovr_Leaderboard_GetNextEntries(IntPtr handle);

		public static extern ulong ovr_Leaderboard_GetPreviousEntries(IntPtr handle);

		public static ulong ovr_Leaderboard_WriteEntry(string leaderboardName, long score, byte[] extraData, uint extraDataLength, bool forceUpdate)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Leaderboard_WriteEntry_Native(IntPtr leaderboardName, long score, byte[] extraData, uint extraDataLength, bool forceUpdate);

		public static ulong ovr_Leaderboard_WriteEntryWithSupplementaryMetric(string leaderboardName, long score, long supplementaryMetric, byte[] extraData, uint extraDataLength, bool forceUpdate)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Leaderboard_WriteEntryWithSupplementaryMetric_Native(IntPtr leaderboardName, long score, long supplementaryMetric, byte[] extraData, uint extraDataLength, bool forceUpdate);

		public static ulong ovr_Livestreaming_IsAllowedForApplication(string packageName)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Livestreaming_IsAllowedForApplication_Native(IntPtr packageName);

		public static extern ulong ovr_Livestreaming_StartPartyStream();

		public static extern ulong ovr_Livestreaming_StartStream(LivestreamingAudience audience, LivestreamingMicrophoneStatus micStatus);

		public static extern ulong ovr_Livestreaming_StopPartyStream();

		public static extern ulong ovr_Livestreaming_StopStream();

		public static extern ulong ovr_Livestreaming_UpdateMicStatus(LivestreamingMicrophoneStatus micStatus);

		public static ulong ovr_Matchmaking_Browse(string pool, IntPtr customQueryData)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_Browse_Native(IntPtr pool, IntPtr customQueryData);

		public static ulong ovr_Matchmaking_Browse2(string pool, IntPtr matchmakingOptions)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_Browse2_Native(IntPtr pool, IntPtr matchmakingOptions);

		public static ulong ovr_Matchmaking_Cancel(string pool, string requestHash)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_Cancel_Native(IntPtr pool, IntPtr requestHash);

		public static extern ulong ovr_Matchmaking_Cancel2();

		public static ulong ovr_Matchmaking_CreateAndEnqueueRoom(string pool, uint maxUsers, bool subscribeToUpdates, IntPtr customQueryData)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_CreateAndEnqueueRoom_Native(IntPtr pool, uint maxUsers, bool subscribeToUpdates, IntPtr customQueryData);

		public static ulong ovr_Matchmaking_CreateAndEnqueueRoom2(string pool, IntPtr matchmakingOptions)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_CreateAndEnqueueRoom2_Native(IntPtr pool, IntPtr matchmakingOptions);

		public static ulong ovr_Matchmaking_CreateRoom(string pool, uint maxUsers, bool subscribeToUpdates)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_CreateRoom_Native(IntPtr pool, uint maxUsers, bool subscribeToUpdates);

		public static ulong ovr_Matchmaking_CreateRoom2(string pool, IntPtr matchmakingOptions)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_CreateRoom2_Native(IntPtr pool, IntPtr matchmakingOptions);

		public static ulong ovr_Matchmaking_Enqueue(string pool, IntPtr customQueryData)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_Enqueue_Native(IntPtr pool, IntPtr customQueryData);

		public static ulong ovr_Matchmaking_Enqueue2(string pool, IntPtr matchmakingOptions)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_Enqueue2_Native(IntPtr pool, IntPtr matchmakingOptions);

		public static extern ulong ovr_Matchmaking_EnqueueRoom(ulong roomID, IntPtr customQueryData);

		public static extern ulong ovr_Matchmaking_EnqueueRoom2(ulong roomID, IntPtr matchmakingOptions);

		public static extern ulong ovr_Matchmaking_GetAdminSnapshot();

		public static ulong ovr_Matchmaking_GetStats(string pool, uint maxLevel, MatchmakingStatApproach approach)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_GetStats_Native(IntPtr pool, uint maxLevel, MatchmakingStatApproach approach);

		public static extern ulong ovr_Matchmaking_JoinRoom(ulong roomID, bool subscribeToUpdates);

		public static ulong ovr_Matchmaking_ReportResultInsecure(ulong roomID, ovrKeyValuePair[] data)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Matchmaking_ReportResultInsecure_Native(ulong roomID, ovrKeyValuePair[] data, UIntPtr numItems);

		public static extern ulong ovr_Matchmaking_StartMatch(ulong roomID);

		public static ulong ovr_Media_ShareToFacebook(string postTextSuggestion, string filePath, MediaContentType contentType)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Media_ShareToFacebook_Native(IntPtr postTextSuggestion, IntPtr filePath, MediaContentType contentType);

		public static extern ulong ovr_NetSync_Connect(IntPtr connect_options);

		public static extern ulong ovr_NetSync_Disconnect(long connection_id);

		public static extern ulong ovr_NetSync_GetSessions(long connection_id);

		public static extern ulong ovr_NetSync_GetVoipAttenuation(long connection_id);

		public static extern ulong ovr_NetSync_GetVoipAttenuationDefault();

		public static extern ulong ovr_NetSync_SetVoipAttenuation(long connection_id, float[] distances, float[] decibels, UIntPtr count);

		public static ulong ovr_NetSync_SetVoipAttenuationModel(long connection_id, string name, float[] distances, float[] decibels, UIntPtr count)
		{
			return default(ulong);
		}

		private static extern ulong ovr_NetSync_SetVoipAttenuationModel_Native(long connection_id, IntPtr name, float[] distances, float[] decibels, UIntPtr count);

		public static ulong ovr_NetSync_SetVoipChannelCfg(long connection_id, string channel_name, string attnmodel, bool disable_spatialization)
		{
			return default(ulong);
		}

		private static extern ulong ovr_NetSync_SetVoipChannelCfg_Native(long connection_id, IntPtr channel_name, IntPtr attnmodel, bool disable_spatialization);

		public static ulong ovr_NetSync_SetVoipGroup(long connection_id, string group_id)
		{
			return default(ulong);
		}

		private static extern ulong ovr_NetSync_SetVoipGroup_Native(long connection_id, IntPtr group_id);

		public static extern ulong ovr_NetSync_SetVoipListentoChannels(long connection_id, string[] listento_channels, UIntPtr count);

		public static extern ulong ovr_NetSync_SetVoipMicSource(long connection_id, NetSyncVoipMicSource mic_source);

		public static extern ulong ovr_NetSync_SetVoipSessionMuted(long connection_id, ulong session_id, bool muted);

		public static extern ulong ovr_NetSync_SetVoipSpeaktoChannels(long connection_id, string[] speakto_channels, UIntPtr count);

		public static extern ulong ovr_NetSync_SetVoipStreamMode(long connection_id, ulong sessionId, NetSyncVoipStreamMode streamMode);

		public static extern ulong ovr_Notification_GetRoomInvites();

		public static extern ulong ovr_Notification_MarkAsRead(ulong notificationID);

		public static extern ulong ovr_Party_Create();

		public static extern ulong ovr_Party_GatherInApplication(ulong partyID, ulong appID);

		public static extern ulong ovr_Party_Get(ulong partyID);

		public static extern ulong ovr_Party_GetCurrent();

		public static extern ulong ovr_Party_GetCurrentForUser(ulong userID);

		public static extern ulong ovr_Party_Invite(ulong partyID, ulong userID);

		public static extern ulong ovr_Party_Join(ulong partyID);

		public static extern ulong ovr_Party_Leave(ulong partyID);

		public static extern ulong ovr_RichPresence_Clear();

		public static extern ulong ovr_RichPresence_GetDestinations();

		public static extern ulong ovr_RichPresence_Set(IntPtr richPresenceOptions);

		public static ulong ovr_RichPresence_SetDestination(string api_name)
		{
			return default(ulong);
		}

		private static extern ulong ovr_RichPresence_SetDestination_Native(IntPtr api_name);

		public static extern ulong ovr_RichPresence_SetIsJoinable(bool is_joinable);

		public static ulong ovr_RichPresence_SetLobbySession(string id)
		{
			return default(ulong);
		}

		private static extern ulong ovr_RichPresence_SetLobbySession_Native(IntPtr id);

		public static ulong ovr_RichPresence_SetMatchSession(string id)
		{
			return default(ulong);
		}

		private static extern ulong ovr_RichPresence_SetMatchSession_Native(IntPtr id);

		public static extern ulong ovr_Room_CreateAndJoinPrivate(RoomJoinPolicy joinPolicy, uint maxUsers, bool subscribeToUpdates);

		public static extern ulong ovr_Room_CreateAndJoinPrivate2(RoomJoinPolicy joinPolicy, uint maxUsers, IntPtr roomOptions);

		public static extern ulong ovr_Room_Get(ulong roomID);

		public static extern ulong ovr_Room_GetCurrent();

		public static extern ulong ovr_Room_GetCurrentForUser(ulong userID);

		public static extern ulong ovr_Room_GetInvitableUsers();

		public static extern ulong ovr_Room_GetInvitableUsers2(IntPtr roomOptions);

		public static extern ulong ovr_Room_GetModeratedRooms();

		public static extern ulong ovr_Room_GetSocialRooms(ulong appID);

		public static ulong ovr_Room_InviteUser(ulong roomID, string inviteToken)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Room_InviteUser_Native(ulong roomID, IntPtr inviteToken);

		public static extern ulong ovr_Room_Join(ulong roomID, bool subscribeToUpdates);

		public static extern ulong ovr_Room_Join2(ulong roomID, IntPtr roomOptions);

		public static extern ulong ovr_Room_KickUser(ulong roomID, ulong userID, int kickDurationSeconds);

		public static extern ulong ovr_Room_LaunchInvitableUserFlow(ulong roomID);

		public static extern ulong ovr_Room_Leave(ulong roomID);

		public static ulong ovr_Room_SetDescription(ulong roomID, string description)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Room_SetDescription_Native(ulong roomID, IntPtr description);

		public static ulong ovr_Room_UpdateDataStore(ulong roomID, ovrKeyValuePair[] data)
		{
			return default(ulong);
		}

		private static extern ulong ovr_Room_UpdateDataStore_Native(ulong roomID, ovrKeyValuePair[] data, UIntPtr numItems);

		public static extern ulong ovr_Room_UpdateMembershipLockStatus(ulong roomID, RoomMembershipLockStatus membershipLockStatus);

		public static extern ulong ovr_Room_UpdateOwner(ulong roomID, ulong userID);

		public static extern ulong ovr_Room_UpdatePrivateRoomJoinPolicy(ulong roomID, RoomJoinPolicy newJoinPolicy);

		public static ulong ovr_User_CancelRecordingForReportFlow(string recordingUUID)
		{
			return default(ulong);
		}

		private static extern ulong ovr_User_CancelRecordingForReportFlow_Native(IntPtr recordingUUID);

		public static extern ulong ovr_User_Get(ulong userID);

		public static extern ulong ovr_User_GetAccessToken();

		public static extern ulong ovr_User_GetLinkedAccounts(IntPtr userOptions);

		public static extern ulong ovr_User_GetLoggedInUser();

		public static extern ulong ovr_User_GetLoggedInUserFriends();

		public static extern ulong ovr_User_GetLoggedInUserFriendsAndRooms();

		public static extern ulong ovr_User_GetLoggedInUserRecentlyMetUsersAndRooms(IntPtr userOptions);

		public static extern ulong ovr_User_GetOrgScopedID(ulong userID);

		public static extern ulong ovr_User_GetSdkAccounts();

		public static extern ulong ovr_User_GetUserProof();

		public static extern ulong ovr_User_LaunchBlockFlow(ulong userID);

		public static extern ulong ovr_User_LaunchFriendRequestFlow(ulong userID);

		public static extern ulong ovr_User_LaunchReportFlow(ulong userID);

		public static extern ulong ovr_User_LaunchReportFlow2(ulong optionalUserID, IntPtr abuseReportOptions);

		public static extern ulong ovr_User_LaunchUnblockFlow(ulong userID);

		public static extern ulong ovr_User_NewEntitledTestUser();

		public static extern ulong ovr_User_NewTestUser();

		public static extern ulong ovr_User_NewTestUserFriends();

		public static extern ulong ovr_User_StartRecordingForReportFlow();

		public static ulong ovr_User_StopRecordingAndLaunchReportFlow(ulong optionalUserID, string optionalRecordingUUID)
		{
			return default(ulong);
		}

		private static extern ulong ovr_User_StopRecordingAndLaunchReportFlow_Native(ulong optionalUserID, IntPtr optionalRecordingUUID);

		public static ulong ovr_User_StopRecordingAndLaunchReportFlow2(ulong optionalUserID, string optionalRecordingUUID, IntPtr abuseReportOptions)
		{
			return default(ulong);
		}

		private static extern ulong ovr_User_StopRecordingAndLaunchReportFlow2_Native(ulong optionalUserID, IntPtr optionalRecordingUUID, IntPtr abuseReportOptions);

		public static ulong ovr_User_TestUserCreateDeviceManifest(string deviceID, ulong[] appIDs, int numAppIDs)
		{
			return default(ulong);
		}

		private static extern ulong ovr_User_TestUserCreateDeviceManifest_Native(IntPtr deviceID, ulong[] appIDs, int numAppIDs);

		public static ulong ovr_UserDataStore_PrivateDeleteEntryByKey(ulong userID, string key)
		{
			return default(ulong);
		}

		private static extern ulong ovr_UserDataStore_PrivateDeleteEntryByKey_Native(ulong userID, IntPtr key);

		public static extern ulong ovr_UserDataStore_PrivateGetEntries(ulong userID);

		public static ulong ovr_UserDataStore_PrivateGetEntryByKey(ulong userID, string key)
		{
			return default(ulong);
		}

		private static extern ulong ovr_UserDataStore_PrivateGetEntryByKey_Native(ulong userID, IntPtr key);

		public static ulong ovr_UserDataStore_PrivateWriteEntry(ulong userID, string key, string value)
		{
			return default(ulong);
		}

		private static extern ulong ovr_UserDataStore_PrivateWriteEntry_Native(ulong userID, IntPtr key, IntPtr value);

		public static ulong ovr_UserDataStore_PublicDeleteEntryByKey(ulong userID, string key)
		{
			return default(ulong);
		}

		private static extern ulong ovr_UserDataStore_PublicDeleteEntryByKey_Native(ulong userID, IntPtr key);

		public static extern ulong ovr_UserDataStore_PublicGetEntries(ulong userID);

		public static ulong ovr_UserDataStore_PublicGetEntryByKey(ulong userID, string key)
		{
			return default(ulong);
		}

		private static extern ulong ovr_UserDataStore_PublicGetEntryByKey_Native(ulong userID, IntPtr key);

		public static ulong ovr_UserDataStore_PublicWriteEntry(ulong userID, string key, string value)
		{
			return default(ulong);
		}

		private static extern ulong ovr_UserDataStore_PublicWriteEntry_Native(ulong userID, IntPtr key, IntPtr value);

		public static extern ulong ovr_Voip_GetMicrophoneAvailability();

		public static extern ulong ovr_Voip_SetSystemVoipSuppressed(bool suppressed);

		public static string ovr_AbuseReportRecording_GetRecordingUuid(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AbuseReportRecording_GetRecordingUuid_Native(IntPtr obj);

		public static extern uint ovr_AchievementDefinition_GetBitfieldLength(IntPtr obj);

		public static string ovr_AchievementDefinition_GetName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AchievementDefinition_GetName_Native(IntPtr obj);

		public static extern ulong ovr_AchievementDefinition_GetTarget(IntPtr obj);

		public static extern AchievementType ovr_AchievementDefinition_GetType(IntPtr obj);

		public static extern IntPtr ovr_AchievementDefinitionArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_AchievementDefinitionArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AchievementDefinitionArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_AchievementDefinitionArray_GetSize(IntPtr obj);

		public static extern bool ovr_AchievementDefinitionArray_HasNextPage(IntPtr obj);

		public static string ovr_AchievementProgress_GetBitfield(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AchievementProgress_GetBitfield_Native(IntPtr obj);

		public static extern ulong ovr_AchievementProgress_GetCount(IntPtr obj);

		public static extern bool ovr_AchievementProgress_GetIsUnlocked(IntPtr obj);

		public static string ovr_AchievementProgress_GetName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AchievementProgress_GetName_Native(IntPtr obj);

		public static DateTime ovr_AchievementProgress_GetUnlockTime(IntPtr obj)
		{
			return default(DateTime);
		}

		private static extern ulong ovr_AchievementProgress_GetUnlockTime_Native(IntPtr obj);

		public static extern IntPtr ovr_AchievementProgressArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_AchievementProgressArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AchievementProgressArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_AchievementProgressArray_GetSize(IntPtr obj);

		public static extern bool ovr_AchievementProgressArray_HasNextPage(IntPtr obj);

		public static extern bool ovr_AchievementUpdate_GetJustUnlocked(IntPtr obj);

		public static string ovr_AchievementUpdate_GetName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AchievementUpdate_GetName_Native(IntPtr obj);

		public static extern ulong ovr_Application_GetID(IntPtr obj);

		public static extern IntPtr ovr_ApplicationInvite_GetDestination(IntPtr obj);

		public static extern ulong ovr_ApplicationInvite_GetID(IntPtr obj);

		public static extern bool ovr_ApplicationInvite_GetIsActive(IntPtr obj);

		public static string ovr_ApplicationInvite_GetLobbySessionId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ApplicationInvite_GetLobbySessionId_Native(IntPtr obj);

		public static string ovr_ApplicationInvite_GetMatchSessionId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ApplicationInvite_GetMatchSessionId_Native(IntPtr obj);

		public static extern IntPtr ovr_ApplicationInvite_GetRecipient(IntPtr obj);

		public static extern IntPtr ovr_ApplicationInviteArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_ApplicationInviteArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ApplicationInviteArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_ApplicationInviteArray_GetSize(IntPtr obj);

		public static extern bool ovr_ApplicationInviteArray_HasNextPage(IntPtr obj);

		public static extern int ovr_ApplicationVersion_GetCurrentCode(IntPtr obj);

		public static string ovr_ApplicationVersion_GetCurrentName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ApplicationVersion_GetCurrentName_Native(IntPtr obj);

		public static extern int ovr_ApplicationVersion_GetLatestCode(IntPtr obj);

		public static string ovr_ApplicationVersion_GetLatestName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ApplicationVersion_GetLatestName_Native(IntPtr obj);

		public static extern ulong ovr_AssetDetails_GetAssetId(IntPtr obj);

		public static string ovr_AssetDetails_GetAssetType(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AssetDetails_GetAssetType_Native(IntPtr obj);

		public static string ovr_AssetDetails_GetDownloadStatus(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AssetDetails_GetDownloadStatus_Native(IntPtr obj);

		public static string ovr_AssetDetails_GetFilepath(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AssetDetails_GetFilepath_Native(IntPtr obj);

		public static string ovr_AssetDetails_GetIapStatus(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AssetDetails_GetIapStatus_Native(IntPtr obj);

		public static extern IntPtr ovr_AssetDetails_GetLanguage(IntPtr obj);

		public static string ovr_AssetDetails_GetMetadata(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AssetDetails_GetMetadata_Native(IntPtr obj);

		public static extern IntPtr ovr_AssetDetailsArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_AssetDetailsArray_GetSize(IntPtr obj);

		public static extern ulong ovr_AssetFileDeleteResult_GetAssetFileId(IntPtr obj);

		public static extern ulong ovr_AssetFileDeleteResult_GetAssetId(IntPtr obj);

		public static string ovr_AssetFileDeleteResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AssetFileDeleteResult_GetFilepath_Native(IntPtr obj);

		public static extern bool ovr_AssetFileDeleteResult_GetSuccess(IntPtr obj);

		public static extern ulong ovr_AssetFileDownloadCancelResult_GetAssetFileId(IntPtr obj);

		public static extern ulong ovr_AssetFileDownloadCancelResult_GetAssetId(IntPtr obj);

		public static string ovr_AssetFileDownloadCancelResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AssetFileDownloadCancelResult_GetFilepath_Native(IntPtr obj);

		public static extern bool ovr_AssetFileDownloadCancelResult_GetSuccess(IntPtr obj);

		public static extern ulong ovr_AssetFileDownloadResult_GetAssetId(IntPtr obj);

		public static string ovr_AssetFileDownloadResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_AssetFileDownloadResult_GetFilepath_Native(IntPtr obj);

		public static extern ulong ovr_AssetFileDownloadUpdate_GetAssetFileId(IntPtr obj);

		public static extern ulong ovr_AssetFileDownloadUpdate_GetAssetId(IntPtr obj);

		public static extern uint ovr_AssetFileDownloadUpdate_GetBytesTotal(IntPtr obj);

		public static extern ulong ovr_AssetFileDownloadUpdate_GetBytesTotalLong(IntPtr obj);

		public static extern int ovr_AssetFileDownloadUpdate_GetBytesTransferred(IntPtr obj);

		public static extern long ovr_AssetFileDownloadUpdate_GetBytesTransferredLong(IntPtr obj);

		public static extern bool ovr_AssetFileDownloadUpdate_GetCompleted(IntPtr obj);

		public static extern int ovr_CalApplicationFinalized_GetCountdownMS(IntPtr obj);

		public static extern ulong ovr_CalApplicationFinalized_GetID(IntPtr obj);

		public static string ovr_CalApplicationFinalized_GetLaunchDetails(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CalApplicationFinalized_GetLaunchDetails_Native(IntPtr obj);

		public static extern ulong ovr_CalApplicationProposed_GetID(IntPtr obj);

		public static extern ulong ovr_CalApplicationSuggestion_GetID(IntPtr obj);

		public static string ovr_CalApplicationSuggestion_GetSocialContext(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CalApplicationSuggestion_GetSocialContext_Native(IntPtr obj);

		public static extern IntPtr ovr_CalApplicationSuggestionArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_CalApplicationSuggestionArray_GetSize(IntPtr obj);

		public static extern ChallengeCreationType ovr_Challenge_GetCreationType(IntPtr obj);

		public static string ovr_Challenge_GetDescription(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Challenge_GetDescription_Native(IntPtr obj);

		public static DateTime ovr_Challenge_GetEndDate(IntPtr obj)
		{
			return default(DateTime);
		}

		private static extern ulong ovr_Challenge_GetEndDate_Native(IntPtr obj);

		public static extern ulong ovr_Challenge_GetID(IntPtr obj);

		public static extern IntPtr ovr_Challenge_GetInvitedUsers(IntPtr obj);

		public static extern IntPtr ovr_Challenge_GetLeaderboard(IntPtr obj);

		public static extern IntPtr ovr_Challenge_GetParticipants(IntPtr obj);

		public static DateTime ovr_Challenge_GetStartDate(IntPtr obj)
		{
			return default(DateTime);
		}

		private static extern ulong ovr_Challenge_GetStartDate_Native(IntPtr obj);

		public static string ovr_Challenge_GetTitle(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Challenge_GetTitle_Native(IntPtr obj);

		public static extern ChallengeVisibility ovr_Challenge_GetVisibility(IntPtr obj);

		public static extern IntPtr ovr_ChallengeArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_ChallengeArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ChallengeArray_GetNextUrl_Native(IntPtr obj);

		public static string ovr_ChallengeArray_GetPreviousUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ChallengeArray_GetPreviousUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_ChallengeArray_GetSize(IntPtr obj);

		public static extern ulong ovr_ChallengeArray_GetTotalCount(IntPtr obj);

		public static extern bool ovr_ChallengeArray_HasNextPage(IntPtr obj);

		public static extern bool ovr_ChallengeArray_HasPreviousPage(IntPtr obj);

		public static string ovr_ChallengeEntry_GetDisplayScore(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ChallengeEntry_GetDisplayScore_Native(IntPtr obj);

		public static byte[] ovr_ChallengeEntry_GetExtraData(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ChallengeEntry_GetExtraData_Native(IntPtr obj);

		public static extern uint ovr_ChallengeEntry_GetExtraDataLength(IntPtr obj);

		public static extern ulong ovr_ChallengeEntry_GetID(IntPtr obj);

		public static extern int ovr_ChallengeEntry_GetRank(IntPtr obj);

		public static extern long ovr_ChallengeEntry_GetScore(IntPtr obj);

		public static DateTime ovr_ChallengeEntry_GetTimestamp(IntPtr obj)
		{
			return default(DateTime);
		}

		private static extern ulong ovr_ChallengeEntry_GetTimestamp_Native(IntPtr obj);

		public static extern IntPtr ovr_ChallengeEntry_GetUser(IntPtr obj);

		public static extern IntPtr ovr_ChallengeEntryArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_ChallengeEntryArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ChallengeEntryArray_GetNextUrl_Native(IntPtr obj);

		public static string ovr_ChallengeEntryArray_GetPreviousUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ChallengeEntryArray_GetPreviousUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_ChallengeEntryArray_GetSize(IntPtr obj);

		public static extern ulong ovr_ChallengeEntryArray_GetTotalCount(IntPtr obj);

		public static extern bool ovr_ChallengeEntryArray_HasNextPage(IntPtr obj);

		public static extern bool ovr_ChallengeEntryArray_HasPreviousPage(IntPtr obj);

		public static string ovr_CloudStorage2UserDirectoryPathResponse_GetPath(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorage2UserDirectoryPathResponse_GetPath_Native(IntPtr obj);

		public static extern IntPtr ovr_CloudStorageConflictMetadata_GetLocal(IntPtr obj);

		public static extern IntPtr ovr_CloudStorageConflictMetadata_GetRemote(IntPtr obj);

		public static string ovr_CloudStorageData_GetBucket(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageData_GetBucket_Native(IntPtr obj);

		public static byte[] ovr_CloudStorageData_GetData(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageData_GetData_Native(IntPtr obj);

		public static extern uint ovr_CloudStorageData_GetDataSize(IntPtr obj);

		public static string ovr_CloudStorageData_GetKey(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageData_GetKey_Native(IntPtr obj);

		public static string ovr_CloudStorageMetadata_GetBucket(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageMetadata_GetBucket_Native(IntPtr obj);

		public static extern long ovr_CloudStorageMetadata_GetCounter(IntPtr obj);

		public static extern uint ovr_CloudStorageMetadata_GetDataSize(IntPtr obj);

		public static string ovr_CloudStorageMetadata_GetExtraData(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageMetadata_GetExtraData_Native(IntPtr obj);

		public static string ovr_CloudStorageMetadata_GetKey(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageMetadata_GetKey_Native(IntPtr obj);

		public static extern ulong ovr_CloudStorageMetadata_GetSaveTime(IntPtr obj);

		public static extern CloudStorageDataStatus ovr_CloudStorageMetadata_GetStatus(IntPtr obj);

		public static string ovr_CloudStorageMetadata_GetVersionHandle(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageMetadata_GetVersionHandle_Native(IntPtr obj);

		public static extern IntPtr ovr_CloudStorageMetadataArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_CloudStorageMetadataArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageMetadataArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_CloudStorageMetadataArray_GetSize(IntPtr obj);

		public static extern bool ovr_CloudStorageMetadataArray_HasNextPage(IntPtr obj);

		public static string ovr_CloudStorageUpdateResponse_GetBucket(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageUpdateResponse_GetBucket_Native(IntPtr obj);

		public static string ovr_CloudStorageUpdateResponse_GetKey(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageUpdateResponse_GetKey_Native(IntPtr obj);

		public static extern CloudStorageUpdateStatus ovr_CloudStorageUpdateResponse_GetStatus(IntPtr obj);

		public static string ovr_CloudStorageUpdateResponse_GetVersionHandle(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_CloudStorageUpdateResponse_GetVersionHandle_Native(IntPtr obj);

		public static uint ovr_DataStore_Contains(IntPtr obj, string key)
		{
			return default(uint);
		}

		private static extern uint ovr_DataStore_Contains_Native(IntPtr obj, IntPtr key);

		public static string ovr_DataStore_GetKey(IntPtr obj, int index)
		{
			return null;
		}

		private static extern IntPtr ovr_DataStore_GetKey_Native(IntPtr obj, int index);

		public static extern UIntPtr ovr_DataStore_GetNumKeys(IntPtr obj);

		public static string ovr_DataStore_GetValue(IntPtr obj, string key)
		{
			return null;
		}

		private static extern IntPtr ovr_DataStore_GetValue_Native(IntPtr obj, IntPtr key);

		public static string ovr_Destination_GetApiName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Destination_GetApiName_Native(IntPtr obj);

		public static string ovr_Destination_GetDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Destination_GetDeeplinkMessage_Native(IntPtr obj);

		public static string ovr_Destination_GetDisplayName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Destination_GetDisplayName_Native(IntPtr obj);

		public static extern IntPtr ovr_DestinationArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_DestinationArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_DestinationArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_DestinationArray_GetSize(IntPtr obj);

		public static extern bool ovr_DestinationArray_HasNextPage(IntPtr obj);

		public static extern int ovr_Error_GetCode(IntPtr obj);

		public static string ovr_Error_GetDisplayableMessage(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Error_GetDisplayableMessage_Native(IntPtr obj);

		public static extern int ovr_Error_GetHttpCode(IntPtr obj);

		public static string ovr_Error_GetMessage(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Error_GetMessage_Native(IntPtr obj);

		public static string ovr_GroupPresenceJoinIntent_GetDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_GroupPresenceJoinIntent_GetDeeplinkMessage_Native(IntPtr obj);

		public static string ovr_GroupPresenceJoinIntent_GetDestinationApiName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_GroupPresenceJoinIntent_GetDestinationApiName_Native(IntPtr obj);

		public static string ovr_GroupPresenceJoinIntent_GetLobbySessionId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_GroupPresenceJoinIntent_GetLobbySessionId_Native(IntPtr obj);

		public static string ovr_GroupPresenceJoinIntent_GetMatchSessionId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_GroupPresenceJoinIntent_GetMatchSessionId_Native(IntPtr obj);

		public static string ovr_GroupPresenceLeaveIntent_GetDestinationApiName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_GroupPresenceLeaveIntent_GetDestinationApiName_Native(IntPtr obj);

		public static string ovr_GroupPresenceLeaveIntent_GetLobbySessionId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_GroupPresenceLeaveIntent_GetLobbySessionId_Native(IntPtr obj);

		public static string ovr_GroupPresenceLeaveIntent_GetMatchSessionId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_GroupPresenceLeaveIntent_GetMatchSessionId_Native(IntPtr obj);

		public static extern IntPtr ovr_HttpTransferUpdate_GetBytes(IntPtr obj);

		public static extern ulong ovr_HttpTransferUpdate_GetID(IntPtr obj);

		public static extern UIntPtr ovr_HttpTransferUpdate_GetSize(IntPtr obj);

		public static extern bool ovr_HttpTransferUpdate_IsCompleted(IntPtr obj);

		public static string ovr_InstalledApplication_GetApplicationId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_InstalledApplication_GetApplicationId_Native(IntPtr obj);

		public static string ovr_InstalledApplication_GetPackageName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_InstalledApplication_GetPackageName_Native(IntPtr obj);

		public static string ovr_InstalledApplication_GetStatus(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_InstalledApplication_GetStatus_Native(IntPtr obj);

		public static extern int ovr_InstalledApplication_GetVersionCode(IntPtr obj);

		public static string ovr_InstalledApplication_GetVersionName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_InstalledApplication_GetVersionName_Native(IntPtr obj);

		public static extern IntPtr ovr_InstalledApplicationArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_InstalledApplicationArray_GetSize(IntPtr obj);

		public static extern bool ovr_InvitePanelResultInfo_GetInvitesSent(IntPtr obj);

		public static string ovr_LanguagePackInfo_GetEnglishName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LanguagePackInfo_GetEnglishName_Native(IntPtr obj);

		public static string ovr_LanguagePackInfo_GetNativeName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LanguagePackInfo_GetNativeName_Native(IntPtr obj);

		public static string ovr_LanguagePackInfo_GetTag(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LanguagePackInfo_GetTag_Native(IntPtr obj);

		public static extern bool ovr_LaunchBlockFlowResult_GetDidBlock(IntPtr obj);

		public static extern bool ovr_LaunchBlockFlowResult_GetDidCancel(IntPtr obj);

		public static string ovr_LaunchDetails_GetDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LaunchDetails_GetDeeplinkMessage_Native(IntPtr obj);

		public static string ovr_LaunchDetails_GetDestinationApiName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LaunchDetails_GetDestinationApiName_Native(IntPtr obj);

		public static string ovr_LaunchDetails_GetLaunchSource(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LaunchDetails_GetLaunchSource_Native(IntPtr obj);

		public static extern LaunchType ovr_LaunchDetails_GetLaunchType(IntPtr obj);

		public static extern ulong ovr_LaunchDetails_GetRoomID(IntPtr obj);

		public static string ovr_LaunchDetails_GetTrackingID(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LaunchDetails_GetTrackingID_Native(IntPtr obj);

		public static extern IntPtr ovr_LaunchDetails_GetUsers(IntPtr obj);

		public static extern bool ovr_LaunchFriendRequestFlowResult_GetDidCancel(IntPtr obj);

		public static extern bool ovr_LaunchFriendRequestFlowResult_GetDidSendRequest(IntPtr obj);

		public static extern IntPtr ovr_LaunchInvitePanelFlowResult_GetInvitedUsers(IntPtr obj);

		public static extern bool ovr_LaunchReportFlowResult_GetDidCancel(IntPtr obj);

		public static extern ulong ovr_LaunchReportFlowResult_GetUserReportId(IntPtr obj);

		public static extern bool ovr_LaunchUnblockFlowResult_GetDidCancel(IntPtr obj);

		public static extern bool ovr_LaunchUnblockFlowResult_GetDidUnblock(IntPtr obj);

		public static string ovr_Leaderboard_GetApiName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Leaderboard_GetApiName_Native(IntPtr obj);

		public static extern IntPtr ovr_Leaderboard_GetDestination(IntPtr obj);

		public static extern ulong ovr_Leaderboard_GetID(IntPtr obj);

		public static extern IntPtr ovr_LeaderboardArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_LeaderboardArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LeaderboardArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_LeaderboardArray_GetSize(IntPtr obj);

		public static extern bool ovr_LeaderboardArray_HasNextPage(IntPtr obj);

		public static string ovr_LeaderboardEntry_GetDisplayScore(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LeaderboardEntry_GetDisplayScore_Native(IntPtr obj);

		public static byte[] ovr_LeaderboardEntry_GetExtraData(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LeaderboardEntry_GetExtraData_Native(IntPtr obj);

		public static extern uint ovr_LeaderboardEntry_GetExtraDataLength(IntPtr obj);

		public static extern ulong ovr_LeaderboardEntry_GetID(IntPtr obj);

		public static extern int ovr_LeaderboardEntry_GetRank(IntPtr obj);

		public static extern long ovr_LeaderboardEntry_GetScore(IntPtr obj);

		public static extern IntPtr ovr_LeaderboardEntry_GetSupplementaryMetric(IntPtr obj);

		public static DateTime ovr_LeaderboardEntry_GetTimestamp(IntPtr obj)
		{
			return default(DateTime);
		}

		private static extern ulong ovr_LeaderboardEntry_GetTimestamp_Native(IntPtr obj);

		public static extern IntPtr ovr_LeaderboardEntry_GetUser(IntPtr obj);

		public static extern IntPtr ovr_LeaderboardEntryArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_LeaderboardEntryArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LeaderboardEntryArray_GetNextUrl_Native(IntPtr obj);

		public static string ovr_LeaderboardEntryArray_GetPreviousUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LeaderboardEntryArray_GetPreviousUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_LeaderboardEntryArray_GetSize(IntPtr obj);

		public static extern ulong ovr_LeaderboardEntryArray_GetTotalCount(IntPtr obj);

		public static extern bool ovr_LeaderboardEntryArray_HasNextPage(IntPtr obj);

		public static extern bool ovr_LeaderboardEntryArray_HasPreviousPage(IntPtr obj);

		public static extern bool ovr_LeaderboardUpdateStatus_GetDidUpdate(IntPtr obj);

		public static extern ulong ovr_LeaderboardUpdateStatus_GetUpdatedChallengeId(IntPtr obj, uint index);

		public static extern uint ovr_LeaderboardUpdateStatus_GetUpdatedChallengeIdsSize(IntPtr obj);

		public static string ovr_LinkedAccount_GetAccessToken(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LinkedAccount_GetAccessToken_Native(IntPtr obj);

		public static extern ServiceProvider ovr_LinkedAccount_GetServiceProvider(IntPtr obj);

		public static string ovr_LinkedAccount_GetUserId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LinkedAccount_GetUserId_Native(IntPtr obj);

		public static extern IntPtr ovr_LinkedAccountArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_LinkedAccountArray_GetSize(IntPtr obj);

		public static extern bool ovr_LivestreamingApplicationStatus_GetStreamingEnabled(IntPtr obj);

		public static extern LivestreamingStartStatus ovr_LivestreamingStartResult_GetStreamingResult(IntPtr obj);

		public static extern bool ovr_LivestreamingStatus_GetCommentsVisible(IntPtr obj);

		public static extern bool ovr_LivestreamingStatus_GetIsPaused(IntPtr obj);

		public static extern bool ovr_LivestreamingStatus_GetLivestreamingEnabled(IntPtr obj);

		public static extern int ovr_LivestreamingStatus_GetLivestreamingType(IntPtr obj);

		public static extern bool ovr_LivestreamingStatus_GetMicEnabled(IntPtr obj);

		public static extern int ovr_LivestreamingVideoStats_GetCommentCount(IntPtr obj);

		public static extern int ovr_LivestreamingVideoStats_GetReactionCount(IntPtr obj);

		public static string ovr_LivestreamingVideoStats_GetTotalViews(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_LivestreamingVideoStats_GetTotalViews_Native(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingAdminSnapshot_GetCandidates(IntPtr obj);

		public static extern double ovr_MatchmakingAdminSnapshot_GetMyCurrentThreshold(IntPtr obj);

		public static extern bool ovr_MatchmakingAdminSnapshotCandidate_GetCanMatch(IntPtr obj);

		public static extern double ovr_MatchmakingAdminSnapshotCandidate_GetMyTotalScore(IntPtr obj);

		public static extern double ovr_MatchmakingAdminSnapshotCandidate_GetTheirCurrentThreshold(IntPtr obj);

		public static extern double ovr_MatchmakingAdminSnapshotCandidate_GetTheirTotalScore(IntPtr obj);

		public static string ovr_MatchmakingAdminSnapshotCandidate_GetTraceId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_MatchmakingAdminSnapshotCandidate_GetTraceId_Native(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingAdminSnapshotCandidateArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_MatchmakingAdminSnapshotCandidateArray_GetSize(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingBrowseResult_GetEnqueueResult(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingBrowseResult_GetRooms(IntPtr obj);

		public static string ovr_MatchmakingCandidate_GetEntryHash(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_MatchmakingCandidate_GetEntryHash_Native(IntPtr obj);

		public static extern ulong ovr_MatchmakingCandidate_GetUserId(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingCandidateArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_MatchmakingCandidateArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_MatchmakingCandidateArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_MatchmakingCandidateArray_GetSize(IntPtr obj);

		public static extern bool ovr_MatchmakingCandidateArray_HasNextPage(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingEnqueueResult_GetAdminSnapshot(IntPtr obj);

		public static extern uint ovr_MatchmakingEnqueueResult_GetAverageWait(IntPtr obj);

		public static extern uint ovr_MatchmakingEnqueueResult_GetMatchesInLastHourCount(IntPtr obj);

		public static extern uint ovr_MatchmakingEnqueueResult_GetMaxExpectedWait(IntPtr obj);

		public static string ovr_MatchmakingEnqueueResult_GetPool(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_MatchmakingEnqueueResult_GetPool_Native(IntPtr obj);

		public static extern uint ovr_MatchmakingEnqueueResult_GetRecentMatchPercentage(IntPtr obj);

		public static string ovr_MatchmakingEnqueueResult_GetRequestHash(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_MatchmakingEnqueueResult_GetRequestHash_Native(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingEnqueueResultAndRoom_GetMatchmakingEnqueueResult(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingEnqueueResultAndRoom_GetRoom(IntPtr obj);

		public static extern ulong ovr_MatchmakingEnqueuedUser_GetAdditionalUserID(IntPtr obj, uint index);

		public static extern uint ovr_MatchmakingEnqueuedUser_GetAdditionalUserIDsSize(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingEnqueuedUser_GetCustomData(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingEnqueuedUser_GetUser(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingEnqueuedUserArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_MatchmakingEnqueuedUserArray_GetSize(IntPtr obj);

		public static extern ulong ovr_MatchmakingNotification_GetAddedByUserId(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingNotification_GetRoom(IntPtr obj);

		public static string ovr_MatchmakingNotification_GetTraceId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_MatchmakingNotification_GetTraceId_Native(IntPtr obj);

		public static extern uint ovr_MatchmakingRoom_GetPingTime(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingRoom_GetRoom(IntPtr obj);

		public static extern bool ovr_MatchmakingRoom_HasPingTime(IntPtr obj);

		public static extern IntPtr ovr_MatchmakingRoomArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_MatchmakingRoomArray_GetSize(IntPtr obj);

		public static extern uint ovr_MatchmakingStats_GetDrawCount(IntPtr obj);

		public static extern uint ovr_MatchmakingStats_GetLossCount(IntPtr obj);

		public static extern uint ovr_MatchmakingStats_GetSkillLevel(IntPtr obj);

		public static extern double ovr_MatchmakingStats_GetSkillMean(IntPtr obj);

		public static extern double ovr_MatchmakingStats_GetSkillStandardDeviation(IntPtr obj);

		public static extern uint ovr_MatchmakingStats_GetWinCount(IntPtr obj);

		public static extern IntPtr ovr_Message_GetAbuseReportRecording(IntPtr obj);

		public static extern IntPtr ovr_Message_GetAchievementDefinitionArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetAchievementProgressArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetAchievementUpdate(IntPtr obj);

		public static extern IntPtr ovr_Message_GetApplicationInviteArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetApplicationVersion(IntPtr obj);

		public static extern IntPtr ovr_Message_GetAssetDetails(IntPtr obj);

		public static extern IntPtr ovr_Message_GetAssetDetailsArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetAssetFileDeleteResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetAssetFileDownloadCancelResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetAssetFileDownloadResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetAssetFileDownloadUpdate(IntPtr obj);

		public static extern IntPtr ovr_Message_GetCalApplicationFinalized(IntPtr obj);

		public static extern IntPtr ovr_Message_GetCalApplicationProposed(IntPtr obj);

		public static extern IntPtr ovr_Message_GetCalApplicationSuggestionArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetChallenge(IntPtr obj);

		public static extern IntPtr ovr_Message_GetChallengeArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetChallengeEntryArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetCloudStorageConflictMetadata(IntPtr obj);

		public static extern IntPtr ovr_Message_GetCloudStorageData(IntPtr obj);

		public static extern IntPtr ovr_Message_GetCloudStorageMetadata(IntPtr obj);

		public static extern IntPtr ovr_Message_GetCloudStorageMetadataArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetCloudStorageUpdateResponse(IntPtr obj);

		public static extern IntPtr ovr_Message_GetDataStore(IntPtr obj);

		public static extern IntPtr ovr_Message_GetDestinationArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetError(IntPtr obj);

		public static extern IntPtr ovr_Message_GetGroupPresenceJoinIntent(IntPtr obj);

		public static extern IntPtr ovr_Message_GetGroupPresenceLeaveIntent(IntPtr obj);

		public static extern IntPtr ovr_Message_GetHttpTransferUpdate(IntPtr obj);

		public static extern IntPtr ovr_Message_GetInstalledApplicationArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetInvitePanelResultInfo(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLaunchBlockFlowResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLaunchFriendRequestFlowResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLaunchInvitePanelFlowResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLaunchReportFlowResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLaunchUnblockFlowResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLeaderboardArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLeaderboardEntryArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLeaderboardUpdateStatus(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLinkedAccountArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLivestreamingApplicationStatus(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLivestreamingStartResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLivestreamingStatus(IntPtr obj);

		public static extern IntPtr ovr_Message_GetLivestreamingVideoStats(IntPtr obj);

		public static extern IntPtr ovr_Message_GetMatchmakingAdminSnapshot(IntPtr obj);

		public static extern IntPtr ovr_Message_GetMatchmakingBrowseResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetMatchmakingEnqueueResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetMatchmakingEnqueueResultAndRoom(IntPtr obj);

		public static extern IntPtr ovr_Message_GetMatchmakingRoomArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetMatchmakingStats(IntPtr obj);

		public static extern IntPtr ovr_Message_GetMicrophoneAvailabilityState(IntPtr obj);

		public static extern IntPtr ovr_Message_GetNativeMessage(IntPtr obj);

		public static extern IntPtr ovr_Message_GetNetSyncConnection(IntPtr obj);

		public static extern IntPtr ovr_Message_GetNetSyncSessionArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetNetSyncSessionsChangedNotification(IntPtr obj);

		public static extern IntPtr ovr_Message_GetNetSyncSetSessionPropertyResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetNetSyncVoipAttenuationValueArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetNetworkingPeer(IntPtr obj);

		public static extern IntPtr ovr_Message_GetOrgScopedID(IntPtr obj);

		public static extern IntPtr ovr_Message_GetParty(IntPtr obj);

		public static extern IntPtr ovr_Message_GetPartyID(IntPtr obj);

		public static extern IntPtr ovr_Message_GetPartyUpdateNotification(IntPtr obj);

		public static extern IntPtr ovr_Message_GetPidArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetPingResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetPlatformInitialize(IntPtr obj);

		public static extern IntPtr ovr_Message_GetProductArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetPurchase(IntPtr obj);

		public static extern IntPtr ovr_Message_GetPurchaseArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetRejoinDialogResult(IntPtr obj);

		public static extern ulong ovr_Message_GetRequestID(IntPtr obj);

		public static extern IntPtr ovr_Message_GetRoom(IntPtr obj);

		public static extern IntPtr ovr_Message_GetRoomArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetRoomInviteNotification(IntPtr obj);

		public static extern IntPtr ovr_Message_GetRoomInviteNotificationArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetSdkAccountArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetSendInvitesResult(IntPtr obj);

		public static extern IntPtr ovr_Message_GetShareMediaResult(IntPtr obj);

		public static string ovr_Message_GetString(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Message_GetString_Native(IntPtr obj);

		public static extern IntPtr ovr_Message_GetSystemVoipState(IntPtr obj);

		public static extern Message.MessageType ovr_Message_GetType(IntPtr obj);

		public static extern IntPtr ovr_Message_GetUser(IntPtr obj);

		public static extern IntPtr ovr_Message_GetUserAndRoomArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetUserArray(IntPtr obj);

		public static extern IntPtr ovr_Message_GetUserDataStoreUpdateResponse(IntPtr obj);

		public static extern IntPtr ovr_Message_GetUserProof(IntPtr obj);

		public static extern IntPtr ovr_Message_GetUserReportID(IntPtr obj);

		public static extern bool ovr_Message_IsError(IntPtr obj);

		public static extern UIntPtr ovr_Microphone_GetNumSamplesAvailable(IntPtr obj);

		public static extern UIntPtr ovr_Microphone_GetOutputBufferMaxSize(IntPtr obj);

		public static extern UIntPtr ovr_Microphone_GetPCM(IntPtr obj, short[] outputBuffer, UIntPtr outputBufferNumElements);

		public static extern UIntPtr ovr_Microphone_GetPCMFloat(IntPtr obj, float[] outputBuffer, UIntPtr outputBufferNumElements);

		public static extern UIntPtr ovr_Microphone_ReadData(IntPtr obj, float[] outputBuffer, UIntPtr outputBufferSize);

		public static extern void ovr_Microphone_SetAcceptableRecordingDelayHint(IntPtr obj, UIntPtr delayMs);

		public static extern void ovr_Microphone_Start(IntPtr obj);

		public static extern void ovr_Microphone_Stop(IntPtr obj);

		public static extern bool ovr_MicrophoneAvailabilityState_GetMicrophoneAvailable(IntPtr obj);

		public static extern long ovr_NetSyncConnection_GetConnectionId(IntPtr obj);

		public static extern NetSyncDisconnectReason ovr_NetSyncConnection_GetDisconnectReason(IntPtr obj);

		public static extern ulong ovr_NetSyncConnection_GetSessionId(IntPtr obj);

		public static extern NetSyncConnectionStatus ovr_NetSyncConnection_GetStatus(IntPtr obj);

		public static string ovr_NetSyncConnection_GetZoneId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_NetSyncConnection_GetZoneId_Native(IntPtr obj);

		public static extern long ovr_NetSyncSession_GetConnectionId(IntPtr obj);

		public static extern bool ovr_NetSyncSession_GetMuted(IntPtr obj);

		public static extern ulong ovr_NetSyncSession_GetSessionId(IntPtr obj);

		public static extern ulong ovr_NetSyncSession_GetUserId(IntPtr obj);

		public static string ovr_NetSyncSession_GetVoipGroup(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_NetSyncSession_GetVoipGroup_Native(IntPtr obj);

		public static extern IntPtr ovr_NetSyncSessionArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_NetSyncSessionArray_GetSize(IntPtr obj);

		public static extern long ovr_NetSyncSessionsChangedNotification_GetConnectionId(IntPtr obj);

		public static extern IntPtr ovr_NetSyncSessionsChangedNotification_GetSessions(IntPtr obj);

		public static extern IntPtr ovr_NetSyncSetSessionPropertyResult_GetSession(IntPtr obj);

		public static extern float ovr_NetSyncVoipAttenuationValue_GetDecibels(IntPtr obj);

		public static extern float ovr_NetSyncVoipAttenuationValue_GetDistance(IntPtr obj);

		public static extern IntPtr ovr_NetSyncVoipAttenuationValueArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_NetSyncVoipAttenuationValueArray_GetSize(IntPtr obj);

		public static extern ulong ovr_NetworkingPeer_GetID(IntPtr obj);

		public static extern PeerConnectionState ovr_NetworkingPeer_GetState(IntPtr obj);

		public static extern ulong ovr_OrgScopedID_GetID(IntPtr obj);

		public static extern void ovr_Packet_Free(IntPtr obj);

		public static extern IntPtr ovr_Packet_GetBytes(IntPtr obj);

		public static extern SendPolicy ovr_Packet_GetSendPolicy(IntPtr obj);

		public static extern ulong ovr_Packet_GetSenderID(IntPtr obj);

		public static extern UIntPtr ovr_Packet_GetSize(IntPtr obj);

		public static extern ulong ovr_Party_GetID(IntPtr obj);

		public static extern IntPtr ovr_Party_GetInvitedUsers(IntPtr obj);

		public static extern IntPtr ovr_Party_GetLeader(IntPtr obj);

		public static extern IntPtr ovr_Party_GetRoom(IntPtr obj);

		public static extern IntPtr ovr_Party_GetUsers(IntPtr obj);

		public static extern ulong ovr_PartyID_GetID(IntPtr obj);

		public static extern PartyUpdateAction ovr_PartyUpdateNotification_GetAction(IntPtr obj);

		public static extern ulong ovr_PartyUpdateNotification_GetPartyId(IntPtr obj);

		public static extern ulong ovr_PartyUpdateNotification_GetSenderId(IntPtr obj);

		public static string ovr_PartyUpdateNotification_GetUpdateTimestamp(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_PartyUpdateNotification_GetUpdateTimestamp_Native(IntPtr obj);

		public static string ovr_PartyUpdateNotification_GetUserAlias(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_PartyUpdateNotification_GetUserAlias_Native(IntPtr obj);

		public static extern ulong ovr_PartyUpdateNotification_GetUserId(IntPtr obj);

		public static string ovr_PartyUpdateNotification_GetUserName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_PartyUpdateNotification_GetUserName_Native(IntPtr obj);

		public static string ovr_Pid_GetId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Pid_GetId_Native(IntPtr obj);

		public static extern IntPtr ovr_PidArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_PidArray_GetSize(IntPtr obj);

		public static extern ulong ovr_PingResult_GetID(IntPtr obj);

		public static extern ulong ovr_PingResult_GetPingTimeUsec(IntPtr obj);

		public static extern bool ovr_PingResult_IsTimeout(IntPtr obj);

		public static extern PlatformInitializeResult ovr_PlatformInitialize_GetResult(IntPtr obj);

		public static extern uint ovr_Price_GetAmountInHundredths(IntPtr obj);

		public static string ovr_Price_GetCurrency(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Price_GetCurrency_Native(IntPtr obj);

		public static string ovr_Price_GetFormatted(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Price_GetFormatted_Native(IntPtr obj);

		public static string ovr_Product_GetDescription(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Product_GetDescription_Native(IntPtr obj);

		public static string ovr_Product_GetFormattedPrice(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Product_GetFormattedPrice_Native(IntPtr obj);

		public static string ovr_Product_GetName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Product_GetName_Native(IntPtr obj);

		public static string ovr_Product_GetSKU(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Product_GetSKU_Native(IntPtr obj);

		public static extern IntPtr ovr_ProductArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_ProductArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_ProductArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_ProductArray_GetSize(IntPtr obj);

		public static extern bool ovr_ProductArray_HasNextPage(IntPtr obj);

		public static DateTime ovr_Purchase_GetExpirationTime(IntPtr obj)
		{
			return default(DateTime);
		}

		private static extern ulong ovr_Purchase_GetExpirationTime_Native(IntPtr obj);

		public static DateTime ovr_Purchase_GetGrantTime(IntPtr obj)
		{
			return default(DateTime);
		}

		private static extern ulong ovr_Purchase_GetGrantTime_Native(IntPtr obj);

		public static extern ulong ovr_Purchase_GetPurchaseID(IntPtr obj);

		public static string ovr_Purchase_GetPurchaseStrID(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Purchase_GetPurchaseStrID_Native(IntPtr obj);

		public static string ovr_Purchase_GetSKU(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Purchase_GetSKU_Native(IntPtr obj);

		public static extern IntPtr ovr_PurchaseArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_PurchaseArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_PurchaseArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_PurchaseArray_GetSize(IntPtr obj);

		public static extern bool ovr_PurchaseArray_HasNextPage(IntPtr obj);

		public static extern bool ovr_RejoinDialogResult_GetRejoinSelected(IntPtr obj);

		public static extern ulong ovr_Room_GetApplicationID(IntPtr obj);

		public static extern IntPtr ovr_Room_GetDataStore(IntPtr obj);

		public static string ovr_Room_GetDescription(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Room_GetDescription_Native(IntPtr obj);

		public static extern ulong ovr_Room_GetID(IntPtr obj);

		public static extern IntPtr ovr_Room_GetInvitedUsers(IntPtr obj);

		public static extern bool ovr_Room_GetIsMembershipLocked(IntPtr obj);

		public static extern RoomJoinPolicy ovr_Room_GetJoinPolicy(IntPtr obj);

		public static extern RoomJoinability ovr_Room_GetJoinability(IntPtr obj);

		public static extern IntPtr ovr_Room_GetMatchedUsers(IntPtr obj);

		public static extern uint ovr_Room_GetMaxUsers(IntPtr obj);

		public static string ovr_Room_GetName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Room_GetName_Native(IntPtr obj);

		public static extern IntPtr ovr_Room_GetOwner(IntPtr obj);

		public static extern IntPtr ovr_Room_GetTeams(IntPtr obj);

		public static extern RoomType ovr_Room_GetType(IntPtr obj);

		public static extern IntPtr ovr_Room_GetUsers(IntPtr obj);

		public static extern uint ovr_Room_GetVersion(IntPtr obj);

		public static extern IntPtr ovr_RoomArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_RoomArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_RoomArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_RoomArray_GetSize(IntPtr obj);

		public static extern bool ovr_RoomArray_HasNextPage(IntPtr obj);

		public static extern ulong ovr_RoomInviteNotification_GetID(IntPtr obj);

		public static extern ulong ovr_RoomInviteNotification_GetRoomID(IntPtr obj);

		public static extern ulong ovr_RoomInviteNotification_GetSenderID(IntPtr obj);

		public static DateTime ovr_RoomInviteNotification_GetSentTime(IntPtr obj)
		{
			return default(DateTime);
		}

		private static extern ulong ovr_RoomInviteNotification_GetSentTime_Native(IntPtr obj);

		public static extern IntPtr ovr_RoomInviteNotificationArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_RoomInviteNotificationArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_RoomInviteNotificationArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_RoomInviteNotificationArray_GetSize(IntPtr obj);

		public static extern bool ovr_RoomInviteNotificationArray_HasNextPage(IntPtr obj);

		public static extern SdkAccountType ovr_SdkAccount_GetAccountType(IntPtr obj);

		public static extern ulong ovr_SdkAccount_GetUserId(IntPtr obj);

		public static extern IntPtr ovr_SdkAccountArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_SdkAccountArray_GetSize(IntPtr obj);

		public static extern IntPtr ovr_SendInvitesResult_GetInvites(IntPtr obj);

		public static extern ShareMediaStatus ovr_ShareMediaResult_GetStatus(IntPtr obj);

		public static extern ulong ovr_SupplementaryMetric_GetID(IntPtr obj);

		public static extern long ovr_SupplementaryMetric_GetMetric(IntPtr obj);

		public static extern VoipMuteState ovr_SystemVoipState_GetMicrophoneMuted(IntPtr obj);

		public static extern SystemVoipStatus ovr_SystemVoipState_GetStatus(IntPtr obj);

		public static extern IntPtr ovr_Team_GetAssignedUsers(IntPtr obj);

		public static extern int ovr_Team_GetMaxUsers(IntPtr obj);

		public static extern int ovr_Team_GetMinUsers(IntPtr obj);

		public static string ovr_Team_GetName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_Team_GetName_Native(IntPtr obj);

		public static extern IntPtr ovr_TeamArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_TeamArray_GetSize(IntPtr obj);

		public static string ovr_TestUser_GetAccessToken(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_TestUser_GetAccessToken_Native(IntPtr obj);

		public static extern IntPtr ovr_TestUser_GetAppAccessArray(IntPtr obj);

		public static extern IntPtr ovr_TestUser_GetFbAppAccessArray(IntPtr obj);

		public static string ovr_TestUser_GetFriendAccessToken(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_TestUser_GetFriendAccessToken_Native(IntPtr obj);

		public static extern IntPtr ovr_TestUser_GetFriendAppAccessArray(IntPtr obj);

		public static string ovr_TestUser_GetUserAlias(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_TestUser_GetUserAlias_Native(IntPtr obj);

		public static extern ulong ovr_TestUser_GetUserFbid(IntPtr obj);

		public static extern ulong ovr_TestUser_GetUserId(IntPtr obj);

		public static string ovr_TestUserAppAccess_GetAccessToken(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_TestUserAppAccess_GetAccessToken_Native(IntPtr obj);

		public static extern ulong ovr_TestUserAppAccess_GetAppId(IntPtr obj);

		public static extern ulong ovr_TestUserAppAccess_GetUserId(IntPtr obj);

		public static extern IntPtr ovr_TestUserAppAccessArray_GetElement(IntPtr obj, UIntPtr index);

		public static extern UIntPtr ovr_TestUserAppAccessArray_GetSize(IntPtr obj);

		public static string ovr_User_GetDisplayName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_User_GetDisplayName_Native(IntPtr obj);

		public static extern ulong ovr_User_GetID(IntPtr obj);

		public static string ovr_User_GetImageUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_User_GetImageUrl_Native(IntPtr obj);

		public static string ovr_User_GetInviteToken(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_User_GetInviteToken_Native(IntPtr obj);

		public static string ovr_User_GetOculusID(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_User_GetOculusID_Native(IntPtr obj);

		public static string ovr_User_GetPresence(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_User_GetPresence_Native(IntPtr obj);

		public static string ovr_User_GetPresenceDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_User_GetPresenceDeeplinkMessage_Native(IntPtr obj);

		public static string ovr_User_GetPresenceDestinationApiName(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_User_GetPresenceDestinationApiName_Native(IntPtr obj);

		public static string ovr_User_GetPresenceLobbySessionId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_User_GetPresenceLobbySessionId_Native(IntPtr obj);

		public static string ovr_User_GetPresenceMatchSessionId(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_User_GetPresenceMatchSessionId_Native(IntPtr obj);

		public static extern UserPresenceStatus ovr_User_GetPresenceStatus(IntPtr obj);

		public static string ovr_User_GetSmallImageUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_User_GetSmallImageUrl_Native(IntPtr obj);

		public static extern IntPtr ovr_UserAndRoom_GetRoom(IntPtr obj);

		public static extern IntPtr ovr_UserAndRoom_GetUser(IntPtr obj);

		public static extern IntPtr ovr_UserAndRoomArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_UserAndRoomArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_UserAndRoomArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_UserAndRoomArray_GetSize(IntPtr obj);

		public static extern bool ovr_UserAndRoomArray_HasNextPage(IntPtr obj);

		public static extern IntPtr ovr_UserArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_UserArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_UserArray_GetNextUrl_Native(IntPtr obj);

		public static extern UIntPtr ovr_UserArray_GetSize(IntPtr obj);

		public static extern bool ovr_UserArray_HasNextPage(IntPtr obj);

		public static extern bool ovr_UserDataStoreUpdateResponse_GetSuccess(IntPtr obj);

		public static string ovr_UserProof_GetNonce(IntPtr obj)
		{
			return null;
		}

		private static extern IntPtr ovr_UserProof_GetNonce_Native(IntPtr obj);

		public static extern bool ovr_UserReportID_GetDidCancel(IntPtr obj);

		public static extern ulong ovr_UserReportID_GetID(IntPtr obj);

		public static extern void ovr_VoipDecoder_Decode(IntPtr obj, byte[] compressedData, UIntPtr compressedSize);

		public static extern UIntPtr ovr_VoipDecoder_GetDecodedPCM(IntPtr obj, float[] outputBuffer, UIntPtr outputBufferSize);

		public static extern void ovr_VoipEncoder_AddPCM(IntPtr obj, float[] inputData, uint inputSize);

		public static extern UIntPtr ovr_VoipEncoder_GetCompressedData(IntPtr obj, byte[] outputBuffer, UIntPtr intputSize);

		public static extern UIntPtr ovr_VoipEncoder_GetCompressedDataSize(IntPtr obj);

		public static extern IntPtr ovr_AbuseReportOptions_Create();

		public static extern void ovr_AbuseReportOptions_Destroy(IntPtr handle);

		public static extern void ovr_AbuseReportOptions_SetPreventPeopleChooser(IntPtr handle, bool value);

		public static extern void ovr_AbuseReportOptions_SetReportType(IntPtr handle, AbuseReportType value);

		public static extern IntPtr ovr_AdvancedAbuseReportOptions_Create();

		public static extern void ovr_AdvancedAbuseReportOptions_Destroy(IntPtr handle);

		public static void ovr_AdvancedAbuseReportOptions_SetObjectType(IntPtr handle, string value)
		{
		}

		private static extern void ovr_AdvancedAbuseReportOptions_SetObjectType_Native(IntPtr handle, IntPtr value);

		public static extern void ovr_AdvancedAbuseReportOptions_SetReportType(IntPtr handle, AbuseReportType value);

		public static extern void ovr_AdvancedAbuseReportOptions_SetVideoMode(IntPtr handle, AbuseReportVideoMode value);

		public static extern IntPtr ovr_ApplicationOptions_Create();

		public static extern void ovr_ApplicationOptions_Destroy(IntPtr handle);

		public static void ovr_ApplicationOptions_SetDeeplinkMessage(IntPtr handle, string value)
		{
		}

		private static extern void ovr_ApplicationOptions_SetDeeplinkMessage_Native(IntPtr handle, IntPtr value);

		public static extern IntPtr ovr_ChallengeOptions_Create();

		public static extern void ovr_ChallengeOptions_Destroy(IntPtr handle);

		public static void ovr_ChallengeOptions_SetDescription(IntPtr handle, string value)
		{
		}

		private static extern void ovr_ChallengeOptions_SetDescription_Native(IntPtr handle, IntPtr value);

		public static void ovr_ChallengeOptions_SetEndDate(IntPtr handle, DateTime value)
		{
		}

		private static extern void ovr_ChallengeOptions_SetEndDate_Native(IntPtr handle, ulong value);

		public static extern void ovr_ChallengeOptions_SetIncludeActiveChallenges(IntPtr handle, bool value);

		public static extern void ovr_ChallengeOptions_SetIncludeFutureChallenges(IntPtr handle, bool value);

		public static extern void ovr_ChallengeOptions_SetIncludePastChallenges(IntPtr handle, bool value);

		public static void ovr_ChallengeOptions_SetLeaderboardName(IntPtr handle, string value)
		{
		}

		private static extern void ovr_ChallengeOptions_SetLeaderboardName_Native(IntPtr handle, IntPtr value);

		public static void ovr_ChallengeOptions_SetStartDate(IntPtr handle, DateTime value)
		{
		}

		private static extern void ovr_ChallengeOptions_SetStartDate_Native(IntPtr handle, ulong value);

		public static void ovr_ChallengeOptions_SetTitle(IntPtr handle, string value)
		{
		}

		private static extern void ovr_ChallengeOptions_SetTitle_Native(IntPtr handle, IntPtr value);

		public static extern void ovr_ChallengeOptions_SetViewerFilter(IntPtr handle, ChallengeViewerFilter value);

		public static extern void ovr_ChallengeOptions_SetVisibility(IntPtr handle, ChallengeVisibility value);

		public static extern IntPtr ovr_GroupPresenceOptions_Create();

		public static extern void ovr_GroupPresenceOptions_Destroy(IntPtr handle);

		public static void ovr_GroupPresenceOptions_SetDestinationApiName(IntPtr handle, string value)
		{
		}

		private static extern void ovr_GroupPresenceOptions_SetDestinationApiName_Native(IntPtr handle, IntPtr value);

		public static extern void ovr_GroupPresenceOptions_SetIsJoinable(IntPtr handle, bool value);

		public static void ovr_GroupPresenceOptions_SetLobbySessionId(IntPtr handle, string value)
		{
		}

		private static extern void ovr_GroupPresenceOptions_SetLobbySessionId_Native(IntPtr handle, IntPtr value);

		public static void ovr_GroupPresenceOptions_SetMatchSessionId(IntPtr handle, string value)
		{
		}

		private static extern void ovr_GroupPresenceOptions_SetMatchSessionId_Native(IntPtr handle, IntPtr value);

		public static extern IntPtr ovr_InviteOptions_Create();

		public static extern void ovr_InviteOptions_Destroy(IntPtr handle);

		public static extern void ovr_InviteOptions_AddSuggestedUser(IntPtr handle, ulong value);

		public static extern void ovr_InviteOptions_ClearSuggestedUsers(IntPtr handle);

		public static extern IntPtr ovr_MatchmakingOptions_Create();

		public static extern void ovr_MatchmakingOptions_Destroy(IntPtr handle);

		public static void ovr_MatchmakingOptions_SetCreateRoomDataStoreString(IntPtr handle, string key, string value)
		{
		}

		private static extern void ovr_MatchmakingOptions_SetCreateRoomDataStoreString_Native(IntPtr handle, IntPtr key, IntPtr value);

		public static extern void ovr_MatchmakingOptions_ClearCreateRoomDataStore(IntPtr handle);

		public static extern void ovr_MatchmakingOptions_SetCreateRoomJoinPolicy(IntPtr handle, RoomJoinPolicy value);

		public static extern void ovr_MatchmakingOptions_SetCreateRoomMaxUsers(IntPtr handle, uint value);

		public static extern void ovr_MatchmakingOptions_AddEnqueueAdditionalUser(IntPtr handle, ulong value);

		public static extern void ovr_MatchmakingOptions_ClearEnqueueAdditionalUsers(IntPtr handle);

		public static void ovr_MatchmakingOptions_SetEnqueueDataSettingsInt(IntPtr handle, string key, int value)
		{
		}

		private static extern void ovr_MatchmakingOptions_SetEnqueueDataSettingsInt_Native(IntPtr handle, IntPtr key, int value);

		public static void ovr_MatchmakingOptions_SetEnqueueDataSettingsDouble(IntPtr handle, string key, double value)
		{
		}

		private static extern void ovr_MatchmakingOptions_SetEnqueueDataSettingsDouble_Native(IntPtr handle, IntPtr key, double value);

		public static void ovr_MatchmakingOptions_SetEnqueueDataSettingsString(IntPtr handle, string key, string value)
		{
		}

		private static extern void ovr_MatchmakingOptions_SetEnqueueDataSettingsString_Native(IntPtr handle, IntPtr key, IntPtr value);

		public static extern void ovr_MatchmakingOptions_ClearEnqueueDataSettings(IntPtr handle);

		public static extern void ovr_MatchmakingOptions_SetEnqueueIsDebug(IntPtr handle, bool value);

		public static void ovr_MatchmakingOptions_SetEnqueueQueryKey(IntPtr handle, string value)
		{
		}

		private static extern void ovr_MatchmakingOptions_SetEnqueueQueryKey_Native(IntPtr handle, IntPtr value);

		public static extern IntPtr ovr_MultiplayerErrorOptions_Create();

		public static extern void ovr_MultiplayerErrorOptions_Destroy(IntPtr handle);

		public static extern void ovr_MultiplayerErrorOptions_SetErrorKey(IntPtr handle, MultiplayerErrorErrorKey value);

		public static extern IntPtr ovr_NetSyncOptions_Create();

		public static extern void ovr_NetSyncOptions_Destroy(IntPtr handle);

		public static void ovr_NetSyncOptions_SetVoipGroup(IntPtr handle, string value)
		{
		}

		private static extern void ovr_NetSyncOptions_SetVoipGroup_Native(IntPtr handle, IntPtr value);

		public static extern void ovr_NetSyncOptions_SetVoipStreamDefault(IntPtr handle, NetSyncVoipStreamMode value);

		public static void ovr_NetSyncOptions_SetZoneId(IntPtr handle, string value)
		{
		}

		private static extern void ovr_NetSyncOptions_SetZoneId_Native(IntPtr handle, IntPtr value);

		public static extern IntPtr ovr_RichPresenceOptions_Create();

		public static extern void ovr_RichPresenceOptions_Destroy(IntPtr handle);

		public static void ovr_RichPresenceOptions_SetApiName(IntPtr handle, string value)
		{
		}

		private static extern void ovr_RichPresenceOptions_SetApiName_Native(IntPtr handle, IntPtr value);

		public static void ovr_RichPresenceOptions_SetArgsString(IntPtr handle, string key, string value)
		{
		}

		private static extern void ovr_RichPresenceOptions_SetArgsString_Native(IntPtr handle, IntPtr key, IntPtr value);

		public static extern void ovr_RichPresenceOptions_ClearArgs(IntPtr handle);

		public static extern void ovr_RichPresenceOptions_SetCurrentCapacity(IntPtr handle, uint value);

		public static void ovr_RichPresenceOptions_SetDeeplinkMessageOverride(IntPtr handle, string value)
		{
		}

		private static extern void ovr_RichPresenceOptions_SetDeeplinkMessageOverride_Native(IntPtr handle, IntPtr value);

		public static void ovr_RichPresenceOptions_SetEndTime(IntPtr handle, DateTime value)
		{
		}

		private static extern void ovr_RichPresenceOptions_SetEndTime_Native(IntPtr handle, ulong value);

		public static extern void ovr_RichPresenceOptions_SetExtraContext(IntPtr handle, RichPresenceExtraContext value);

		public static void ovr_RichPresenceOptions_SetInstanceId(IntPtr handle, string value)
		{
		}

		private static extern void ovr_RichPresenceOptions_SetInstanceId_Native(IntPtr handle, IntPtr value);

		public static extern void ovr_RichPresenceOptions_SetIsIdle(IntPtr handle, bool value);

		public static extern void ovr_RichPresenceOptions_SetIsJoinable(IntPtr handle, bool value);

		public static void ovr_RichPresenceOptions_SetJoinableId(IntPtr handle, string value)
		{
		}

		private static extern void ovr_RichPresenceOptions_SetJoinableId_Native(IntPtr handle, IntPtr value);

		public static void ovr_RichPresenceOptions_SetLobbySessionId(IntPtr handle, string value)
		{
		}

		private static extern void ovr_RichPresenceOptions_SetLobbySessionId_Native(IntPtr handle, IntPtr value);

		public static void ovr_RichPresenceOptions_SetMatchSessionId(IntPtr handle, string value)
		{
		}

		private static extern void ovr_RichPresenceOptions_SetMatchSessionId_Native(IntPtr handle, IntPtr value);

		public static extern void ovr_RichPresenceOptions_SetMaxCapacity(IntPtr handle, uint value);

		public static void ovr_RichPresenceOptions_SetStartTime(IntPtr handle, DateTime value)
		{
		}

		private static extern void ovr_RichPresenceOptions_SetStartTime_Native(IntPtr handle, ulong value);

		public static extern IntPtr ovr_RoomOptions_Create();

		public static extern void ovr_RoomOptions_Destroy(IntPtr handle);

		public static void ovr_RoomOptions_SetDataStoreString(IntPtr handle, string key, string value)
		{
		}

		private static extern void ovr_RoomOptions_SetDataStoreString_Native(IntPtr handle, IntPtr key, IntPtr value);

		public static extern void ovr_RoomOptions_ClearDataStore(IntPtr handle);

		public static extern void ovr_RoomOptions_SetExcludeRecentlyMet(IntPtr handle, bool value);

		public static extern void ovr_RoomOptions_SetMaxUserResults(IntPtr handle, uint value);

		public static extern void ovr_RoomOptions_SetOrdering(IntPtr handle, UserOrdering value);

		public static extern void ovr_RoomOptions_SetRecentlyMetTimeWindow(IntPtr handle, TimeWindow value);

		public static extern void ovr_RoomOptions_SetRoomId(IntPtr handle, ulong value);

		public static extern void ovr_RoomOptions_SetTurnOffUpdates(IntPtr handle, bool value);

		public static extern IntPtr ovr_RosterOptions_Create();

		public static extern void ovr_RosterOptions_Destroy(IntPtr handle);

		public static extern void ovr_RosterOptions_AddSuggestedUser(IntPtr handle, ulong value);

		public static extern void ovr_RosterOptions_ClearSuggestedUsers(IntPtr handle);

		public static extern IntPtr ovr_UserOptions_Create();

		public static extern void ovr_UserOptions_Destroy(IntPtr handle);

		public static extern void ovr_UserOptions_SetMaxUsers(IntPtr handle, uint value);

		public static extern void ovr_UserOptions_AddServiceProvider(IntPtr handle, ServiceProvider value);

		public static extern void ovr_UserOptions_ClearServiceProviders(IntPtr handle);

		public static extern void ovr_UserOptions_SetTimeWindow(IntPtr handle, TimeWindow value);

		public static extern IntPtr ovr_VoipOptions_Create();

		public static extern void ovr_VoipOptions_Destroy(IntPtr handle);

		public static extern void ovr_VoipOptions_SetBitrateForNewConnections(IntPtr handle, VoipBitrate value);

		public static extern void ovr_VoipOptions_SetCreateNewConnectionUseDtx(IntPtr handle, VoipDtxState value);

		public CAPI()
			: base()
		{
		}
	}
}
