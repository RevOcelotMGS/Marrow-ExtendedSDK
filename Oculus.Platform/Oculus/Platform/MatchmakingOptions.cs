using System;

namespace Oculus.Platform
{
	public class MatchmakingOptions
	{
		private IntPtr Handle;

		public void SetCreateRoomDataStore(string key, string value)
		{
		}

		public void ClearCreateRoomDataStore()
		{
		}

		public void SetCreateRoomJoinPolicy(RoomJoinPolicy value)
		{
		}

		public void SetCreateRoomMaxUsers(uint value)
		{
		}

		public void AddEnqueueAdditionalUser(ulong userID)
		{
		}

		public void ClearEnqueueAdditionalUsers()
		{
		}

		public void SetEnqueueDataSettings(string key, int value)
		{
		}

		public void SetEnqueueDataSettings(string key, double value)
		{
		}

		public void SetEnqueueDataSettings(string key, string value)
		{
		}

		public void ClearEnqueueDataSettings()
		{
		}

		public void SetEnqueueIsDebug(bool value)
		{
		}

		public void SetEnqueueQueryKey(string value)
		{
		}

		public static explicit operator IntPtr(MatchmakingOptions options)
		{
			return default(IntPtr);
		}

		~MatchmakingOptions()
		{
		}

		public MatchmakingOptions()
			: base()
		{
		}
	}
}
