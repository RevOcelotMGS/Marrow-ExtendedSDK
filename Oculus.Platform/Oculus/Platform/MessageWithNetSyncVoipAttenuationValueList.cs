using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithNetSyncVoipAttenuationValueList : Message<NetSyncVoipAttenuationValueList>
	{
		public MessageWithNetSyncVoipAttenuationValueList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override NetSyncVoipAttenuationValueList GetNetSyncVoipAttenuationValueList()
		{
			return null;
		}

		protected override NetSyncVoipAttenuationValueList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
