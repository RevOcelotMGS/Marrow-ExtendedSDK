using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithGroupPresenceLeaveIntent : Message<GroupPresenceLeaveIntent>
	{
		public MessageWithGroupPresenceLeaveIntent(IntPtr c_message)
			: base(c_message)
		{
		}

		public override GroupPresenceLeaveIntent GetGroupPresenceLeaveIntent()
		{
			return null;
		}

		protected override GroupPresenceLeaveIntent GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
