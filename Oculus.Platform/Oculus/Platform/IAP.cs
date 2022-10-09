using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class IAP
	{
		public static Request ConsumePurchase(string sku)
		{
			return null;
		}

		public static Request<ProductList> GetProductsBySKU(string[] skus)
		{
			return null;
		}

		public static Request<PurchaseList> GetViewerPurchases()
		{
			return null;
		}

		public static Request<PurchaseList> GetViewerPurchasesDurableCache()
		{
			return null;
		}

		public static Request<Purchase> LaunchCheckoutFlow(string sku)
		{
			return null;
		}

		public static Request<ProductList> GetNextProductListPage(ProductList list)
		{
			return null;
		}

		public static Request<PurchaseList> GetNextPurchaseListPage(PurchaseList list)
		{
			return null;
		}
	}
}
