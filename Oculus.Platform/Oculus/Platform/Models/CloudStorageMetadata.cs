using System;

namespace Oculus.Platform.Models
{
	public class CloudStorageMetadata
	{
		public readonly string Bucket;

		public readonly long Counter;

		public readonly uint DataSize;

		public readonly string ExtraData;

		public readonly string Key;

		public readonly ulong SaveTime;

		public readonly CloudStorageDataStatus Status;

		public readonly string VersionHandle;

		public CloudStorageMetadata(IntPtr o)
			: base()
		{
		}
	}
}
