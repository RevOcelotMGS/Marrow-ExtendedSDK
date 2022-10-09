using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithHttpTransferUpdate : Message<HttpTransferUpdate>
	{
		public MessageWithHttpTransferUpdate(IntPtr c_message)
			: base(c_message)
		{
		}

		public override HttpTransferUpdate GetHttpTransferUpdate()
		{
			return null;
		}

		protected override HttpTransferUpdate GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
