using System;

namespace Oculus.Platform.Models
{
	public class Leaderboard
	{
		public readonly string ApiName;

		public readonly Destination DestinationOptional;

		[Obsolete("Deprecated in favor of DestinationOptional")]
		public readonly Destination Destination;

		public readonly ulong ID;

		public Leaderboard(IntPtr o)
			: base()
		{
		}
	}
}
