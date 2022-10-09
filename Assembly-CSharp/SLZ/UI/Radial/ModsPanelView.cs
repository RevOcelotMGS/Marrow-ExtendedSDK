using SLZ.Marrow.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.UI.Radial
{
	public class ModsPanelView : PanelView
	{
		private static ComponentCache<ModsPanelView> _cache;

		public GameObject[] items;

		public TextMeshPro[] text;

		public Image[] sceneImage;

		public Sprite[] m_SceneSprite;

		public Sprite defaultSceneSprite;

		public bool useSceneImage;

		public GameObject forwardButton;

		public GameObject backButton;

		public TextMeshPro pageText;

		public int[] sceneBlacklist;

		private int m_TotalScenes;

		private int m_NumberOfPages;

		private int m_CurrentPage;

		private string[] m_SceneNames;

		private string[] m_ScenePaths;

		public static ComponentCache<ModsPanelView> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void CalculateSceneList()
		{
		}

		private void OnDestroy()
		{
		}

		public void SelectItem(int idx)
		{
		}

		public override void Activate()
		{
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

		public ModsPanelView()
			: base()
		{
		}
	}
}
