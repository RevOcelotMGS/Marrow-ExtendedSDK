using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithMatchmakingNotification : Message<Room>
	{
		public MessageWithMatchmakingNotification(IntPtr c_message)
			: base(c_message)
		{
		}

		public override Room GetRoom()
		{
			return null;
		}

		protected override Room GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
