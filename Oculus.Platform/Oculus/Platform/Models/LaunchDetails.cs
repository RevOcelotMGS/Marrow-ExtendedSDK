using System;

namespace Oculus.Platform.Models
{
	public class LaunchDetails
	{
		public readonly string DeeplinkMessage;

		public readonly string DestinationApiName;

		public readonly string LaunchSource;

		public readonly LaunchType LaunchType;

		public readonly ulong RoomID;

		public readonly string TrackingID;

		public readonly UserList UsersOptional;

		[Obsolete("Deprecated in favor of UsersOptional")]
		public readonly UserList Users;

		public LaunchDetails(IntPtr o)
			: base()
		{
		}
	}
}
