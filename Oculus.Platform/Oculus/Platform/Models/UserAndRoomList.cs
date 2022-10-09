using System;

namespace Oculus.Platform.Models
{
	public class UserAndRoomList : DeserializableList<UserAndRoom>
	{
		public UserAndRoomList(IntPtr a)
			: base()
		{
		}
	}
}
