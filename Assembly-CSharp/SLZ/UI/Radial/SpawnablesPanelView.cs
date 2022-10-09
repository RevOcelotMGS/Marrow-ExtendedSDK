using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data.SaveData;
using SLZ.Marrow.Warehouse;
using SLZ.Props.Weapons;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.UI.Radial
{
	public class SpawnablesPanelView : PanelView
	{
		public delegate void SelectSpawnableDelegate(SpawnableCrate data);

		public delegate void SelectUtilityModeDelegate(UtilityModes mode);

		public GameObject[] items;

		public GameObject[] tagItems;

		public GameObject[] tabItems;

		public TextMeshPro[] text;

		public TextMeshPro[] tagText;

		public Image[] itemBackgrounds;

		public Image[] itemStars;

		public Image[] catItemBackgrounds;

		public Image[] tabImageBackgrounds;

		public GameObject spawnSelectPage;

		public GameObject utilitySelectPage;

		public GameObject forwardButton;

		public GameObject backButton;

		public TextMeshPro pageText;

		public GameObject tagBackButton;

		public GameObject tagForwardButton;

		public TextMeshPro tagPageText;

		public TextMeshProUGUI favoriteText;

		public Image favoriteImage;

		[HideInInspector]
		public SpawnableCrate selectedObject;

		private Dictionary<string, SpawnableCrate> favoriteCrates;

		private int _numberOfPages;

		private int _numberOfTagPages;

		private int _currentPage;

		private int _currentTagPage;

		private string _selectedTag;

		private string _selectedItemTag;

		private int _selectedTabIndex;

		private int _selectedTagIndex;

		private int _selectedItemIndex;

		private int _selectedItem;

		private List<string> _activeTags;

		public Dictionary<string, List<SpawnableCrate>> SpawnablesQuickMap { get; private set; }

		public SpawnGun spawnGun { private get; set; }

		private static PlayerSettings p
		{
			get
			{
				return null;
			}
		}

		public void SelectTab(int idx)
		{
		}

		public void SelectItem(int idx)
		{
		}

		public void SelectMode(int mode)
		{
		}

		public void SelectCategory(int idx)
		{
		}

		private void HighlightProperSpawnItem()
		{
		}

		public override void Activate()
		{
		}

		private void PopulateMenu()
		{
		}

		public void GenerateCategoriesMapping()
		{
		}

		private void UpdatePageItems(int pageIdx, int maxItems)
		{
		}

		private void UpdateTagPageItems(int tagPageIdx, int maxTagItems)
		{
		}

		private void UpdatePageText(int idx, int total)
		{
		}

		private void UpdateTagPageText(int idx, int total)
		{
		}

		public void NextTagPage()
		{
		}

		public void PrevTagPage()
		{
		}

		public void NextPage()
		{
		}

		public void PrevPage()
		{
		}

		public void FavoriteItem()
		{
		}

		private UniTaskVoid LoadFavorites()
		{
			return default(UniTaskVoid);
		}

		public void SaveFavorites()
		{
		}

		public SpawnablesPanelView()
			: base()
		{
		}

		public event SelectSpawnableDelegate selectSpawnableDelegate;

		public event SelectUtilityModeDelegate selectModeDelegate;
	}
}
