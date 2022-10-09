using UnityEngine;

namespace SLZ.Marrow.Data
{
	public class PlatformSelectionData : ScriptableObject
	{
		[SerializeField]
		public VRPlatform platform;

		[SerializeField]
		public string appId;

		[SerializeField]
		public string timeBuilt;

		private static string PLATFORM_LOCAL_DATA_PATH;

		private static PlatformSelectionData _localData;

		public static PlatformSelectionData LocalData
		{
			get
			{
				return null;
			}
		}

		public static string AppId()
		{
			return null;
		}

		public PlatformSelectionData()
			: base()
		{
		}
	}
}
