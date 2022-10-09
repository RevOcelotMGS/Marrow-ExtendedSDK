using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAssetFileDownloadUpdate : Message<AssetFileDownloadUpdate>
	{
		public MessageWithAssetFileDownloadUpdate(IntPtr c_message)
			: base(c_message)
		{
		}

		public override AssetFileDownloadUpdate GetAssetFileDownloadUpdate()
		{
			return null;
		}

		protected override AssetFileDownloadUpdate GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
