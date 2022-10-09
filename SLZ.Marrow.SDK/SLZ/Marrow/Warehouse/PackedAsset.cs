using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public struct PackedAsset
	{
		public string title;

		public MarrowAsset marrowAsset;

		public List<PackedSubAsset> subAssets;

		public Type assetType;

		private string assetFieldName;

		public PackedAsset(string title, MarrowAsset marrowAsset, Type assetType, string assetFieldName)
		{
			this.assetFieldName = default(string);
			this.assetType = default(Type);
			this.subAssets = default(List<PackedSubAsset>);
			this.marrowAsset = default(MarrowAsset);
			this.title = default(string);
		}

		public PackedAsset(string title, List<PackedSubAsset> subAssets, Type assetType, string assetFieldName)
		{
			this.assetFieldName = default(string);
			this.assetType = default(Type);
			this.subAssets = default(List<PackedSubAsset>);
			this.marrowAsset = default(MarrowAsset);
			this.title = default(string);
		}
	}
}
