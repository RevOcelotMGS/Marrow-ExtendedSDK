using System;

namespace Oculus.Platform.Models
{
	public class ApplicationInvite
	{
		public readonly Destination DestinationOptional;

		[Obsolete("Deprecated in favor of DestinationOptional")]
		public readonly Destination Destination;

		public readonly ulong ID;

		public readonly bool IsActive;

		public readonly string LobbySessionId;

		public readonly string MatchSessionId;

		public readonly User RecipientOptional;

		[Obsolete("Deprecated in favor of RecipientOptional")]
		public readonly User Recipient;

		public ApplicationInvite(IntPtr o)
			: base()
		{
		}
	}
}
