using System;

namespace Oculus.Platform.Models
{
	public class RoomInviteNotificationList : DeserializableList<RoomInviteNotification>
	{
		public RoomInviteNotificationList(IntPtr a)
			: base()
		{
		}
	}
}
