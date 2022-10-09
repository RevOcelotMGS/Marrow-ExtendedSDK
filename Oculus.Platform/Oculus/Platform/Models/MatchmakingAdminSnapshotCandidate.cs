using System;

namespace Oculus.Platform.Models
{
	public class MatchmakingAdminSnapshotCandidate
	{
		public readonly bool CanMatch;

		public readonly double MyTotalScore;

		public readonly double TheirCurrentThreshold;

		public readonly double TheirTotalScore;

		public readonly string TraceId;

		public MatchmakingAdminSnapshotCandidate(IntPtr o)
			: base()
		{
		}
	}
}
