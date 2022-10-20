using System;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Zones
{
	public class ZoneItemHelper : ZoneItem
	{
		[Serializable]
		public class ZoneItemHelperEvent : UnityEvent<GameObject>
		{
			public ZoneItemHelperEvent()
				: base()
			{
			}
		}

		[Header("Events")]
		public ZoneItemHelperEvent onZoneEnabledDelegate;

		public ZoneItemHelperEvent onZoneDisabledDelegate;

		public ZoneItemHelperEvent onSecondaryZoneEnteredDelegate;

		public ZoneItemHelperEvent onSecondaryZoneExitedDelegate;

		public ZoneItemHelperEvent onPrimaryZoneEnteredDelegate;

		public ZoneItemHelperEvent onPrimaryZoneExitedDelegate;

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		public override void OnSecondaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnSecondaryZoneExited(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneExited(GameObject playerObject)
		{
		}

		public ZoneItemHelper()
			: base()
		{
		}
	}
}
