using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCloudStorageData : Message<CloudStorageData>
	{
		public MessageWithCloudStorageData(IntPtr c_message)
			: base(c_message)
		{
		}

		public override CloudStorageData GetCloudStorageData()
		{
			return null;
		}

		protected override CloudStorageData GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
