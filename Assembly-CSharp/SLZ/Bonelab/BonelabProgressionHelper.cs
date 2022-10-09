using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Data.SaveData;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Player;
using UnityEngine;

namespace SLZ.Bonelab
{
	public static class BonelabProgressionHelper
	{
		internal enum Level
		{
			Descent = 0,
			LongRun = 1,
			Ascent = 2,
			Outro = 3,
			None = 4
		}

		public static Dictionary<string, int> CalculateStartingAmmo(this PlayerProgression progression, params string[] priorLevels)
		{
			priorLevels = default(string[]);
			return null;
		}

		public static Dictionary<string, int> CalculateFinalAmmoDelta(this PlayerProgression progression, params string[] priorLevels)
		{
			priorLevels = default(string[]);
			return null;
		}

		public static Dictionary<string, int> UpdateFinalAmmoDelta(this PlayerProgression progression, string levelKey, params string[] priorLevels)
		{
			priorLevels = default(string[]);
			return null;
		}

		public static Dictionary<string, Dictionary<string, int>> GatherAmmoDeltas(this PlayerProgression progression)
		{
			return null;
		}

		public static bool SaveInventory(this PlayerProgression progression, string levelKey, string valueKey)
		{
			return default(bool);
		}

		public static bool RestoreInventory(this PlayerProgression progression, string levelKey, bool freshLoad, Transform leftHand, Transform rightHand, Func<Barcode, Barcode> itemFilter = default(Func<Barcode, Barcode>), params string[] priorLevels)
		{
			priorLevels = default(string[]);
			return default(bool);
		}

		private static UniTaskVoid _restoreSlotsOnReady(Inventory inventory, JObject inventoryJson, Transform leftHand, Transform rightHand, Func<Barcode, Barcode> itemFilter)
		{
			return default(UniTaskVoid);
		}

		public static bool SaveInProgressAmmoCount(this PlayerProgression progression, string levelKey)
		{
			return default(bool);
		}

		public static void RestoreAmmoCounts(this PlayerProgression progression, string levelKey, bool freshLoad, params string[] priorLevels)
		{
			priorLevels = default(string[]);
		}

		public static bool TrySetLevelCompleted(this PlayerProgression progression, string levelKey, bool completed)
		{
			return default(bool);
		}

		public static bool TrySetLevelProgress(this PlayerProgression progression, string levelKey, int progress)
		{
			return default(bool);
		}

		public static bool TryGetLevelCompleted(this PlayerProgression progression, string levelKey, [Out] bool completed)
		{
			return default(bool);
		}

		public static bool TryGetLevelProgress(this PlayerProgression progression, string levelKey, [Out] int progress)
		{
			return default(bool);
		}

		internal static void DeletePartialProgressForKey(this PlayerProgression p, string levelKey, Confirmation1 confirmation = Confirmation1.IMadeAMistake)
		{
		}

		internal static void DeletePartialProgressForLevelsExcept(this PlayerProgression p, Level level)
		{
		}

		internal static void KeywiseAdd(this Dictionary<string, int> dict, Dictionary<string, int> other)
		{
		}

		internal static void KeywiseSubtract(this Dictionary<string, int> dict, Dictionary<string, int> other)
		{
		}

		internal static void KeywiseMax(this Dictionary<string, int> dict, Dictionary<string, int> other)
		{
		}
	}
}
