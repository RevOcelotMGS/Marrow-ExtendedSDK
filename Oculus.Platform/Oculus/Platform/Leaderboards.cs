using System.Runtime.InteropServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Leaderboards
	{
		public static Request<LeaderboardEntryList> GetNextEntries(LeaderboardEntryList list)
		{
			return null;
		}

		public static Request<LeaderboardEntryList> GetPreviousEntries(LeaderboardEntryList list)
		{
			return null;
		}

		public static Request<LeaderboardList> Get(string leaderboardName)
		{
			return null;
		}

		public static Request<LeaderboardEntryList> GetEntries(string leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt)
		{
			return null;
		}

		public static Request<LeaderboardEntryList> GetEntriesAfterRank(string leaderboardName, int limit, ulong afterRank)
		{
			return null;
		}

		public static Request<LeaderboardEntryList> GetEntriesByIds(string leaderboardName, int limit, LeaderboardStartAt startAt, ulong[] userIDs)
		{
			return null;
		}

		public static Request<bool> WriteEntry(string leaderboardName, long score, byte[] extraData = default(byte[]), bool forceUpdate = false)
		{
			return null;
		}

		public static Request<bool> WriteEntryWithSupplementaryMetric(string leaderboardName, long score, long supplementaryMetric, byte[] extraData = default(byte[]), bool forceUpdate = false)
		{
			return null;
		}

		public static Request<LeaderboardList> GetNextLeaderboardListPage(LeaderboardList list)
		{
			return null;
		}
	}
}
