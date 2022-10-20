using SLZ.Rig;
using UnityEngine;

namespace SLZ.Zones
{
	public class ZoneCheckpoint : ZoneItem
	{
		public bool onlySetOnce;

		public bool setOnEnter;

		public bool setOnExit;

		public bool alignForwardOnPort;

		private bool _hasSetOnce;

		private void Set(RigManager rigManager)
		{
		}

		public void SetCheckpoint()
		{
		}

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneExited(GameObject playerObject)
		{
		}

		public ZoneCheckpoint()
			: base()
		{
		}
	}
}
