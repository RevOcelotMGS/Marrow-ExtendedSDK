using System;

namespace Oculus.Platform.Models
{
	public class LaunchBlockFlowResult
	{
		public readonly bool DidBlock;

		public readonly bool DidCancel;

		public LaunchBlockFlowResult(IntPtr o)
			: base()
		{
		}
	}
}
