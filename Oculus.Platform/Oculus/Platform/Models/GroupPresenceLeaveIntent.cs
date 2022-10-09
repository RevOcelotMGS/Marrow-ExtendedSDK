using System;

namespace Oculus.Platform.Models
{
	public class GroupPresenceLeaveIntent
	{
		public readonly string DestinationApiName;

		public readonly string LobbySessionId;

		public readonly string MatchSessionId;

		public GroupPresenceLeaveIntent(IntPtr o)
			: base()
		{
		}
	}
}
