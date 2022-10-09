using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUserList : Message<UserList>
	{
		public MessageWithUserList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override UserList GetUserList()
		{
			return null;
		}

		protected override UserList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
