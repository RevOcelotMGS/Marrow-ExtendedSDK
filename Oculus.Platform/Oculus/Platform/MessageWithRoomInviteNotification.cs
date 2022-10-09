using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithRoomInviteNotification : Message<RoomInviteNotification>
	{
		public MessageWithRoomInviteNotification(IntPtr c_message)
			: base(c_message)
		{
		}

		public override RoomInviteNotification GetRoomInviteNotification()
		{
			return null;
		}

		protected override RoomInviteNotification GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
