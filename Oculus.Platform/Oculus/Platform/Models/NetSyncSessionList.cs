using System;

namespace Oculus.Platform.Models
{
	public class NetSyncSessionList : DeserializableList<NetSyncSession>
	{
		public NetSyncSessionList(IntPtr a)
			: base()
		{
		}
	}
}
