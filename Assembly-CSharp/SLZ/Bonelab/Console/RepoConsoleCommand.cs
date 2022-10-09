using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
	[ConsoleCommand("repo", "list", "List mod repos")]
	[ConsoleCommand("repo", "del", "Delete a mod repo")]
	[ConsoleCommand("repo", "delete", "Delete a mod repo")]
	[ConsoleCommand("repo", "add", "Add a mod repo")]
	public class RepoConsoleCommand : BaseConsoleCommand
	{

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		private static Task ListRepos(IAsyncWriter<object> writer, CancellationToken cancellationToken)
		{
			return null;
		}

		private static Task AddRepos(IAsyncWriter<object> writer, CancellationToken cancellationToken, Uri uri)
		{
			return null;
		}

		private static Task DeleteRepos(IAsyncWriter<object> writer, CancellationToken cancellationToken, int lineNo)
		{
			return null;
		}

		public RepoConsoleCommand()
			: base()
		{
		}
	}
}
