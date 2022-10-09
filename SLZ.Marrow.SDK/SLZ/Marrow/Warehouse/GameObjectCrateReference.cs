using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class GameObjectCrateReference : CrateReferenceT<GameObjectCrate>
	{
		public GameObjectCrateReference(string barcode)
			: this()
		{
		}

		public GameObjectCrateReference()
			: base()
		{
		}
	}
}
