using UnityEngine;

namespace Oculus.Platform
{
	public sealed class PlatformSettings : ScriptableObject
	{
		[SerializeField]
		private string ovrAppID;

		[SerializeField]
		private string ovrMobileAppID;

		[SerializeField]
		private bool ovrUseStandalonePlatform;

		private static PlatformSettings instance;

		public static string AppID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string MobileAppID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool UseStandalonePlatform
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static PlatformSettings Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PlatformSettings()
			: base()
		{
		}
	}
}
