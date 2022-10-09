using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLaunchFriendRequestFlowResult : Message<LaunchFriendRequestFlowResult>
	{
		public MessageWithLaunchFriendRequestFlowResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override LaunchFriendRequestFlowResult GetLaunchFriendRequestFlowResult()
		{
			return null;
		}

		protected override LaunchFriendRequestFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
