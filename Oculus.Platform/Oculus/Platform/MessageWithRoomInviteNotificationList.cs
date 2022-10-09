using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithRoomInviteNotificationList : Message<RoomInviteNotificationList>
	{
		public MessageWithRoomInviteNotificationList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override RoomInviteNotificationList GetRoomInviteNotificationList()
		{
			return null;
		}

		protected override RoomInviteNotificationList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
