using System.Collections.Generic;

namespace SLZ.Marrow.Warehouse
{
	public static class AssetWarehouseExtensions
	{
		public static List<T> Filter<T>(this List<T> crateList, ICrateFilter<T> crateFilter) where T : Crate
		{
			return null;
		}
	}
}
