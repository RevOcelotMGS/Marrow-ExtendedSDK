using System;
using SLZ.Data.SaveData;

namespace SLZ.Data
{
	public class GameSavedEventArgs : EventArgs
	{
		public readonly SaveFlags Flags;

		public readonly bool CancelledOrFailed;

		public readonly Save Save;

		public GameSavedEventArgs(SaveFlags flags, bool cancelledOrFailed, Save save)
			: base()
		{
		}
	}
}
