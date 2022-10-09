using System;

namespace Oculus.Platform
{
	public class MessageWithLeaderboardDidUpdate : Message<bool>
	{
		public MessageWithLeaderboardDidUpdate(IntPtr c_message)
			: base(c_message)
		{
		}

		public override bool GetLeaderboardDidUpdate()
		{
			return default(bool);
		}

		protected override bool GetDataFromMessage(IntPtr c_message)
		{
			return default(bool);
		}
	}
}
