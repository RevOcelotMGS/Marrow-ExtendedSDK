using System;

namespace Oculus.Platform.Models
{
	public class CloudStorageData
	{
		public readonly string Bucket;

		public readonly byte[] Data;

		public readonly uint DataSize;

		public readonly string Key;

		public CloudStorageData(IntPtr o)
			: base()
		{
		}
	}
}
