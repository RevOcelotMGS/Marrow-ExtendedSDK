using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithMatchmakingBrowseResult : Message<MatchmakingBrowseResult>
	{
		public MessageWithMatchmakingBrowseResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override MatchmakingEnqueueResult GetMatchmakingEnqueueResult()
		{
			return null;
		}

		public override RoomList GetRoomList()
		{
			return null;
		}

		protected override MatchmakingBrowseResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
