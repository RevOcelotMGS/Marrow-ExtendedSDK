using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithNetSyncSessionsChangedNotification : Message<NetSyncSessionsChangedNotification>
	{
		public MessageWithNetSyncSessionsChangedNotification(IntPtr c_message)
			: base(c_message)
		{
		}

		public override NetSyncSessionsChangedNotification GetNetSyncSessionsChangedNotification()
		{
			return null;
		}

		protected override NetSyncSessionsChangedNotification GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
