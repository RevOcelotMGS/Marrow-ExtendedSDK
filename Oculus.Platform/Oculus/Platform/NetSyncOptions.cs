using System;

namespace Oculus.Platform
{
	public class NetSyncOptions
	{
		private IntPtr Handle;

		public void SetVoipGroup(string value)
		{
		}

		public void SetVoipStreamDefault(NetSyncVoipStreamMode value)
		{
		}

		public void SetZoneId(string value)
		{
		}

		public static explicit operator IntPtr(NetSyncOptions options)
		{
			return default(IntPtr);
		}

		~NetSyncOptions()
		{
		}

		public NetSyncOptions()
			: base()
		{
		}
	}
}
