using System.Runtime.InteropServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Application
	{
		public static Request<ApplicationVersion> GetVersion()
		{
			return null;
		}

		public static Request<string> LaunchOtherApp(ulong appID, ApplicationOptions deeplink_options = default(ApplicationOptions))
		{
			return null;
		}
	}
}
