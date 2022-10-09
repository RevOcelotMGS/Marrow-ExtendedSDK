using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithPidList : Message<PidList>
	{
		public MessageWithPidList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override PidList GetPidList()
		{
			return null;
		}

		protected override PidList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
