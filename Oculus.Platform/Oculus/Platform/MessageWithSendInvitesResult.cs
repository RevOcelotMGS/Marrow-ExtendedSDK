using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithSendInvitesResult : Message<SendInvitesResult>
	{
		public MessageWithSendInvitesResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override SendInvitesResult GetSendInvitesResult()
		{
			return null;
		}

		protected override SendInvitesResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
