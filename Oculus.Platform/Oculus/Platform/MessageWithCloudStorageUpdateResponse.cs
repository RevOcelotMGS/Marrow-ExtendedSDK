using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCloudStorageUpdateResponse : Message<CloudStorageUpdateResponse>
	{
		public MessageWithCloudStorageUpdateResponse(IntPtr c_message)
			: base(c_message)
		{
		}

		public override CloudStorageUpdateResponse GetCloudStorageUpdateResponse()
		{
			return null;
		}

		protected override CloudStorageUpdateResponse GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
