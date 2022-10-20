using System.Runtime.CompilerServices;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Interaction
{
	[MarrowPlugin("SLZ.Marrow.Plugins", "Overlap Trigger", "0.0.1")]
	public class OverlapTriggerPlugin : IMarrowPluginRunCallbacks, IMarrowPlugin, IMarrowPluginLevelCallbacks
	{
		public OverlapTriggerManager Manager { get; private set; }

		[MarrowPluginRegisterMethod]
		public static void RegisterPlugin(IMarrowPluginRegistration registration)
		{
		}

		public void OnMarrowPluginLoad()
		{
		}

		public void OnMarrowPluginStart()
		{
		}

		public void OnMarrowPluginStop()
		{
		}

		public void OnBeforeLevelLoad(LevelCrateReference level)
		{
		}

		public void OnBeforeLevelUnload()
		{
		}

		public void OnAfterLevelLoad(LevelCrateReference level)
		{
		}

		public void OnAfterLevelUnload()
		{
		}

		public OverlapTriggerPlugin()
			: base()
		{
		}
	}
}
