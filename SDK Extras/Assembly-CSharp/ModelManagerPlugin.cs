using System.Threading;
using SLZ.Marrow.Plugins;

[MarrowPlugin("MLPlugins", "ModelManagerPlugin", "0.0.1")]
public class ModelManagerPlugin : IMarrowPluginRunCallbacks, IMarrowPlugin
{
	public ModelManagerConfig config;

	public BarracudaModelManager modelManager;

	private CancellationTokenSource disableCancellation;

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

	public void ModelManagerRun()
	{
	}

	public void ModelManagerStop()
	{
	}

	public ModelManagerPlugin()
		: base()
	{
	}
}
