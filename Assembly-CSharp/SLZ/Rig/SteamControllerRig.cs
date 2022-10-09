using UnityEngine;
using Valve.VR;

namespace SLZ.Rig
{
	public class SteamControllerRig : ControllerRig
	{
		[HideInInspector]
		public TrackedDevicePose_t[] poses;

		public uint[] puckIndices;

		public int totalPucks;

		public uint trackerChestIndex;

		public uint trackerPelvisIndex;

		public uint trackerFootLfIndex;

		public uint trackerFootRtIndex;

		private bool _extendedTracking;

		public override void OnAwake()
		{
		}

		public override void OnRigEnable()
		{
		}

		public override void OnRigDisable()
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnUpdate()
		{
		}

		public void RefreshGenericTrackerIndices()
		{
		}

		[ContextMenu("Clear Tracking Pucks")]
		public void ClearTrackingPucks()
		{
		}

		[ContextMenu("Assign Pucks -> Capture Offsets")]
		public void AssignTrackingPucks()
		{
		}

		protected float SecondsFromNow()
		{
			return default(float);
		}

		public SteamControllerRig()
			: base()
		{
		}
	}
}
