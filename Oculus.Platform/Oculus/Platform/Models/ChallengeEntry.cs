using System;

namespace Oculus.Platform.Models
{
	public class ChallengeEntry
	{
		public readonly string DisplayScore;

		public readonly byte[] ExtraData;

		public readonly ulong ID;

		public readonly int Rank;

		public readonly long Score;

		public readonly DateTime Timestamp;

		public readonly User User;

		public ChallengeEntry(IntPtr o)
			: base()
		{
		}
	}
}
