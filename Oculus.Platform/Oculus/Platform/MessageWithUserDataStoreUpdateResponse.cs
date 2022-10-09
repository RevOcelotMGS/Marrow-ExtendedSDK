using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUserDataStoreUpdateResponse : Message<UserDataStoreUpdateResponse>
	{
		public MessageWithUserDataStoreUpdateResponse(IntPtr c_message)
			: base(c_message)
		{
		}

		public override UserDataStoreUpdateResponse GetUserDataStoreUpdateResponse()
		{
			return null;
		}

		protected override UserDataStoreUpdateResponse GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
