using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCloudStorageMetadataList : Message<CloudStorageMetadataList>
	{
		public MessageWithCloudStorageMetadataList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override CloudStorageMetadataList GetCloudStorageMetadataList()
		{
			return null;
		}

		protected override CloudStorageMetadataList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
