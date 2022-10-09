using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TriangleNet.Logging;

namespace TriangleNet
{
	public sealed class Log : ILog<LogItem>
	{
		private List<LogItem> log;

		private LogLevel level;

		private static readonly Log instance;

		public static bool Verbose { get; set; }

		public static ILog<LogItem> Instance
		{
			get
			{
				return null;
			}
		}

		public IList<LogItem> Data
		{
			get
			{
				return null;
			}
		}

		public LogLevel Level
		{
			get
			{
				return default(LogLevel);
			}
		}

		static Log()
		{
		}

		private Log()
			: base()
		{
		}

		public void Add(LogItem item)
		{
		}

		public void Clear()
		{
		}

		public void Info(string message)
		{
		}

		public void Warning(string message, string location)
		{
		}

		public void Error(string message, string location)
		{
		}
	}
}
