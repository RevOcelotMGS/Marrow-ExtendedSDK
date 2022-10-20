using System;
using System.Collections;
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
	public abstract class BaseConsoleCommand
	{
		[Flags]
		public enum CommandStatus : uint
		{
			Completable = 1u,
			Continuable = 2u,
			Disqualified = 4u,
			SuggestionIsDefault = 0x10000000u,
			SuggestionIsCurrentValue = 0x20000000u,
			SuggestionIsTemplate = 0x40000000u
		}

		public IEnumerable<ValueTuple<CommandStatus, string, object>> ParseNextArgument(string input)
		{
			return null;
		}

		/*protected virtual ValueTuple<CommandStatus, string, object> ParseTokenAtIndex([TupleElementNames(new string[] { "token", "parsed" })] List<ValueTuple<string, object>> previousTokens, int index, string token)
		{
			return default(ValueTuple<CommandStatus, string, object>);
		}*/

		public virtual IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		private UniTask DefaultEmptyCommand(IAsyncWriter<object> writer, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public BaseConsoleCommand()
			: base()
		{
		}
	}
}
