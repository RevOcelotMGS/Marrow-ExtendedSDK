using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLinkedAccountList : Message<LinkedAccountList>
	{
		public MessageWithLinkedAccountList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override LinkedAccountList GetLinkedAccountList()
		{
			return null;
		}

		protected override LinkedAccountList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
