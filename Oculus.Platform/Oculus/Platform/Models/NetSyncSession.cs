using System;

namespace Oculus.Platform.Models
{
	public class NetSyncSession
	{
		public readonly long ConnectionId;

		public readonly bool Muted;

		public readonly ulong SessionId;

		public readonly ulong UserId;

		public readonly string VoipGroup;

		public NetSyncSession(IntPtr o)
			: base()
		{
		}
	}
}
