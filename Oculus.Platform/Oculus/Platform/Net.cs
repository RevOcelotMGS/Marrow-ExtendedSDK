using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Net
	{
		public static Packet ReadPacket()
		{
			return null;
		}

		public static bool SendPacket(ulong userID, byte[] bytes, SendPolicy policy)
		{
			return default(bool);
		}

		public static void Connect(ulong userID)
		{
		}

		public static void Accept(ulong userID)
		{
		}

		public static void Close(ulong userID)
		{
		}

		public static bool IsConnected(ulong userID)
		{
			return default(bool);
		}

		public static bool SendPacketToCurrentRoom(byte[] bytes, SendPolicy policy)
		{
			return default(bool);
		}

		public static bool AcceptForCurrentRoom()
		{
			return default(bool);
		}

		public static void CloseForCurrentRoom()
		{
		}

		public static Request<PingResult> Ping(ulong userID)
		{
			return null;
		}

		public static void SetConnectionStateChangedCallback(Message<NetworkingPeer>.Callback callback)
		{
		}

		public static void SetPeerConnectRequestCallback(Message<NetworkingPeer>.Callback callback)
		{
		}

		public static void SetPingResultNotificationCallback(Message<PingResult>.Callback callback)
		{
		}
	}
}
