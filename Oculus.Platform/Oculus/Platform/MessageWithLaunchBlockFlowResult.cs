using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLaunchBlockFlowResult : Message<LaunchBlockFlowResult>
	{
		public MessageWithLaunchBlockFlowResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override LaunchBlockFlowResult GetLaunchBlockFlowResult()
		{
			return null;
		}

		protected override LaunchBlockFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
