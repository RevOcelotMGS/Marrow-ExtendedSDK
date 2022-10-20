using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.VoidLogic
{
	internal static class DictionaryCountedSetFunctions
	{
		public static bool AddOne<T>(this Dictionary<T, int> dict, T obj, [Out] int count, Func<T, bool> onFirstAdded = default(Func<T, bool>)) where T : class
		{
			return default(bool);
		}

		public static bool TryRemoveOne<T>(this Dictionary<T, int> dict, T obj, [Out] int count, Action<T, int> onLastRemoved = default(Action<T, int>)) where T : class
		{
			return default(bool);
		}

		public static bool Clear<T>(this Dictionary<T, int> dict, T obj, [Out] int count, Action<T, int> onRemoved = default(Action<T, int>)) where T : class
		{
			return default(bool);
		}
	}
}
