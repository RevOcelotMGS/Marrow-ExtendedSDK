using System;
using System.Runtime.InteropServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class GameWorldSkeletonRig : HeptaRig
	{
		public static Action OnPreFixedUpdateGlobal;

		public Action OnPreFixedUpdate;

		[Header("VirtualHeptaRig")]
		public VirtualController virtualController;

		public VirtualControllerOverride bodyVCOverride;

		public Transform testGazeTarget;

		[SerializeField]
		private SkeletonHand _leftSkeletonHand;

		[SerializeField]
		private SkeletonHand _rightSkeletonHand;

		private float _lfCurlLerp;

		private float _rtCurlLerp;

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnFirstFixedUpdate()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnUpdate()
		{
		}

		public override void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public SkeletonHand GetSkeletonHand(Handedness handedness)
		{
			return null;
		}

		private SimpleTransform RemapSpine(SLZ.VRMK.Avatar player, SLZ.VRMK.Avatar avatar, Rig inRig, [Out] SimpleTransform chest, [Out] SimpleTransform outSpine)
		{
			return default(SimpleTransform);
		}

		private void RemapArmProportions2(SLZ.VRMK.Avatar player, SLZ.VRMK.Avatar avatar, Rig inRig)
		{
		}

		private void RemapTorsoProximity(SLZ.VRMK.Avatar player, SLZ.VRMK.Avatar avatar, Rig rwRig, Vector3 rwPalmLocalLf, Vector3 rwHandLfBoundsPos, Vector3 rwHandLfBoundsNeg, Vector3 vrPalmLocalLf, Vector3 vrHandLfBoundsPos, Vector3 vrHandLfBoundsNeg, Vector3 rwPalmLocalRt, Vector3 rwHandRtBoundsPos, Vector3 rwHandRtBoundsNeg, Vector3 vrPalmLocalRt, Vector3 vrHandRtBoundsPos, Vector3 vrHandRtBoundsNeg)
		{
		}

		private void RemapHandProximity2(SLZ.VRMK.Avatar player, SLZ.VRMK.Avatar avatar, Rig inRig, Vector3 rwPalmLocalLf, Vector3 rwHandLfBoundsPos, Vector3 rwHandLfBoundsNeg, Vector3 vrPalmLocalLf, Vector3 vrHandLfBoundsPos, Vector3 vrHandLfBoundsNeg, Vector3 rwPalmLocalRt, Vector3 rwHandRtBoundsPos, Vector3 rwHandRtBoundsNeg, Vector3 vrPalmLocalRt, Vector3 vrHandRtBoundsPos, Vector3 vrHandRtBoundsNeg)
		{
		}

		private void UpdateHeptaBody(Rig inRig, float deltaTime, Vector2 velocity, Vector2 accel)
		{
		}

		private void UpdateHeptaBody2(Rig inRig, float deltaTime, Vector2 velocity, Vector2 accel)
		{
		}

		public GameWorldSkeletonRig()
			: base()
		{
		}
	}
}
