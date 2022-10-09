using System;

namespace Oculus.Platform.Models
{
	public class Purchase
	{
		public readonly DateTime ExpirationTime;

		public readonly DateTime GrantTime;

		public readonly string ID;

		public readonly string Sku;

		public Purchase(IntPtr o)
			: base()
		{
		}
	}
}
