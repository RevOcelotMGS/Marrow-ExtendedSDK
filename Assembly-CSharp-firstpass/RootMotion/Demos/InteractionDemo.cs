using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class InteractionDemo : MonoBehaviour
	{
		public InteractionSystem interactionSystem;

		public bool interrupt;

		public InteractionObject ball;

		public InteractionObject benchMain;

		public InteractionObject benchHands;

		public InteractionObject button;

		public InteractionObject cigarette;

		public InteractionObject door;

		private bool isSitting;

		private void OnGUI()
		{
		}

		public InteractionDemo()
			: base()
		{
		}
	}
}
