using System;

namespace Oculus.Platform.Models
{
	public class PurchaseList : DeserializableList<Purchase>
	{
		public PurchaseList(IntPtr a)
			: base()
		{
		}
	}
}
