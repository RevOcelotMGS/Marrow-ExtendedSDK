using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithShareMediaResult : Message<ShareMediaResult>
	{
		public MessageWithShareMediaResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override ShareMediaResult GetShareMediaResult()
		{
			return null;
		}

		protected override ShareMediaResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
