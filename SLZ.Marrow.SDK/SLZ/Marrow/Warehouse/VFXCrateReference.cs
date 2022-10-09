using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class VFXCrateReference : CrateReferenceT<VFXCrate>
	{
		public VFXCrateReference(string barcode)
			: this()
		{
		}

		public VFXCrateReference()
			: base()
		{
		}
	}
}
