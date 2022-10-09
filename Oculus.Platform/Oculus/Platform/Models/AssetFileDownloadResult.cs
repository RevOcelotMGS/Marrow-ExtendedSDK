using System;

namespace Oculus.Platform.Models
{
	public class AssetFileDownloadResult
	{
		public readonly ulong AssetId;

		public readonly string Filepath;

		public AssetFileDownloadResult(IntPtr o)
			: base()
		{
		}
	}
}
