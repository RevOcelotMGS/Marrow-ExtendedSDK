using System;

namespace Oculus.Platform.Models
{
	public class CloudStorageUpdateResponse
	{
		public readonly string Bucket;

		public readonly string Key;

		public readonly CloudStorageUpdateStatus Status;

		public readonly string VersionHandle;

		public CloudStorageUpdateResponse(IntPtr o)
			: base()
		{
		}
	}
}
