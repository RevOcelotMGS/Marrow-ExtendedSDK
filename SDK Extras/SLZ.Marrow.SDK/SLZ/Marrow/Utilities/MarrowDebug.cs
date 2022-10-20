using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public static class MarrowDebug
	{
		public sealed class LogSuppressor : IDisposable
		{
			private readonly bool _doNothing;

			private readonly bool _previousValue;

			private bool _disposedValue;

			private void Dispose(bool disposing)
			{
			}

			public LogSuppressor()
				: base()
			{
			}

			public LogSuppressor(bool doNothing)
				: this()
			{
			}

			~LogSuppressor()
			{
			}

			void IDisposable.Dispose()
			{
			}
		}

		private const bool Enable = true;

		private const bool ShowTypicalLogs = false;

		private const bool ShowWarnings = false;

		private static readonly ThreadLocal<bool> ThreadLocalEnable;

		public static LogSuppressor SuppressIf(bool condition)
		{
			return null;
		}

		public static void Log(object message, UnityEngine.Object context)
		{
		}

		public static void Log(object message)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message, UnityEngine.Object context)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(UnityEngine.Object context, string format, params object[] args)
		{
			args = default(object[]);
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(string format, params object[] args)
		{
			args = default(object[]);
		}

		public static void LogError(object message)
		{
		}

		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		public static void LogErrorFormat(string format, params object[] args)
		{
			args = default(object[]);
		}

		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
			args = default(object[]);
		}

		public static void LogException(Exception exception)
		{
		}

		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
			args = default(object[]);
		}

		public static void LogFormat(LogType logType, LogOption logOptions, UnityEngine.Object context, string format, params object[] args)
		{
			args = default(object[]);
		}

		public static void LogFormat(string format, params object[] args)
		{
			args = default(object[]);
		}

		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		public static void LogWarning(object message)
		{
		}

		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
			args = default(object[]);
		}

		public static void LogWarningFormat(string format, params object[] args)
		{
			args = default(object[]);
		}

		[Conditional("UNITY_EDITOR")]
		public static void WarnIfCalledFromAwake()
		{
		}
	}
}
