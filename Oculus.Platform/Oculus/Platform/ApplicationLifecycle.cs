using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class ApplicationLifecycle
	{
		public static LaunchDetails GetLaunchDetails()
		{
			return null;
		}

		public static void LogDeeplinkResult(string trackingID, LaunchResult result)
		{
		}

		public static void SetLaunchIntentChangedNotificationCallback(Message<string>.Callback callback)
		{
		}
	}
}
