using System;

namespace Oculus.Platform
{
	public class RoomOptions
	{
		private IntPtr Handle;

		public void SetDataStore(string key, string value)
		{
		}

		public void ClearDataStore()
		{
		}

		public void SetExcludeRecentlyMet(bool value)
		{
		}

		public void SetMaxUserResults(uint value)
		{
		}

		public void SetOrdering(UserOrdering value)
		{
		}

		public void SetRecentlyMetTimeWindow(TimeWindow value)
		{
		}

		public void SetRoomId(ulong value)
		{
		}

		public void SetTurnOffUpdates(bool value)
		{
		}

		public static explicit operator IntPtr(RoomOptions options)
		{
			return default(IntPtr);
		}

		~RoomOptions()
		{
		}

		public RoomOptions()
			: base()
		{
		}
	}
}
