using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data.SaveData;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.VRMK;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SLZ.UI.Radial
{
	public class AvatarsPanelView : PanelView
	{
		private static ComponentCache<AvatarsPanelView> _cache;

		public GameObject canvas;

		[Header("Avatar Query")]
		[Tooltip("Include avatars that are built in with the game")]
		public bool includeInternalAvatars;

		[Tooltip("Include avatars that are external (mods)")]
		public bool includeExternalAvatars;

		public bool filterByTag;

		public List<string> avatarTags;

		public bool favoritesMode;

		[Header("Avatar List UI Components")]
		public GameObject[] items;

		public TextMeshProUGUI[] text;

		public GameObject forwardButton;

		public GameObject backButton;

		public TextMeshProUGUI pageText;

		private AvatarCrate avatarSelection;

		[Header("Favorites UI Components")]
		public GameObject[] itemsSlots;

		public TextMeshProUGUI[] textSlots;

		public AvatarCrate[] avatarFavorites;

		public int slotSlection;

		public GameObject[] slotHighlights;

		[Header("Stats UI Components")]
		public SpiderChart spiderChart;

		[Header("General UI Components")]
		public GameObject avatarPage;

		public GameObject statsPage;

		public GameObject favoritePage;

		public GameObject prompPage;

		public PullCordDevice bodyLog;

		public GameObject bodylogLock;

		private int lastTab;

		public bool useSceneImage;

		public Image[] sceneImage;

		public Sprite[] m_SceneSprite;

		private int m_TotalAvatars;

		private int m_NumberOfPages;

		private int m_CurrentPage;

		private AvatarCrate[] m_AvatarCrates;

		[HideInInspector]
		private RigManager rigManager;

		public TriggerLasers rigManagerFetcher;

		public bool enabledOnStart;

		[Header("Avatar Preview")]
		public bool isBodyMall;

		public Transform previewTransform;

		[SerializeField]
		private BonelabSerializableDictionaries.StringAvatarDictionary cachedPreviews;

		private SLZ.VRMK.Avatar previewAvatar;

		[Header("Prompt Components")]
		public Renderer[] lights;

		public Material[] lightMats;

		public RectTransform[] arrow;

		private IEnumerator promptCycle;

		private List<AvatarCrate> avatarCrates;

		private List<string> defaultFavoriteAvatarsBarcodes;

		private List<string> defaultPeasantBarcodes;

		public UnityEvent pullCordInserted;

		public UnityEvent pullCordRemoved;

		public UnityEvent insertPromptStart;

		public UnityEvent insertPromptStop;

		public static ComponentCache<AvatarsPanelView> Cache
		{
			get
			{
				return null;
			}
		}

		private static PlayerUnlocks u
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void Start()
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

		public void SwitchTab(int tab)
		{
		}

		public void NextPage()
		{
		}

		public void PrevPage()
		{
		}

		public void SelectItem(int idx)
		{
		}

		public void ConfirmSelection()
		{
		}

		public void SelectSlot(int i)
		{
		}

		public void BodyLogSet()
		{
		}

		public void DisconnectBodyLog(bool inHand = false)
		{
		}

		private void CalculateSceneList()
		{
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		private void OnDestroy()
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

		private IEnumerator PromptCycle()
		{
			return null;
		}

		private UniTaskVoid LoadFavoriteAvatars()
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		private UniTask SwapReflectionAvatar(string barcode)
		{
			return default(UniTask);
		}

		public AvatarsPanelView()
			: base()
		{
		}
	}
}
