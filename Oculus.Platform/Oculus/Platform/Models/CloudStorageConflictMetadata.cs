using System;

namespace Oculus.Platform.Models
{
	public class CloudStorageConflictMetadata
	{
		public readonly CloudStorageMetadata Local;

		public readonly CloudStorageMetadata Remote;

		public CloudStorageConflictMetadata(IntPtr o)
			: base()
		{
		}
	}
}
