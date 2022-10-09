using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithChallengeEntryList : Message<ChallengeEntryList>
	{
		public MessageWithChallengeEntryList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override ChallengeEntryList GetChallengeEntryList()
		{
			return null;
		}

		protected override ChallengeEntryList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
