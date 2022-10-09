using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class SpawnableCrateReference : CrateReferenceT<SpawnableCrate>
	{
		public SpawnableCrateReference(string barcode)
			: this()
		{
		}

		public SpawnableCrateReference()
			: base()
		{
		}
	}
}
