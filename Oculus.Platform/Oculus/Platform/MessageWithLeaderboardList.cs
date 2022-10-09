using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLeaderboardList : Message<LeaderboardList>
	{
		public MessageWithLeaderboardList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override LeaderboardList GetLeaderboardList()
		{
			return null;
		}

		protected override LeaderboardList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
