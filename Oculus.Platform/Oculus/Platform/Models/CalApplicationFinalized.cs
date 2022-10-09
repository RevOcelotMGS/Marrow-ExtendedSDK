using System;

namespace Oculus.Platform.Models
{
	public class CalApplicationFinalized
	{
		public readonly int CountdownMS;

		public readonly ulong ID;

		public readonly string LaunchDetails;

		public CalApplicationFinalized(IntPtr o)
			: base()
		{
		}
	}
}
