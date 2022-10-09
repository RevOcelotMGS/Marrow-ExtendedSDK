using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithMatchmakingAdminSnapshot : Message<MatchmakingAdminSnapshot>
	{
		public MessageWithMatchmakingAdminSnapshot(IntPtr c_message)
			: base(c_message)
		{
		}

		public override MatchmakingAdminSnapshot GetMatchmakingAdminSnapshot()
		{
			return null;
		}

		protected override MatchmakingAdminSnapshot GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
