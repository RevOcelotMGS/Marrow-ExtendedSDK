using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithProductList : Message<ProductList>
	{
		public MessageWithProductList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override ProductList GetProductList()
		{
			return null;
		}

		protected override ProductList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
