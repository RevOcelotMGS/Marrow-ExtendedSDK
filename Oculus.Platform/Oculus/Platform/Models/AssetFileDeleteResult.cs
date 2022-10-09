using System;

namespace Oculus.Platform.Models
{
	public class AssetFileDeleteResult
	{
		public readonly ulong AssetFileId;

		public readonly ulong AssetId;

		public readonly string Filepath;

		public readonly bool Success;

		public AssetFileDeleteResult(IntPtr o)
			: base()
		{
		}
	}
}
