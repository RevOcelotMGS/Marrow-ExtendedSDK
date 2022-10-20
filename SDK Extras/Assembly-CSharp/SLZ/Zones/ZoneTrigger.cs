using System;
using UnityEngine;

namespace SLZ.Zones
{
	public class ZoneTrigger : MonoBehaviour
	{
		public Action<SceneZone> zoneEnterDelegate;

		public Action<SceneZone> zoneExitDelegate;

		[SerializeField]
		private bool isZoneTriggerActive;

		public void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public ZoneTrigger()
			: base()
		{
		}
	}
}
