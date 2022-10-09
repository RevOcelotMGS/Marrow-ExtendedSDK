using System;

namespace SLZ.Data
{
	public class GameSavingEventArgs : EventArgs
	{
		public readonly SaveFlags Flags;

		public GameSavingEventArgs(SaveFlags flags)
			: base()
		{
		}
	}
}
