using System;

namespace Oculus.Platform.Models
{
	public class MatchmakingAdminSnapshot
	{
		public readonly MatchmakingAdminSnapshotCandidateList Candidates;

		public readonly double MyCurrentThreshold;

		public MatchmakingAdminSnapshot(IntPtr o)
			: base()
		{
		}
	}
}
