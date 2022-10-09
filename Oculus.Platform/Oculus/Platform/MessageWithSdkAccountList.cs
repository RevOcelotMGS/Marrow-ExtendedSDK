using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithSdkAccountList : Message<SdkAccountList>
	{
		public MessageWithSdkAccountList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override SdkAccountList GetSdkAccountList()
		{
			return null;
		}

		protected override SdkAccountList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
