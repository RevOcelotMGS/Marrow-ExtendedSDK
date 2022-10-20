using System;
using UnityEngine;

namespace SLZ.Zones
{
	public class ZoneItem : MonoBehaviour
	{
		[Flags]
		public enum TriggerOptions
		{
			NONE = 1,
			PRIMARY = 2,
			SECONDARY = 4
		}

		[HideInInspector]
		public bool inSecondaryZone;

		[HideInInspector]
		public bool isEnabled;

		[HideInInspector]
		public SceneZone zone;

		[EnumFlags]
		public TriggerOptions triggerOption;

		public virtual void OnZoneEnabled(GameObject playerObject)
		{
		}

		public virtual void OnZoneDisabled(GameObject playerObject)
		{
		}

		public virtual void OnSecondaryZoneEntered(GameObject playerObject)
		{
		}

		public virtual void OnSecondaryZoneExited(GameObject playerObject)
		{
		}

		public virtual void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public virtual void OnPrimaryZoneExited(GameObject playerObject)
		{
		}

		public ZoneItem()
			: base()
		{
		}
	}
}
