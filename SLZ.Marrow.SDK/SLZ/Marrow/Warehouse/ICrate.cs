using System;

namespace SLZ.Marrow.Warehouse
{
	public interface ICrate
	{
		MarrowAsset MainAsset { get; set; }

		Type AssetType { get; }
	}
}
