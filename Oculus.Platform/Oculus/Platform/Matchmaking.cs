using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Matchmaking
	{
		public class CustomQuery
		{
			public struct Criterion
			{
				public string key;

				public MatchmakingCriterionImportance importance;

				public Dictionary<string, object> parameters;

				public Criterion(string key_, MatchmakingCriterionImportance importance_)
				{
					this.parameters = default(Dictionary<string, object>);
					this.importance = default(MatchmakingCriterionImportance);
					this.key = default(string);
				}
			}

			public Dictionary<string, object> data;

			public Criterion[] criteria;

			public IntPtr ToUnmanaged()
			{
				return default(IntPtr);
			}

			public CustomQuery()
				: base()
			{
			}
		}

		public static Request ReportResultsInsecure(ulong roomID, Dictionary<string, int> data)
		{
			return null;
		}

		public static Request<MatchmakingStats> GetStats(string pool, uint maxLevel, MatchmakingStatApproach approach = MatchmakingStatApproach.Trailing)
		{
			return null;
		}

		public static Request<MatchmakingBrowseResult> Browse(string pool, CustomQuery customQueryData = default(CustomQuery))
		{
			return null;
		}

		public static Request<MatchmakingBrowseResult> Browse2(string pool, MatchmakingOptions matchmakingOptions = default(MatchmakingOptions))
		{
			return null;
		}

		public static Request Cancel(string pool, string requestHash)
		{
			return null;
		}

		public static Request Cancel()
		{
			return null;
		}

		public static Request<MatchmakingEnqueueResultAndRoom> CreateAndEnqueueRoom(string pool, uint maxUsers, bool subscribeToUpdates = false, CustomQuery customQueryData = default(CustomQuery))
		{
			return null;
		}

		public static Request<MatchmakingEnqueueResultAndRoom> CreateAndEnqueueRoom2(string pool, MatchmakingOptions matchmakingOptions = default(MatchmakingOptions))
		{
			return null;
		}

		public static Request<Room> CreateRoom(string pool, uint maxUsers, bool subscribeToUpdates = false)
		{
			return null;
		}

		public static Request<Room> CreateRoom2(string pool, MatchmakingOptions matchmakingOptions = default(MatchmakingOptions))
		{
			return null;
		}

		public static Request<MatchmakingEnqueueResult> Enqueue(string pool, CustomQuery customQueryData = default(CustomQuery))
		{
			return null;
		}

		public static Request<MatchmakingEnqueueResult> Enqueue2(string pool, MatchmakingOptions matchmakingOptions = default(MatchmakingOptions))
		{
			return null;
		}

		public static Request<MatchmakingEnqueueResult> EnqueueRoom(ulong roomID, CustomQuery customQueryData = default(CustomQuery))
		{
			return null;
		}

		public static Request<MatchmakingEnqueueResult> EnqueueRoom2(ulong roomID, MatchmakingOptions matchmakingOptions = default(MatchmakingOptions))
		{
			return null;
		}

		public static Request<MatchmakingAdminSnapshot> GetAdminSnapshot()
		{
			return null;
		}

		public static Request<Room> JoinRoom(ulong roomID, bool subscribeToUpdates = false)
		{
			return null;
		}

		public static Request StartMatch(ulong roomID)
		{
			return null;
		}

		public static void SetMatchFoundNotificationCallback(Message<Room>.Callback callback)
		{
		}
	}
}
