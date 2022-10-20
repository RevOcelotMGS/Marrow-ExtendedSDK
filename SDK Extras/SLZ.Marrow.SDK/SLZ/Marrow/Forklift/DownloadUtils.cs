using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.Forklift
{
	public static class DownloadUtils
	{
		public static void ParseIntoUrls(List<string> strings, [Out] List<Uri> parsedUrls, [Out] List<FetchError> errors)
		{
		}

		public static void GroupUrlsByHost(List<Uri> urls, [Out] Dictionary<string, List<Uri>> groupedUrls, [Out] List<FetchError> errors)
		{
		}

		public static Queue<TItem> LinearizeRoundRobin<TItem, TGroupKey>(Dictionary<TGroupKey, List<TItem>> groupedRequests)
		{
			return null;
		}

		public static void FillItems<TItem>(Queue<TItem> from, List<TItem> into, int limit, List<int> filledIndices, Func<TItem, List<TItem>, bool> shouldAddItemToList)
		{
		}
	}
}
