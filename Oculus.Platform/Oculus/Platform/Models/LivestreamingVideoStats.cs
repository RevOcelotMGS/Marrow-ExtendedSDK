using System;

namespace Oculus.Platform.Models
{
	public class LivestreamingVideoStats
	{
		public readonly int CommentCount;

		public readonly int ReactionCount;

		public readonly string TotalViews;

		public LivestreamingVideoStats(IntPtr o)
			: base()
		{
		}
	}
}
