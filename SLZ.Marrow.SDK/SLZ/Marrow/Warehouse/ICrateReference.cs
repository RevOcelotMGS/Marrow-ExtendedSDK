using System.Runtime.InteropServices;

namespace SLZ.Marrow.Warehouse
{
	public interface ICrateReference
	{
		Barcode Barcode { get; set; }

		Crate Crate { get; }

		bool TryGetCrate([Out] Crate crate);
	}
}
