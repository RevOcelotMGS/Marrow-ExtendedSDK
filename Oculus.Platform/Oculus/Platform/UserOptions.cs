using System;

namespace Oculus.Platform
{
	public class UserOptions
	{
		private IntPtr Handle;

		public void SetMaxUsers(uint value)
		{
		}

		public void AddServiceProvider(ServiceProvider value)
		{
		}

		public void ClearServiceProviders()
		{
		}

		public void SetTimeWindow(TimeWindow value)
		{
		}

		public static explicit operator IntPtr(UserOptions options)
		{
			return default(IntPtr);
		}

		~UserOptions()
		{
		}

		public UserOptions()
			: base()
		{
		}
	}
}
