using UnityEngine;

namespace Technie.VirtualConsole
{
	public class Hand : MonoBehaviour
	{
		public HandType type;

		public Transform trackedTransform;

		private void LateUpdate()
		{
		}

		private void TrackTargetHand()
		{
		}

		public Hand()
			: base()
		{
		}
	}
}
