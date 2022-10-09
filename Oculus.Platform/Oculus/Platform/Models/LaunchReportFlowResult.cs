using System;

namespace Oculus.Platform.Models
{
	public class LaunchReportFlowResult
	{
		public readonly bool DidCancel;

		public readonly ulong UserReportId;

		public LaunchReportFlowResult(IntPtr o)
			: base()
		{
		}
	}
}
