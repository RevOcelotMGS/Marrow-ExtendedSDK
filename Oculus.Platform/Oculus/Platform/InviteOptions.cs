using System;

namespace Oculus.Platform
{
	public class InviteOptions
	{
		private IntPtr Handle;

		public void AddSuggestedUser(ulong userID)
		{
		}

		public void ClearSuggestedUsers()
		{
		}

		public static explicit operator IntPtr(InviteOptions options)
		{
			return default(IntPtr);
		}

		~InviteOptions()
		{
		}

		public InviteOptions()
			: base()
		{
		}
	}
}
