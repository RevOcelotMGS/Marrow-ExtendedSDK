using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithNetworkingPeer : Message<NetworkingPeer>
	{
		public MessageWithNetworkingPeer(IntPtr c_message)
			: base(c_message)
		{
		}

		public override NetworkingPeer GetNetworkingPeer()
		{
			return null;
		}

		protected override NetworkingPeer GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
