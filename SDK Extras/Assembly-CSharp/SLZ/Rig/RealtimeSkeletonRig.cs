using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class RealtimeSkeletonRig : HeptaRig
	{
		[Header("RealHeptaRig")]
		[SerializeField]
		private SLZ.VRMK.Avatar _player;

		private float _adaptiveY;

		private float _adaptiveJuice;

		private SimpleTransform _trackedChestOffset;

		private SimpleTransform _trackedPelvisOffset;

		private SimpleTransform _trackedFootLfOffset;

		private SimpleTransform _trackedFootRtOffset;

		private Vector3 _lastChest;

		private Vector3 _chestGimbalVel;

		private Vector3 _chestGimbleAccel;

		private Vector3 _chestGimbalOffset;

		private Vector3 _lastPelvis;

		private Vector3 _pelvisGimbalVel;

		private Vector3 _pelvisGimbleAccel;

		private Vector3 _pelvisGimbalOffset;

		private Vector3 _lastFootLf;

		private Vector3 _footLfGimbalVel;

		private Vector3 _footLfGimbleAccel;

		private Vector3 _footLfGimbalOffset;

		private Vector3 _lastFootRt;

		private Vector3 _footRtGimbalVel;

		private Vector3 _footRtGimbleAccel;

		private Vector3 _footRtGimbalOffset;

		public SLZ.VRMK.Avatar player
		{
			get
			{
				return null;
			}
		}

		public void AddAddaptiveJuice(float juiceToAdd)
		{
		}

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnUpdate()
		{
		}

		private void UpdateHeptaBody(ControllerRig inRig, float deltaTime)
		{
		}

		public override void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public void CaptureTrackedOffsets(Rig inRig)
		{
		}

		public RealtimeSkeletonRig()
			: base()
		{
		}
	}
}
