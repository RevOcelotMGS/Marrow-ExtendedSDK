using System.Collections.Generic;

namespace SLZ.Marrow.Warehouse
{
	public interface IScannable : IReadOnlyScannable
	{
		bool Unlockable { get; }

		bool Redacted { get; }

		void GenerateBarcode(bool forceGeneration = false);

		void GenerateBarcodeInternal(bool forceGeneration = false);

		List<PackedAsset> CollectPackedAssets();
	}
}
