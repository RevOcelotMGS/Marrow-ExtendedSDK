using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ
{
	public class AmmoPickupProxy : MonoBehaviour
	{
		private static ComponentCache<AmmoPickupProxy> _cache;

		public AmmoPickup ammoPickup;

		public static ComponentCache<AmmoPickupProxy> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public AmmoPickupProxy()
			: base()
		{
		}
	}
}
