using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Parties
	{
		public static Request<Party> GetCurrent()
		{
			return null;
		}

		public static void SetPartyUpdateNotificationCallback(Message<PartyUpdateNotification>.Callback callback)
		{
		}
	}
}
