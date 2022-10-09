using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Data;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Player
{
	public class AmmoInventory : MonoBehaviour
	{
		[Header("AMMO")]
		public InventoryAmmoReceiver ammoReceiver;

		public AmmoGroup lightAmmoGroup;

		public AmmoGroup mediumAmmoGroup;

		public AmmoGroup heavyAmmoGroup;

		public Action onAmmoUpdate;

		public Action<string, int> onAmmoUpdateCount;

		private Dictionary<string, int> _groupCounts;

		private Dictionary<string, string> _cartridgeToKey;

		private Dictionary<string, int> _AmmoCountsByCartridge;

		private Dictionary<CartridgeData, int> _cartridgeCounts;

		public static AmmoInventory Instance { get; private set; }

		private void Awake()
		{
		}

		private void RegisterAmmoGroup(AmmoGroup ammoGroup)
		{
		}

		public void ClearAmmo()
		{
		}

		public int GetCartridgeCount(CartridgeData cartridge)
		{
			return default(int);
		}

		public int GetCartridgeCount(string groupKey)
		{
			return default(int);
		}

		public void AddCartridge(CartridgeData cartridge, int count)
		{
		}

		public void AddCartridge(AmmoGroup ammoGroup, int count)
		{
		}

		public void RemoveCartridge(CartridgeData cartridge, int count)
		{
		}

		public string GetGroupByCartridge(CartridgeData cartridge)
		{
			return null;
		}

		public AmmoInventory()
			: base()
		{
		}
	}
}
