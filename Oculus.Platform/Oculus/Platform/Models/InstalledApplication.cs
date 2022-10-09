using System;

namespace Oculus.Platform.Models
{
	public class InstalledApplication
	{
		public readonly string ApplicationId;

		public readonly string PackageName;

		public readonly string Status;

		public readonly int VersionCode;

		public readonly string VersionName;

		public InstalledApplication(IntPtr o)
			: base()
		{
		}
	}
}
