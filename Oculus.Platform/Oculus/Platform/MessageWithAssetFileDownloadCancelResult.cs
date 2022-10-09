using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAssetFileDownloadCancelResult : Message<AssetFileDownloadCancelResult>
	{
		public MessageWithAssetFileDownloadCancelResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override AssetFileDownloadCancelResult GetAssetFileDownloadCancelResult()
		{
			return null;
		}

		protected override AssetFileDownloadCancelResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
