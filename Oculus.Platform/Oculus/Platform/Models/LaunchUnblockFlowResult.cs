using System;

namespace Oculus.Platform.Models
{
	public class LaunchUnblockFlowResult
	{
		public readonly bool DidCancel;

		public readonly bool DidUnblock;

		public LaunchUnblockFlowResult(IntPtr o)
			: base()
		{
		}
	}
}
