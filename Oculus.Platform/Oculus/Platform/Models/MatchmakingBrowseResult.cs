using System;

namespace Oculus.Platform.Models
{
	public class MatchmakingBrowseResult
	{
		public readonly MatchmakingEnqueueResult EnqueueResult;

		public readonly RoomList Rooms;

		public MatchmakingBrowseResult(IntPtr o)
			: base()
		{
		}
	}
}
