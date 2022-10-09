using System.Collections.Generic;
using UnityEngine;

namespace Technie.VirtualConsole
{
	public class PanelManager : MonoBehaviour
	{
		public XrNodeRig xrRig;

		public VrDebugDisplay templateDisplay;

		public DebugPanel[] panels;

		private List<VrDebugDisplay> displays;

		private bool isInitialised;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void OnHandsDetected(Camera eventCamera)
		{
		}

		private void CreateDisplay(HandType handType, Transform targetHand, Camera eventCamera)
		{
		}

		private VrDebugDisplay FindDisplay(HandType type)
		{
			return null;
		}

		private DebugPanel FindPanel(string panelName)
		{
			return null;
		}

		private void AttachPanel(VrDebugDisplay display, DebugPanel panel)
		{
		}

		public void ChangePanel(int direction, VrDebugDisplay display, DebugPanel currentPanel)
		{
		}

		public void SetDisplaysVisible(bool visible)
		{
		}

		public PanelManager()
			: base()
		{
		}
	}
}
