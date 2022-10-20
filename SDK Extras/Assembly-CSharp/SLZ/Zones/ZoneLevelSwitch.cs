using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Zones
{
	public class ZoneLevelSwitch : ZoneItem
	{
		public LevelCrateReference level;

		public LevelCrateReference loadScreenLevel;

		public UnityAction OnLevelSwitchStart;

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public ZoneLevelSwitch()
			: base()
		{
		}
	}
}
