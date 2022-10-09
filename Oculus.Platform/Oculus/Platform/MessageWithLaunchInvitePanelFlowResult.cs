using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLaunchInvitePanelFlowResult : Message<LaunchInvitePanelFlowResult>
	{
		public MessageWithLaunchInvitePanelFlowResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override LaunchInvitePanelFlowResult GetLaunchInvitePanelFlowResult()
		{
			return null;
		}

		protected override LaunchInvitePanelFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
