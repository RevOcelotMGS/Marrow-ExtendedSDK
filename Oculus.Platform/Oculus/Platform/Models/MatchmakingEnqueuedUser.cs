using System;
using System.Collections.Generic;

namespace Oculus.Platform.Models
{
	public class MatchmakingEnqueuedUser
	{
		public readonly Dictionary<string, string> CustomData;

		public readonly User UserOptional;

		[Obsolete("Deprecated in favor of UserOptional")]
		public readonly User User;

		public MatchmakingEnqueuedUser(IntPtr o)
			: base()
		{
		}
	}
}
