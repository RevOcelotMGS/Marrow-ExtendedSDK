using UnityEngine;

namespace RootMotion
{
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		public GameObject target;

		private void OnTriggerEnter(Collider collider)
		{
		}

		private void OnTriggerStay(Collider collider)
		{
		}

		private void OnTriggerExit(Collider collider)
		{
		}

		public TriggerEventBroadcaster()
			: base()
		{
		}
	}
}
