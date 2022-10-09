using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace SLZ.Marrow.Warehouse
{
	public class AssetWarehouse
	{
		[Serializable]
		public struct PalletManifest
		{
			[SerializeField]
			public Pallet pallet;

			[SerializeField]
			public IResourceLocator catalog;

			[SerializeField]
			public string catalogPath;

			public bool active;
		}

		public class HideLevelCrateFilter : ICrateFilter<LevelCrate>
		{
			public bool Filter(LevelCrate crate)
			{
				return default(bool);
			}

			public HideLevelCrateFilter()
				: base()
			{
			}
		}

		public static AssetWarehouse Instance;

		public static bool ready;

		private static Action _onReady;

		private readonly Dictionary<Barcode, PalletManifest> warehouseManifest;

		private Dictionary<Barcode, Scannable> internalPallets;

		private readonly Dictionary<Barcode, Scannable> _inventoryRegistry;

		private readonly Dictionary<Barcode, Scannable> _oldBarcodeInventoryRegistry;

		private readonly Dictionary<MarrowGuid, Scannable> _slimCodeInventoryRegistry;

		[ReadOnly(false)]
		[SerializeField]
		private List<string> _allTags;

		[ReadOnly(false)]
		[SerializeField]
		private bool _initialLoaded;

		public static readonly string INTERNAL_PALLET_GROUP_NAME;

		public static readonly string INTERNAL_PALLET_LABEL;

		public Action OnChanged;

		public Action<string> OnPalletAdded;

		public Action<string> OnCrateAdded;

		public Dictionary<Barcode, Scannable> InventoryRegistry
		{
			get
			{
				return null;
			}
		}

		public List<string> AllTags
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool InitialLoaded
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public static void OnReady(Action callbackWhenReady)
		{
		}

		public UniTask InitAsync()
		{
			return default(UniTask);
		}

		private void Init()
		{
		}

		public AssetWarehouse(bool autoInit = true)
			: base()
		{
		}

		~AssetWarehouse()
		{
		}

		public void Clear()
		{
		}

		private UniTask LoadInitialPalletsAsync()
		{
			return default(UniTask);
		}

		public Crate GetCrate(Barcode barcode)
		{
			return null;
		}

		public T GetCrate<T>(string barcode) where T : Crate
		{
			return null;
		}

		public UniTask<T> GetCrateAsync<T>(string barcode, Action<T> callback = default(Action<T>)) where T : Crate
		{
			return default(UniTask<T>);
		}

		public UniTask<Crate> GetCrateAsync(string barcode, Action<Crate> callback = default(Action<Crate>), CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Crate>);
		}

		public bool TryGetPallet(string barcode, [Out] Pallet pallet)
		{
			return default(bool);
		}

		public bool TryGetPallet(MarrowGuid slimCode, [Out] Pallet pallet)
		{
			return default(bool);
		}

		public bool TryGetCrate(string barcode, [Out] Crate crate)
		{
			return default(bool);
		}

		public bool TryGetCrate<T>(string barcode, [Out] T crateT) where T : Crate
		{
			return default(bool);
		}

		public bool TryGetCrate<T>(MarrowGuid slimCode, [Out] T crateT) where T : Crate
		{
			return default(bool);
		}

		public bool TryGetScannable(string barcode, [Out] Scannable scannable)
		{
			return default(bool);
		}

		public bool TryGetScannable<T>(string barcode, [Out] T scannableT) where T : Scannable
		{
			return default(bool);
		}

		public bool TryGetScannable<T>(MarrowGuid slimCode, [Out] T scannableT) where T : Scannable
		{
			return default(bool);
		}

		public bool TryGetSlimCode(string barcode, [Out] MarrowGuid slimCode)
		{
			return default(bool);
		}

		public bool HasScannable<T>(string barcode) where T : Scannable
		{
			return default(bool);
		}

		public bool HasScannable(string barcode)
		{
			return default(bool);
		}

		public bool HasCrate<T>(string barcode) where T : Crate
		{
			return default(bool);
		}

		public bool HasCrate(string barcode)
		{
			return default(bool);
		}

		public bool HasPallet(string barcode)
		{
			return default(bool);
		}

		public bool UnloadCrateAsset(string barcode, bool forcedUnload = false, bool forceUnloadPackedAssets = false)
		{
			return default(bool);
		}

		public bool UnloadCrateAsset(Crate crate, bool forcedUnload = false, bool forceUnloadPackedAssets = false)
		{
			return default(bool);
		}

		public int UnloadAllCrateAssets(string excludeBarcode = "", bool forcedUnload = false, bool forceUnloadPackedAssets = false)
		{
			return default(int);
		}

		public void UnloadCrate(string barcode)
		{
		}

		public void UnloadCrate(Crate crate)
		{
		}

		private void AddPallet(Pallet pallet, string catalogPath = "")
		{
		}

		private void AddCrate(Crate crate)
		{
		}

		private bool AddScannable(Scannable item)
		{
			return default(bool);
		}

		public void ReloadPallet(string barcode)
		{
		}

		public void UnloadPallet(string barcode)
		{
		}

		public void UnloadPallet(Pallet pallet)
		{
		}

		public void UnloadAllPallets()
		{
		}

		public void DeletePallet(string barcode)
		{
		}

		public void DeletePallet(Pallet pallet)
		{
		}

		private void AddTags(List<string> newTags)
		{
		}

		public List<Pallet> GetPallets()
		{
			return null;
		}

		public void GetPallets(List<Pallet> pallets)
		{
		}

		public List<Crate> GetCrates()
		{
			return null;
		}

		public void GetCrates([In] List<Crate> crates)
		{
		}

		public List<T> FilterCrates<T>(List<T> crateList, ICrateFilter<T> crateFilter) where T : Crate
		{
			return null;
		}

		public List<T> GetCrates<T>(ICrateFilter<T> crateFilter = default(ICrateFilter<T>)) where T : Crate
		{
			return null;
		}

		public void TestQueries()
		{
		}

		public static void LogVerbose(string text, bool logInRuntime = false)
		{
		}

		public void LoadPalletsFromModsFolder()
		{
		}

		public UniTask LoadPalletsFromModsFolderAsync()
		{
			return default(UniTask);
		}

		public void LoadInternalBuiltPallets()
		{
		}

		public UniTask LoadInternalBuiltPalletsAsync()
		{
			return default(UniTask);
		}

		public void LoadPalletsFromSLZServer()
		{
		}

		public UniTask LoadPalletsFromSLZServerAsync()
		{
			return default(UniTask);
		}

		public UniTask LoadPalletsFromFolderAsync(string path)
		{
			return default(UniTask);
		}

		public UniTask<bool> LoadPalletFromFolderAsync(string palletPath, bool updateCatalog = false)
		{
			return default(UniTask<bool>);
		}

		public UniTask<bool> LoadPalletFromText(string palletJsonText)
		{
			return default(UniTask<bool>);
		}

		public UniTask<bool> LoadPalletAsync(Pallet pallet, string palletPath = "", bool updateCatalog = false)
		{
			return default(UniTask<bool>);
		}
	}
}
