namespace SLZ.Marrow.Plugins
{
	public interface IMarrowPluginRunCallbacks : IMarrowPlugin
	{
		void OnMarrowPluginStart();

		void OnMarrowPluginStop();
	}
}
