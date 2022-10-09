using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class GenericCrateReference : CrateReferenceT<Crate>
	{
		public GenericCrateReference(string barcode)
			: this()
		{
		}

		public GenericCrateReference()
			: base()
		{
		}
	}
}
