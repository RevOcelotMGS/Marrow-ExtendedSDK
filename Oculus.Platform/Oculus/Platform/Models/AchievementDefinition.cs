using System;

namespace Oculus.Platform.Models
{
	public class AchievementDefinition
	{
		public readonly AchievementType Type;

		public readonly string Name;

		public readonly uint BitfieldLength;

		public readonly ulong Target;

		public AchievementDefinition(IntPtr o)
			: base()
		{
		}
	}
}
