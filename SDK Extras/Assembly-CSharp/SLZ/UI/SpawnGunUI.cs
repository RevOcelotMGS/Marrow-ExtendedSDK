using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.UI
{
	public class SpawnGunUI : MonoBehaviour
	{
		private static SpawnGunUI _instance;

		public GameObject uiSpawnableText;

		public TextMeshProUGUI spawnItemText;

		public Camera uiCamera;

		public RawImage image;

		public Image buttonPromptSprite;

		public Sprite B_Button;

		public Sprite YB_Buttons;

		public static SpawnGunUI Instance
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public SpawnGunUI()
			: base()
		{
		}
	}
}
