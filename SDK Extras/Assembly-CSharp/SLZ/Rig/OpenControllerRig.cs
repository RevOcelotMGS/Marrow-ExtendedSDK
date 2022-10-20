using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Rendering;

namespace SLZ.Rig
{
	public class OpenControllerRig : ControllerRig
	{
		public Camera[] cameras;

		public Player_Health playerHealth;

		public Control_GlobalTime globalTimeControl;

		private float _timeInputTimer;

		private bool _timeInput;

		private readonly SimpleTransform OculusHandOffsetLf;

		private readonly SimpleTransform OculusHandOffsetRt;

		private bool _hasLeftHandOffset;

		private SimpleTransform leftHandOffset;

		private bool _hasRightHandOffset;

		private SimpleTransform rightHandOffset;

		private bool _isControllerRigPaused;

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

		private void RefreshBodyTrack()
		{
		}

		public override void OnAwake()
		{
		}

		private void OnMarrowReady()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		private void ProcessesWristOffset()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		private void OnBeginCameraRendering(ScriptableRenderContext ctx, Camera cam)
		{
		}

		private void OnDestroy()
		{
		}

		private Vector3 EnforceLimits(Vector3 localPos, Vector3 lastLocalPos)
		{
			return default(Vector3);
		}

		private void TimeInput(bool down, bool up, bool touch)
		{
		}

		public OpenControllerRig()
			: base()
		{
		}
	}
}
