using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAssetDetailsList : Message<AssetDetailsList>
	{
		public MessageWithAssetDetailsList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override AssetDetailsList GetAssetDetailsList()
		{
			return null;
		}

		protected override AssetDetailsList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
