using System;
using System.Runtime.InteropServices;
using SLZ.AI;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;
using SLZ.Props.Weapons;
using SLZ.Zones;
using UnityEngine;

namespace SLZ.MIA
{
	[Obsolete("This was intended to centralize some of the ugliness of event processing, but never really got used, and though it's probably inert, it's not worth the risk to remove this late.")]
	public class MIASimulationEventBroker : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		[MarrowPluginRegisterMethod]
		public static void RegisterPlugin(IMarrowPluginRegistration registration)
		{
		}

		public void OnMarrowPluginLoad()
		{
		}

		public void OnBeforeLevelLoad(LevelCrateReference level)
		{
		}

		public void OnAfterLevelLoad(LevelCrateReference level)
		{
		}

		public void OnBeforeLevelUnload()
		{
		}

		public void OnAfterLevelUnload()
		{
		}

		public void ReportGunshotEvent(SceneZone zone, TriggerRefProxy by, Gun from)
		{
		}

		public void ReportPersonalSpaceEvent(TriggerRefProxy actor, TriggerRefProxy intruder)
		{
		}

		public MIASimulationEventBroker()
			: base()
		{
		}
	}
}
