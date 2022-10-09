using UnityEngine;

namespace Technie.VirtualConsole
{
	public class UiStylus : MonoBehaviour
	{
		public Material laserMaterial;

		public Material ballMaterial;

		public HandType handType;

		public WandInputModule inputModule;

		private VrDebugDisplay[] displays;

		private GameObject sphereObj;

		private GameObject laserObj;

		private bool isButtonDown;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SetVisualEnabled(bool visible)
		{
		}

		private VrDebugDisplay FindClosestDisplay()
		{
			return null;
		}

		public bool IsPointingAtPanel()
		{
			return default(bool);
		}

		public UiStylus()
			: base()
		{
		}
	}
}
