using System;

namespace Oculus.Platform.Models
{
	public class PartyUpdateNotification
	{
		public readonly PartyUpdateAction Action;

		public readonly ulong PartyId;

		public readonly ulong SenderId;

		public readonly string UpdateTimestamp;

		public readonly string UserAlias;

		public readonly ulong UserId;

		public readonly string UserName;

		public PartyUpdateNotification(IntPtr o)
			: base()
		{
		}
	}
}
