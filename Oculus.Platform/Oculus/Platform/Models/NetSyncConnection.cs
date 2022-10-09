using System;

namespace Oculus.Platform.Models
{
	public class NetSyncConnection
	{
		public readonly long ConnectionId;

		public readonly NetSyncDisconnectReason DisconnectReason;

		public readonly ulong SessionId;

		public readonly NetSyncConnectionStatus Status;

		public readonly string ZoneId;

		public NetSyncConnection(IntPtr o)
			: base()
		{
		}
	}
}
