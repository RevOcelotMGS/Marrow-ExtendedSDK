using System;

namespace Oculus.Platform
{
	public class RichPresenceOptions
	{
		private IntPtr Handle;

		public void SetApiName(string value)
		{
		}

		public void SetCurrentCapacity(uint value)
		{
		}

		public void SetDeeplinkMessageOverride(string value)
		{
		}

		public void SetEndTime(DateTime value)
		{
		}

		public void SetExtraContext(RichPresenceExtraContext value)
		{
		}

		public void SetInstanceId(string value)
		{
		}

		public void SetIsIdle(bool value)
		{
		}

		public void SetIsJoinable(bool value)
		{
		}

		public void SetMaxCapacity(uint value)
		{
		}

		public void SetStartTime(DateTime value)
		{
		}

		public static explicit operator IntPtr(RichPresenceOptions options)
		{
			return default(IntPtr);
		}

		~RichPresenceOptions()
		{
		}

		public RichPresenceOptions()
			: base()
		{
		}
	}
}
