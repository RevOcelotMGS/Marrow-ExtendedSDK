using System;
using SLZ.Data.SaveData;

namespace SLZ.Data
{
	public class GameLoadedEventArgs : EventArgs
	{
		public readonly SaveFlags Flags;

		public readonly bool CancelledOrFailed;

		public readonly Save Save;

		public GameLoadedEventArgs(SaveFlags flags, bool cancelledOrFailed, Save save)
			: base()
		{
		}
	}
}
