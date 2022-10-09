using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCloudStorageConflictMetadata : Message<CloudStorageConflictMetadata>
	{
		public MessageWithCloudStorageConflictMetadata(IntPtr c_message)
			: base(c_message)
		{
		}

		public override CloudStorageConflictMetadata GetCloudStorageConflictMetadata()
		{
			return null;
		}

		protected override CloudStorageConflictMetadata GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
