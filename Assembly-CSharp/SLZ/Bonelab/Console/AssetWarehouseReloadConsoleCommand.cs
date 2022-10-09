using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("aw", "reload", "Reload Pallet")]
	[ConsoleCommand("assetwarehouse", "reload", "Reload Pallet")]
	public class AssetWarehouseReloadConsoleCommand : SimpleConsoleCommand
	{
		public override UniTask RunSimpleCommand(IAsyncWriter<object> writer, string parameter)
		{
			return default(UniTask);
		}

		public AssetWarehouseReloadConsoleCommand()
			: base()
		{
		}
	}
}
