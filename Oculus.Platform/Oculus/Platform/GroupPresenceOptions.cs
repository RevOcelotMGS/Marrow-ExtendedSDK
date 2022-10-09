using System;

namespace Oculus.Platform
{
	public class GroupPresenceOptions
	{
		private IntPtr Handle;

		public void SetDestinationApiName(string value)
		{
		}

		public void SetIsJoinable(bool value)
		{
		}

		public void SetLobbySessionId(string value)
		{
		}

		public void SetMatchSessionId(string value)
		{
		}

		public static explicit operator IntPtr(GroupPresenceOptions options)
		{
			return default(IntPtr);
		}

		~GroupPresenceOptions()
		{
		}

		public GroupPresenceOptions()
			: base()
		{
		}
	}
}
