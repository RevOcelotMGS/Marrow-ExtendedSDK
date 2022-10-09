using System;

namespace Oculus.Platform.Models
{
	public class LeaderboardEntryList : DeserializableList<LeaderboardEntry>
	{
		public readonly ulong TotalCount;

		public LeaderboardEntryList(IntPtr a)
			: base()
		{
		}
	}
}
