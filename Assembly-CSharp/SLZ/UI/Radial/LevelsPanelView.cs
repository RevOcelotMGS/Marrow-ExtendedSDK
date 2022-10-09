using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data.SaveData;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.UI.Radial
{
	public class LevelsPanelView : PanelView
	{
		private static ComponentCache<LevelsPanelView> _cache;

		[Tooltip("Include levels that are built in with the game")]
		[Header("Level Query")]
		public bool includeInternalLevels;

		[Tooltip("Include levels that are external (mods)")]
		public bool includeExternalLevels;

		public bool isModMenu;

		public bool isSandboxMenu;

		public bool doKeyImages;

		public bool filterByTag;

		public List<string> levelTags;

		[Header("UI Components")]
		public GameObject[] items;

		public TextMeshProUGUI[] text;

		public Image[] keyImage;

		public GameObject forwardButton;

		public GameObject backButton;

		public TextMeshProUGUI pageText;

		public bool useSceneImage;

		public Image[] sceneImage;

		public Sprite[] m_SceneSprite;

		public LevelCrateReference loadScreen_Internal;

		public LevelCrateReference loadScreen_MODMAP;

		private int m_TotalScenes;

		private int m_NumberOfPages;

		private int m_CurrentPage;

		private LevelCrate[] m_LevelCrates;

		private List<LevelCrate> levelCrates;

		private LevelCrateReference[] keyLevelCrates;

		private LevelCrateReference kartRaceRef;

		[Tooltip("Optional: Forward level load event to DoorPortalController")]
		public DoorPortalController doorPortalController;

		public GameObject uiTrigger;

		public int doorPortalIndex;

		public static ComponentCache<LevelsPanelView> Cache
		{
			get
			{
				return null;
			}
		}

		private static PlayerProgression p
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPalletAdded(string palletBarcode)
		{
		}

		private void CalculateSceneList()
		{
		}

		private void OnDestroy()
		{
		}

		[ContextMenu("Load First Level")]
		public void LoadFirstLevel()
		{
		}

		public void SelectItem(int idx)
		{
		}

		public override void Activate()
		{
		}

		public UniTaskVoid PopulateMenuAsync()
		{
			return default(UniTaskVoid);
		}

		private void PopulateMenu()
		{
		}

		private void UpdatePageItems(int pageIdx, int maxItems)
		{
		}

		private void UpdatePageText(int idx, int total)
		{
		}

		public void NextPage()
		{
		}

		public void PrevPage()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		public static void Startup()
		{
		}

		public LevelsPanelView()
			: base()
		{
		}
	}
}
