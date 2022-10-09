namespace DigitalOpus.MB.Core
{
	public class ObjectLog
	{
		private int pos;

		private string[] logMessages;

		private void _CacheLogMessage(string msg)
		{
		}

		public ObjectLog(short bufferSize)
			: base()
		{
		}

		public void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		public void Error(string msg, params object[] args)
		{
			args = default(object[]);
		}

		public void Warn(string msg, params object[] args)
		{
			args = default(object[]);
		}

		public void Info(string msg, params object[] args)
		{
			args = default(object[]);
		}

		public void LogDebug(string msg, params object[] args)
		{
			args = default(object[]);
		}

		public void Trace(string msg, params object[] args)
		{
			args = default(object[]);
		}

		public string Dump()
		{
			return null;
		}
	}
}
