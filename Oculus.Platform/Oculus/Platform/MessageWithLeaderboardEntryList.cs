using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLeaderboardEntryList : Message<LeaderboardEntryList>
	{
		public MessageWithLeaderboardEntryList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override LeaderboardEntryList GetLeaderboardEntryList()
		{
			return null;
		}

		protected override LeaderboardEntryList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
