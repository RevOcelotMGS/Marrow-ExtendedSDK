using System;

namespace Oculus.Platform.Models
{
	public class LivestreamingStatus
	{
		public readonly bool CommentsVisible;

		public readonly bool IsPaused;

		public readonly bool LivestreamingEnabled;

		public readonly int LivestreamingType;

		public readonly bool MicEnabled;

		public LivestreamingStatus(IntPtr o)
			: base()
		{
		}
	}
}
