using System;

namespace Oculus.Platform.Models
{
	public class LinkedAccount
	{
		public readonly string AccessToken;

		public readonly ServiceProvider ServiceProvider;

		public readonly string UserId;

		public LinkedAccount(IntPtr o)
			: base()
		{
		}
	}
}
