using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Console
{
	public sealed class ConsoleCommandWrapper
	{
		public readonly BaseConsoleCommand Command;

		public bool Installed { get; internal set; }

		public IReadOnlyList<ConsoleCommandAttribute> Attributes { get; internal set; }

		public ConsoleCommandWrapper(Type commandType)
			: base()
		{
		}
	}
}
