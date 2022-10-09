using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLaunchUnblockFlowResult : Message<LaunchUnblockFlowResult>
	{
		public MessageWithLaunchUnblockFlowResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override LaunchUnblockFlowResult GetLaunchUnblockFlowResult()
		{
			return null;
		}

		protected override LaunchUnblockFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
