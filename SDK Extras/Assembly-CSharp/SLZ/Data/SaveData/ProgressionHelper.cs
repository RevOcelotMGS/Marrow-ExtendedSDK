using System.Runtime.InteropServices;

namespace SLZ.Data.SaveData
{
	public static class ProgressionHelper
	{
		public static bool TrySetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, object value)
		{
			return default(bool);
		}

		public static bool TryGetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, [Out] object value)
		{
			return default(bool);
		}

		public static bool TryGetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, [Out] bool value)
		{
			return default(bool);
		}

		public static bool TryGetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, [Out] int value)
		{
			return default(bool);
		}

		public static bool TryGetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, [Out] float value)
		{
			return default(bool);
		}

		public static bool TryGetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, [Out] double value)
		{
			return default(bool);
		}

		public static bool TryDeleteLevelValue(this PlayerProgression progression, string levelKey, string valueKey, Confirmation1 confirmation)
		{
			return default(bool);
		}

		public static bool TryDeleteLevelValue(this PlayerProgression progression, string levelKey, string valueKey, [Out] object finalValue, Confirmation1 confirmation)
		{
			return default(bool);
		}

		public static bool TryDeleteAllLevelData(this PlayerProgression progression, string levelKey, Confirmation1 confirmation = Confirmation1.IMadeAMistake, Confirmation2 confirmation2 = Confirmation2.OnTheSecondThoughtMaybeNot)
		{
			return default(bool);
		}

		public static bool TryDeleteSaveableLevelData(this PlayerProgression progression, string levelKey, Confirmation1 confirmation = Confirmation1.IMadeAMistake)
		{
			return default(bool);
		}
	}
}
