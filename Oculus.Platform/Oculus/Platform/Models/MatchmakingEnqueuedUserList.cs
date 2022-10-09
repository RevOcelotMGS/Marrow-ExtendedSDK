using System;

namespace Oculus.Platform.Models
{
	public class MatchmakingEnqueuedUserList : DeserializableList<MatchmakingEnqueuedUser>
	{
		public MatchmakingEnqueuedUserList(IntPtr a)
			: base()
		{
		}
	}
}
