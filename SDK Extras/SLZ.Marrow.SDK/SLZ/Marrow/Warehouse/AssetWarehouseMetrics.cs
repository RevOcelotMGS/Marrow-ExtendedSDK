using Unity.Profiling;

namespace SLZ.Marrow.Warehouse
{
	public static class AssetWarehouseMetrics
	{
		public static readonly ProfilerCategory AssetWarehouseCategory;

		public const string LoadedCrateAssetsCountName = "Loaded Crate Assets";

		public static readonly ProfilerCounterValue<int> LoadedCrateAssetsCount;

		public static void Reset()
		{
		}
	}
}
