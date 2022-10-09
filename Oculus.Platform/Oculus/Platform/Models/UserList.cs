using System;

namespace Oculus.Platform.Models
{
	public class UserList : DeserializableList<User>
	{
		public UserList(IntPtr a)
			: base()
		{
		}
	}
}
