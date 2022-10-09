using System;

namespace SLZ.Data
{
	public class GameLoadingEventArgs : EventArgs
	{
		public readonly SaveFlags Flags;

		public GameLoadingEventArgs(SaveFlags flags)
			: base()
		{
		}
	}
}
