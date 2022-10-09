using System;

namespace Oculus.Platform.Models
{
	public class Destination
	{
		public readonly string ApiName;

		public readonly string DeeplinkMessage;

		public readonly string DisplayName;

		public Destination(IntPtr o)
			: base()
		{
		}
	}
}
