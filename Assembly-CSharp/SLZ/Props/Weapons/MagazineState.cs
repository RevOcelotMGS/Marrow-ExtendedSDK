using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SLZ.Marrow.Data;

namespace SLZ.Props.Weapons
{
	[Serializable]
	public class MagazineState
	{
		public MagazineData magazineData;

		public CartridgeData cartridgeData;

		private List<CartridgeData> _cartridges;

		public Action<int> onAmmoChange;

		public int AmmoCount
		{
			get
			{
				return default(int);
			}
		}

		public void Initialize(CartridgeData catridgeData, int ammoCount)
		{
		}

		public void Refill()
		{
		}

		public CartridgeData PullCartridge()
		{
			return null;
		}

		public void SetCartridge(int count)
		{
		}

		public void AddCartridge(int count, CartridgeData cart = default(CartridgeData))
		{
		}

		public void ClearMagazine()
		{
		}

		public CartridgeData GetCartridgeData()
		{
			return null;
		}

		public MagazineState()
			: base()
		{
		}
	}
}
