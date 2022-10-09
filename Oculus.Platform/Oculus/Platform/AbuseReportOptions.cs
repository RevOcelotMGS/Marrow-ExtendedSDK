using System;

namespace Oculus.Platform
{
	public class AbuseReportOptions
	{
		private IntPtr Handle;

		public void SetPreventPeopleChooser(bool value)
		{
		}

		public void SetReportType(AbuseReportType value)
		{
		}

		public static explicit operator IntPtr(AbuseReportOptions options)
		{
			return default(IntPtr);
		}

		~AbuseReportOptions()
		{
		}

		public AbuseReportOptions()
			: base()
		{
		}
	}
}
