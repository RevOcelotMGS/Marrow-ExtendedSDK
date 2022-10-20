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
using WebSocketSharp;
using WebSocketSharp.Server;

namespace SLZ.WebSocket
{
	internal class DebugConsoleWebSocketBehavior : WebSocketBehavior
	{
		private static HashSet<DebugConsoleWebSocketBehavior> instances;

		private ConsoleCommandWrapperConverter _commandConverter;

		private static ConsoleCommandPlugin Plugin
		{
			get
			{
				return null;
			}
		}

		protected override void OnOpen()
		{
		}

		protected override void OnClose(CloseEventArgs e)
		{
		}

		protected override void OnMessage(MessageEventArgs e)
		{
		}

		private IUniTaskAsyncEnumerable<object> RunCommandAsync(string command)
		{
			return null;
		}

		private bool TryMatchCommands(string input, [Out] List<ConsoleCommandWrapper> matchedCommands)
		{
			return default(bool);
		}

		public static void SendString(string @string)
		{
		}

		public static void SendBytes(byte[] bytes)
		{
		}

		public DebugConsoleWebSocketBehavior()
			: base()
		{
		}
	}
}
