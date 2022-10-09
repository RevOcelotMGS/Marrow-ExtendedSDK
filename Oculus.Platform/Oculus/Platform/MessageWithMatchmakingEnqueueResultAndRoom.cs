using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithMatchmakingEnqueueResultAndRoom : Message<MatchmakingEnqueueResultAndRoom>
	{
		public MessageWithMatchmakingEnqueueResultAndRoom(IntPtr c_message)
			: base(c_message)
		{
		}

		public override MatchmakingEnqueueResultAndRoom GetMatchmakingEnqueueResultAndRoom()
		{
			return null;
		}

		protected override MatchmakingEnqueueResultAndRoom GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
