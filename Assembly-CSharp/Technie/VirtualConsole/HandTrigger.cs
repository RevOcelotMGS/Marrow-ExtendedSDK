using UnityEngine;

namespace Technie.VirtualConsole
{
	public class HandTrigger : MonoBehaviour
	{
		public BoxCollider area;

		private XrNodeRig xrRig;

		private bool wasInBox;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private bool IsInBox(GameObject obj)
		{
			return default(bool);
		}

		public virtual void OnHandEntered()
		{
		}

		public HandTrigger()
			: base()
		{
		}
	}
}
