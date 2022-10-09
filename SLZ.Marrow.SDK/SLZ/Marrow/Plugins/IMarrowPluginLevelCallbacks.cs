using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Plugins
{
	public interface IMarrowPluginLevelCallbacks : IMarrowPlugin
	{
		void OnBeforeLevelLoad(LevelCrateReference level);

		void OnAfterLevelLoad(LevelCrateReference level);

		void OnBeforeLevelUnload();

		void OnAfterLevelUnload();
	}
}
