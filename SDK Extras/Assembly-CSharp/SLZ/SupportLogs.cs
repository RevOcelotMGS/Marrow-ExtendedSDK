using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Scripting;

namespace SLZ
{
	[Preserve]
	public static class SupportLogs
	{
		private static string LogDir;

		private static string ExeDir;

		[RuntimeInitializeOnLoadMethod]
		private static void CycleLogs()
		{
		}

		private static UniTaskVoid NewLogFile()
		{
			return default(UniTaskVoid);
		}

		private static UniTask FillLog(StreamWriter logStream, string exeDir, string logDir, string filename, string utcNowStr, string localNowStr)
		{
			return default(UniTask);
		}

		private static UniTask WritePropertyAsync<T>(JsonTextWriter jtw, string key, T value)
		{
			return default(UniTask);
		}

		private static string _pn(this NamingStrategy ns, string key)
		{
			return null;
		}
	}
}
