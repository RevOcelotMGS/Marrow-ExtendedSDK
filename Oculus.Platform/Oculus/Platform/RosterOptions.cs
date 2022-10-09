using System;

namespace Oculus.Platform
{
	public class RosterOptions
	{
		private IntPtr Handle;

		public void AddSuggestedUser(ulong userID)
		{
		}

		public void ClearSuggestedUsers()
		{
		}

		public static explicit operator IntPtr(RosterOptions options)
		{
			return default(IntPtr);
		}

		~RosterOptions()
		{
		}

		public RosterOptions()
			: base()
		{
		}
	}
}
