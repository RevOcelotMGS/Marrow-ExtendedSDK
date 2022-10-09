using System;

namespace Oculus.Platform.Models
{
	public class UserAndRoom
	{
		public readonly Room RoomOptional;

		[Obsolete("Deprecated in favor of RoomOptional")]
		public readonly Room Room;

		public readonly User User;

		public UserAndRoom(IntPtr o)
			: base()
		{
		}
	}
}
