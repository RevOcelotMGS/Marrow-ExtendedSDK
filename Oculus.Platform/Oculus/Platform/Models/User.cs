using System;

namespace Oculus.Platform.Models
{
	public class User
	{
		public readonly string DisplayName;

		public readonly ulong ID;

		public readonly string ImageURL;

		public readonly string InviteToken;

		public readonly string OculusID;

		public readonly string Presence;

		public readonly string PresenceDeeplinkMessage;

		public readonly string PresenceDestinationApiName;

		public readonly string PresenceLobbySessionId;

		public readonly string PresenceMatchSessionId;

		public readonly UserPresenceStatus PresenceStatus;

		public readonly string SmallImageUrl;

		public User(IntPtr o)
			: base()
		{
		}
	}
}
