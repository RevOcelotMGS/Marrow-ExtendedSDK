using System;

namespace Oculus.Platform.Models
{
	public class MatchmakingStats
	{
		public readonly uint DrawCount;

		public readonly uint LossCount;

		public readonly uint SkillLevel;

		public readonly double SkillMean;

		public readonly double SkillStandardDeviation;

		public readonly uint WinCount;

		public MatchmakingStats(IntPtr o)
			: base()
		{
		}
	}
}
