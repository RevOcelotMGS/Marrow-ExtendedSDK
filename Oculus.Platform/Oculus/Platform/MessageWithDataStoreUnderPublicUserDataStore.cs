using System;
using System.Collections.Generic;

namespace Oculus.Platform
{
	public class MessageWithDataStoreUnderPublicUserDataStore : Message<Dictionary<string, string>>
	{
		public MessageWithDataStoreUnderPublicUserDataStore(IntPtr c_message)
			: base(c_message)
		{
		}

		public override Dictionary<string, string> GetDataStore()
		{
			return null;
		}

		protected override Dictionary<string, string> GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
