using System;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class CrateReferenceT<T> : CrateReference where T : Crate
	{
		public new T Crate
		{
			get
			{
				return null;
			}
		}

		public CrateReferenceT()
			: base()
		{
		}

		public CrateReferenceT(string barcode)
			: this()
		{
		}

		public bool TryGetCrate([Out] T crate)
		{
			return default(bool);
		}
	}
}
