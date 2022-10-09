using UnityEngine;

namespace SLZ.Zones
{
	public class ZoneEnabler : ZoneItem
	{
		[SerializeField]
		private bool PrimeZoneOnly;

		[SerializeField]
		private GameObject[] Objects;

		private void Start()
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneExited(GameObject playerObject)
		{
		}

		private void SetActive(bool isActive)
		{
		}

		public ZoneEnabler()
			: base()
		{
		}
	}
}
