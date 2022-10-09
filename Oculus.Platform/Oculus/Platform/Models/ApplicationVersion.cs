using System;

namespace Oculus.Platform.Models
{
	public class ApplicationVersion
	{
		public readonly int CurrentCode;

		public readonly string CurrentName;

		public readonly int LatestCode;

		public readonly string LatestName;

		public ApplicationVersion(IntPtr o)
			: base()
		{
		}
	}
}
