using UnityEngine;

namespace SLZ.Zones
{
	public class ZoneOcclusion : ZoneItem
	{
		[SerializeField]
		private OcclusionPortal occlusion;

		private void Reset()
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		private void Awake()
		{
		}

		public ZoneOcclusion()
			: base()
		{
		}
	}
}
