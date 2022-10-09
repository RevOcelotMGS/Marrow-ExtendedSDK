using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("__builtin", "volume", "Set/Get Volume settings: volume master|music|sfx #")]
	internal class VolumeConsoleCommand : BaseConsoleCommand
	{
		protected override ValueTuple<CommandStatus, string, object> ParseTokenAtIndex([TupleElementNames(new string[] { "token", "parsed" })] List<ValueTuple<string, object>> previousTokens, int index, string token)
		{
			return default(ValueTuple<CommandStatus, string, object>);
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		private UniTask GetVolume(IAsyncWriter<object> writer, CancellationToken _)
		{
			return default(UniTask);
		}

		private Task SetVolume([TupleElementNames(new string[] { "status", "token", "parsed" })] List<ValueTuple<CommandStatus, string, object>> args, IAsyncWriter<object> writer, CancellationToken _)
		{
			return null;
		}

		public VolumeConsoleCommand()
			: base()
		{
		}
	}
}
