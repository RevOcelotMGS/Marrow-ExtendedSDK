using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class LevelCrateReference : CrateReferenceT<LevelCrate>
	{
		public LevelCrateReference(string barcode)
			: this()
		{
		}

		public LevelCrateReference()
			: base()
		{
		}
	}
}
