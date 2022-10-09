using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCloudStorageMetadataUnderLocal : Message<CloudStorageMetadata>
	{
		public MessageWithCloudStorageMetadataUnderLocal(IntPtr c_message)
			: base(c_message)
		{
		}

		public override CloudStorageMetadata GetCloudStorageMetadata()
		{
			return null;
		}

		protected override CloudStorageMetadata GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
