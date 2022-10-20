using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	public abstract class SimpleConsoleCommand : BaseConsoleCommand
	{

		public abstract UniTask RunSimpleCommand(IAsyncWriter<object> writer, string parameter);

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		public SimpleConsoleCommand()
			: base()
		{
		}
	}
}
