using System;

namespace Oculus.Platform
{
	public class MultiplayerErrorOptions
	{
		private IntPtr Handle;

		public void SetErrorKey(MultiplayerErrorErrorKey value)
		{
		}

		public static explicit operator IntPtr(MultiplayerErrorOptions options)
		{
			return default(IntPtr);
		}

		~MultiplayerErrorOptions()
		{
		}

		public MultiplayerErrorOptions()
			: base()
		{
		}
	}
}
