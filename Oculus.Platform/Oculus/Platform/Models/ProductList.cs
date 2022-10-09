using System;

namespace Oculus.Platform.Models
{
	public class ProductList : DeserializableList<Product>
	{
		public ProductList(IntPtr a)
			: base()
		{
		}
	}
}
