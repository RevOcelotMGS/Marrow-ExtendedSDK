using System;

namespace TriangleNet.Logging
{
	public class LogItem : ILogItem
	{
		private DateTime time;

		private LogLevel level;

		private string message;

		private string info;

		public DateTime Time
		{
			get
			{
				return default(DateTime);
			}
		}

		public LogLevel Level
		{
			get
			{
				return default(LogLevel);
			}
		}

		public string Message
		{
			get
			{
				return null;
			}
		}

		public string Info
		{
			get
			{
				return null;
			}
		}

		public LogItem(LogLevel level, string message)
			: base()
		{
		}

		public LogItem(LogLevel level, string message, string info)
			: base()
		{
		}
	}
}
