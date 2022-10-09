namespace SLZ.Marrow.Plugins
{
	public interface IMarrowPluginEditorCallbacks : IMarrowPlugin
	{
		void OnMarrowPluginEditorPaused();

		void OnMarrowPluginEditorUnpaused();

		void OnMarrowPluginEditorEnteredEditMode();

		void OnMarrowPluginEditorExitingEditMode();

		void OnMarrowPluginEditorEnteredPlayMode();

		void OnMarrowPluginEditorExitingPlayMode();

		void OnMarrowPluginEditorBeforeAssemblyReload();

		void OnMarrowPluginEditorAfterAssemblyReload();
	}
}
