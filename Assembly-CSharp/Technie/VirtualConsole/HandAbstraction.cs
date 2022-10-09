using UnityEngine;

namespace Technie.VirtualConsole
{
	public class HandAbstraction : MonoBehaviour
	{
		public VirtualConsole virtualConsole;

		public Material ballMaterial;

		public Material laserMaterial;

		public Sprite cursorSprite;

		public Material cursorMaterial;

		public XrNodeRig xrRig;

		public PanelManager panelManager;

		private WandInputModule wandInputModule;

		private Hand leftHand;

		private Hand rightHand;

		private UiStylus leftStylus;

		private UiStylus rightStylus;

		private bool wasLeftDown;

		private bool wasRightDown;

		private float findHandsTimer;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void FindHands()
		{
		}

		private UiLaser CreateLaser()
		{
			return null;
		}

		private UiStylus CreateStylus(HandType type, Transform handTransform, WandInputModule inputModule)
		{
			return null;
		}

		private void SetStylusPosition(UiStylus stylus, HandType hand, StylusPosition stylusPosition, Vector3 customStylusPosition)
		{
		}

		public GameObject GetLeftHand()
		{
			return null;
		}

		public GameObject GetRightHand()
		{
			return null;
		}

		public bool HasTarget(HandType targetHand)
		{
			return default(bool);
		}

		public void TriggerInput(HandType targetHand)
		{
		}

		public void SetStylusVisible(bool visible)
		{
		}

		public HandAbstraction()
			: base()
		{
		}
	}
}
