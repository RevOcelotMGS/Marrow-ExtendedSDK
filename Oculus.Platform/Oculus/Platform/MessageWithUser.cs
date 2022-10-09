using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUser : Message<User>
	{
		public MessageWithUser(IntPtr c_message)
			: base(c_message)
		{
		}

		public override User GetUser()
		{
			return null;
		}

		protected override User GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
