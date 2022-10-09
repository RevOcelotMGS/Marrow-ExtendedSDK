using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithPingResult : Message<PingResult>
	{
		public MessageWithPingResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override PingResult GetPingResult()
		{
			return null;
		}

		protected override PingResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
