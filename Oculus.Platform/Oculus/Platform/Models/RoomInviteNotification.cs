using System;

namespace Oculus.Platform.Models
{
	public class RoomInviteNotification
	{
		public readonly ulong ID;

		public readonly ulong RoomID;

		public readonly ulong SenderID;

		public readonly DateTime SentTime;

		public RoomInviteNotification(IntPtr o)
			: base()
		{
		}
	}
}
