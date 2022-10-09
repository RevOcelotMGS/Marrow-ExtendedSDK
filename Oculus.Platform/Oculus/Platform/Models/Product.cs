using System;

namespace Oculus.Platform.Models
{
	public class Product
	{
		public readonly string Description;

		public readonly string FormattedPrice;

		public readonly string Name;

		public readonly string Sku;

		public Product(IntPtr o)
			: base()
		{
		}
	}
}
