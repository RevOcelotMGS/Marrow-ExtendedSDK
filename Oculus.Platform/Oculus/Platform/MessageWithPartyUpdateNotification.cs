using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithPartyUpdateNotification : Message<PartyUpdateNotification>
	{
		public MessageWithPartyUpdateNotification(IntPtr c_message)
			: base(c_message)
		{
		}

		public override PartyUpdateNotification GetPartyUpdateNotification()
		{
			return null;
		}

		protected override PartyUpdateNotification GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
