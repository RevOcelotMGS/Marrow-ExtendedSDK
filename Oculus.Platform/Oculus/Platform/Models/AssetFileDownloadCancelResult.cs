using System;

namespace Oculus.Platform.Models
{
	public class AssetFileDownloadCancelResult
	{
		public readonly ulong AssetFileId;

		public readonly ulong AssetId;

		public readonly string Filepath;

		public readonly bool Success;

		public AssetFileDownloadCancelResult(IntPtr o)
			: base()
		{
		}
	}
}
