using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithPartyID : Message<PartyID>
	{
		public MessageWithPartyID(IntPtr c_message)
			: base(c_message)
		{
		}

		public override PartyID GetPartyID()
		{
			return null;
		}

		protected override PartyID GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
