namespace SLZ.Marrow
{
	public static class MarrowSDK
	{
		public const string SDK_NAME = "Marrow SDK";

		public const string SDK_VERSION = "0.3.0-1530";

		public const string DEV_NAME = "Stress Level Zero";

		public const string DEV_NAME_ALT = "StressLevelZero";

		public const string PACKAGE_NAME = "com.stresslevelzero.marrow.sdk";

		public static readonly string PROJ4_NAME;

		public static readonly string[] GAME_NAMES;

		public const string RUNTIME_MODS_DIRECTORY_NAME = "Mods";

		public const string INSTALL_STAGING_DIRECTORY_NAME = "ModsStaging";

		public static readonly int MAX_PATH;

		private static string _runtimeModsPath;

		private static string _installStagingPath;

		private static string _modsCachePath;

		private static string _modSettingsPath;

		private static char[] invalidFilenameCharacters;

		public static string RuntimeModsPath
		{
			get
			{
				return null;
			}
		}

		public static string InstallStagingPath
		{
			get
			{
				return null;
			}
		}

		public static string ModsCachePath
		{
			get
			{
				return null;
			}
		}

		public static string ModSettingsPath
		{
			get
			{
				return null;
			}
		}

		public static string SanitizeName(string name)
		{
			return null;
		}

		public static string SanitizeID(string id)
		{
			return null;
		}
	}
}
