using System;

namespace Oculus.Platform.Models
{
	public class MatchmakingEnqueueResult
	{
		public readonly MatchmakingAdminSnapshot AdminSnapshotOptional;

		[Obsolete("Deprecated in favor of AdminSnapshotOptional")]
		public readonly MatchmakingAdminSnapshot AdminSnapshot;

		public readonly uint AverageWait;

		public readonly uint MatchesInLastHourCount;

		public readonly uint MaxExpectedWait;

		public readonly string Pool;

		public readonly uint RecentMatchPercentage;

		public readonly string RequestHash;

		public MatchmakingEnqueueResult(IntPtr o)
			: base()
		{
		}
	}
}
