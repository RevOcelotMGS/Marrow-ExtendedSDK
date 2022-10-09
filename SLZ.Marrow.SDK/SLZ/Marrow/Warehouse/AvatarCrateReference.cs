using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class AvatarCrateReference : CrateReferenceT<AvatarCrate>
	{
		public AvatarCrateReference(string barcode)
			: this()
		{
		}

		public AvatarCrateReference()
			: base()
		{
		}
	}
}
