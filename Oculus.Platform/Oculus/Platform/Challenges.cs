using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Challenges
	{
		public static Request<ChallengeEntryList> GetNextEntries(ChallengeEntryList list)
		{
			return null;
		}

		public static Request<ChallengeEntryList> GetPreviousEntries(ChallengeEntryList list)
		{
			return null;
		}

		public static Request<ChallengeList> GetNextChallenges(ChallengeList list)
		{
			return null;
		}

		public static Request<ChallengeList> GetPreviousChallenges(ChallengeList list)
		{
			return null;
		}

		public static Request<Challenge> Create(string leaderboardName, ChallengeOptions challengeOptions)
		{
			return null;
		}

		public static Request<Challenge> DeclineInvite(ulong challengeID)
		{
			return null;
		}

		public static Request Delete(ulong challengeID)
		{
			return null;
		}

		public static Request<Challenge> Get(ulong challengeID)
		{
			return null;
		}

		public static Request<ChallengeEntryList> GetEntries(ulong challengeID, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt)
		{
			return null;
		}

		public static Request<ChallengeEntryList> GetEntriesAfterRank(ulong challengeID, int limit, ulong afterRank)
		{
			return null;
		}

		public static Request<ChallengeEntryList> GetEntriesByIds(ulong challengeID, int limit, LeaderboardStartAt startAt, ulong[] userIDs)
		{
			return null;
		}

		public static Request<ChallengeList> GetList(ChallengeOptions challengeOptions, int limit)
		{
			return null;
		}

		public static Request<Challenge> Join(ulong challengeID)
		{
			return null;
		}

		public static Request<Challenge> Leave(ulong challengeID)
		{
			return null;
		}

		public static Request<Challenge> UpdateInfo(ulong challengeID, ChallengeOptions challengeOptions)
		{
			return null;
		}
	}
}
