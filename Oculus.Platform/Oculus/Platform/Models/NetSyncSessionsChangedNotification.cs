using System;

namespace Oculus.Platform.Models
{
	public class NetSyncSessionsChangedNotification
	{
		public readonly long ConnectionId;

		public readonly NetSyncSessionList Sessions;

		public NetSyncSessionsChangedNotification(IntPtr o)
			: base()
		{
		}
	}
}
