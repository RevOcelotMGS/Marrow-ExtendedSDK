using System;

namespace Oculus.Platform.Models
{
	public class SdkAccount
	{
		public readonly SdkAccountType AccountType;

		public readonly ulong UserId;

		public SdkAccount(IntPtr o)
			: base()
		{
		}
	}
}
