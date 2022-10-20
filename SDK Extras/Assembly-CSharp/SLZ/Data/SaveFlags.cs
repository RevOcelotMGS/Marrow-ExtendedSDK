using System;

namespace SLZ.Data
{
	[Flags]
	public enum SaveFlags
	{
		DefaultAndPlayerSettingsAndUnlocks = 0,
		Progression = 2,
		Complete = 2
	}
}
