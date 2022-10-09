using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithNetSyncSetSessionPropertyResult : Message<NetSyncSetSessionPropertyResult>
	{
		public MessageWithNetSyncSetSessionPropertyResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override NetSyncSetSessionPropertyResult GetNetSyncSetSessionPropertyResult()
		{
			return null;
		}

		protected override NetSyncSetSessionPropertyResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
