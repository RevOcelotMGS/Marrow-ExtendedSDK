using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithRoomUnderViewerRoom : Message<Room>
	{
		public MessageWithRoomUnderViewerRoom(IntPtr c_message)
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
