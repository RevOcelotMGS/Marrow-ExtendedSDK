using System;

namespace Oculus.Platform.Models
{
	public class AssetDetails
	{
		public readonly ulong AssetId;

		public readonly string AssetType;

		public readonly string DownloadStatus;

		public readonly string Filepath;

		public readonly string IapStatus;

		public readonly LanguagePackInfo LanguageOptional;

		[Obsolete("Deprecated in favor of LanguageOptional")]
		public readonly LanguagePackInfo Language;

		public readonly string Metadata;

		public AssetDetails(IntPtr o)
			: base()
		{
		}
	}
}
