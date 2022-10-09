using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class AssetFile
	{
		public static Request<AssetFileDeleteResult> Delete(ulong assetFileID)
		{
			return null;
		}

		public static Request<AssetFileDeleteResult> DeleteById(ulong assetFileID)
		{
			return null;
		}

		public static Request<AssetFileDeleteResult> DeleteByName(string assetFileName)
		{
			return null;
		}

		public static Request<AssetFileDownloadResult> Download(ulong assetFileID)
		{
			return null;
		}

		public static Request<AssetFileDownloadResult> DownloadById(ulong assetFileID)
		{
			return null;
		}

		public static Request<AssetFileDownloadResult> DownloadByName(string assetFileName)
		{
			return null;
		}

		public static Request<AssetFileDownloadCancelResult> DownloadCancel(ulong assetFileID)
		{
			return null;
		}

		public static Request<AssetFileDownloadCancelResult> DownloadCancelById(ulong assetFileID)
		{
			return null;
		}

		public static Request<AssetFileDownloadCancelResult> DownloadCancelByName(string assetFileName)
		{
			return null;
		}

		public static Request<AssetDetailsList> GetList()
		{
			return null;
		}

		public static Request<AssetDetails> Status(ulong assetFileID)
		{
			return null;
		}

		public static Request<AssetDetails> StatusById(ulong assetFileID)
		{
			return null;
		}

		public static Request<AssetDetails> StatusByName(string assetFileName)
		{
			return null;
		}

		public static void SetDownloadUpdateNotificationCallback(Message<AssetFileDownloadUpdate>.Callback callback)
		{
		}
	}
}
