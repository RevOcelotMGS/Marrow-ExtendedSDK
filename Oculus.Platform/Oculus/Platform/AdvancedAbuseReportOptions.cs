using System;

namespace Oculus.Platform
{
	public class AdvancedAbuseReportOptions
	{
		private IntPtr Handle;

		public void SetObjectType(string value)
		{
		}

		public void SetReportType(AbuseReportType value)
		{
		}

		public void SetVideoMode(AbuseReportVideoMode value)
		{
		}

		public static explicit operator IntPtr(AdvancedAbuseReportOptions options)
		{
			return default(IntPtr);
		}

		~AdvancedAbuseReportOptions()
		{
		}

		public AdvancedAbuseReportOptions()
			: base()
		{
		}
	}
}
