using System;

namespace Oculus.Platform
{
	public class ApplicationOptions
	{
		private IntPtr Handle;

		public void SetDeeplinkMessage(string value)
		{
		}

		public static explicit operator IntPtr(ApplicationOptions options)
		{
			return default(IntPtr);
		}

		~ApplicationOptions()
		{
		}

		public ApplicationOptions()
			: base()
		{
		}
	}
}
