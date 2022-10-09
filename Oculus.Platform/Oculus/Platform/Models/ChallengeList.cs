using System;

namespace Oculus.Platform.Models
{
	public class ChallengeList : DeserializableList<Challenge>
	{
		public readonly ulong TotalCount;

		public ChallengeList(IntPtr a)
			: base()
		{
		}
	}
}
