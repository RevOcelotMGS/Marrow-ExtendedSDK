using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Voip
	{
		public static void Start(ulong userID)
		{
		}

		public static void Accept(ulong userID)
		{
		}

		public static void Stop(ulong userID)
		{
		}

		public static void SetMicrophoneFilterCallback(CAPI.FilterCallback callback)
		{
		}

		public static void SetMicrophoneMuted(VoipMuteState state)
		{
		}

		public static VoipMuteState GetSystemVoipMicrophoneMuted()
		{
			return default(VoipMuteState);
		}

		public static SystemVoipStatus GetSystemVoipStatus()
		{
			return default(SystemVoipStatus);
		}

		public static VoipDtxState GetIsConnectionUsingDtx(ulong peerID)
		{
			return default(VoipDtxState);
		}

		public static VoipBitrate GetLocalBitrate(ulong peerID)
		{
			return default(VoipBitrate);
		}

		public static VoipBitrate GetRemoteBitrate(ulong peerID)
		{
			return default(VoipBitrate);
		}

		public static void SetNewConnectionOptions(VoipOptions voipOptions)
		{
		}

		public static Request<MicrophoneAvailabilityState> GetMicrophoneAvailability()
		{
			return null;
		}

		public static Request<SystemVoipState> SetSystemVoipSuppressed(bool suppressed)
		{
			return null;
		}

		public static void SetVoipConnectRequestCallback(Message<NetworkingPeer>.Callback callback)
		{
		}

		public static void SetMicrophoneAvailabilityStateUpdateNotificationCallback(Message<string>.Callback callback)
		{
		}

		public static void SetVoipStateChangeCallback(Message<NetworkingPeer>.Callback callback)
		{
		}

		public static void SetSystemVoipStateNotificationCallback(Message<SystemVoipState>.Callback callback)
		{
		}
	}
}
