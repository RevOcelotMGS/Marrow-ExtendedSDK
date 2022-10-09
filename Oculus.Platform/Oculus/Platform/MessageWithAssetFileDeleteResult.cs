using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAssetFileDeleteResult : Message<AssetFileDeleteResult>
	{
		public MessageWithAssetFileDeleteResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override AssetFileDeleteResult GetAssetFileDeleteResult()
		{
			return null;
		}

		protected override AssetFileDeleteResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
