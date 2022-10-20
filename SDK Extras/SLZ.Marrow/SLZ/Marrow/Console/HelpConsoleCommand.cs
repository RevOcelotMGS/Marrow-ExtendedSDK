using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;

namespace SLZ.Marrow.Console
{
	[ConsoleCommand("__builtin", "help", "Show console help")]
	internal class HelpConsoleCommand : BaseConsoleCommand
	{
		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		private static UniTask Create(IAsyncWriter<object> writer, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public HelpConsoleCommand()
			: base()
		{
		}
	}
}
