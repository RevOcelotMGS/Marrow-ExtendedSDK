using System;

namespace Oculus.Platform.Models
{
	public class LeaderboardEntry
	{
		public readonly string DisplayScore;

		public readonly byte[] ExtraData;

		public readonly ulong ID;

		public readonly int Rank;

		public readonly long Score;

		public readonly SupplementaryMetric SupplementaryMetricOptional;

		[Obsolete("Deprecated in favor of SupplementaryMetricOptional")]
		public readonly SupplementaryMetric SupplementaryMetric;

		public readonly DateTime Timestamp;

		public readonly User User;

		public LeaderboardEntry(IntPtr o)
			: base()
		{
		}
	}
}
