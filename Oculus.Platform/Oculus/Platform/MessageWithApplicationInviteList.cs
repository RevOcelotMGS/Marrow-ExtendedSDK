using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithApplicationInviteList : Message<ApplicationInviteList>
	{
		public MessageWithApplicationInviteList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override ApplicationInviteList GetApplicationInviteList()
		{
			return null;
		}

		protected override ApplicationInviteList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
