using System.Runtime.InteropServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public sealed class Core
	{
		private static bool IsPlatformInitialized;

		public static bool LogMessages;

		public static string PlatformUninitializedError;

		public static bool IsInitialized()
		{
			return default(bool);
		}

		internal static void ForceInitialized()
		{
		}

		private static string getAppID(string appId = default(string))
		{
			return null;
		}

		public static Request<PlatformInitialize> AsyncInitialize(string appId = default(string))
		{
			return null;
		}

		public static void Initialize(string appId = default(string))
		{
		}

		private static string GetAppIDFromConfig()
		{
			return null;
		}

		public Core()
			: base()
		{
		}
	}
}
