using System;

namespace Oculus.Platform.Models
{
	public class AssetFileDownloadUpdate
	{
		public readonly ulong AssetFileId;

		public readonly ulong AssetId;

		public readonly ulong BytesTotal;

		public readonly long BytesTransferred;

		public readonly bool Completed;

		public AssetFileDownloadUpdate(IntPtr o)
			: base()
		{
		}
	}
}
