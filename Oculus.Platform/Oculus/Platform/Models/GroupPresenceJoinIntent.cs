using System;

namespace Oculus.Platform.Models
{
	public class GroupPresenceJoinIntent
	{
		public readonly string DeeplinkMessage;

		public readonly string DestinationApiName;

		public readonly string LobbySessionId;

		public readonly string MatchSessionId;

		public GroupPresenceJoinIntent(IntPtr o)
			: base()
		{
		}
	}
}
