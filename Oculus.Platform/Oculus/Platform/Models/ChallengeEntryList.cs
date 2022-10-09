using System;

namespace Oculus.Platform.Models
{
	public class ChallengeEntryList : DeserializableList<ChallengeEntry>
	{
		public readonly ulong TotalCount;

		public ChallengeEntryList(IntPtr a)
			: base()
		{
		}
	}
}
