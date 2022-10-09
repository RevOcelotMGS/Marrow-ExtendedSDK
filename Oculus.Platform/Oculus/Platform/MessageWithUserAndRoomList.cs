using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUserAndRoomList : Message<UserAndRoomList>
	{
		public MessageWithUserAndRoomList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override UserAndRoomList GetUserAndRoomList()
		{
			return null;
		}

		protected override UserAndRoomList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
