using System;

namespace Oculus.Platform.Models
{
	public class AchievementProgress
	{
		public readonly string Bitfield;

		public readonly ulong Count;

		public readonly bool IsUnlocked;

		public readonly string Name;

		public readonly DateTime UnlockTime;

		public AchievementProgress(IntPtr o)
			: base()
		{
		}
	}
}
