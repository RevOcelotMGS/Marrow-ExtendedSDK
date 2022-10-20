using System;
using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class HeptaRig : Rig
	{
		[Header("HeptaRig")]
		public Transform wristLf;

		public Transform wristRt;

		protected BodyPose _bodyPose;

		private Vector3 _lastChestDir;

		private Vector3 _lastChestDirVel;

		[Header("Spine")]
		public float spineCrouchOffset;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurve;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurveVelocity;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurveClimb;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurveMantle;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurve;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurveVelocity;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurveClimb;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurveMantle;

		[SerializeField]
		private AnimationCurve _neckTiltCurve;

		[SerializeField]
		private AnimationCurve _thoracicTwistCurve;

		[SerializeField]
		private AnimationCurve _angleCurve;

		[SerializeField]
		private AnimationCurve _t1DirectionCurve;

		protected Vector3 _playerUp;

		protected Vector3 _dragUp;

		protected Vector3 _skullPosWorld;

		private float _t1ToVelLerp;

		private float _t1ToVelVel;

		private float _sacrumToVelLerp;

		private float _sacrumToVelVel;

		private float _t1UpOffsetLerp;

		private float _t1UpOffsetVel;

		private float _sacrumUpOffsetLerp;

		private float _sacrumUpOffsetVel;

		private Vector2 _lastT1FwdV2;

		private Vector2 _lastSacrumFwdV2;

		private float _suppressChestVelocityTwist;

		private bool _suppressionDirty;

		[SerializeField]
		private AnimationCurve _clavicleReachCurve;

		[SerializeField]
		private AnimationCurve _clavZCurve;

		[SerializeField]
		private AnimationCurve _clavYCurve;

		[Range(1f, 1.2f)]
		[Tooltip("Maximum factor the arms can be stretched by. Default 1.05")]
		public float maxStretchFactor;

		[Tooltip("Percentage of arm length where stretching starts. Default 0.8")]
		[Range(0f, 1f)]
		public float stretchThreshold;

		[Tooltip("Ratio of hyperextention to resulting arm length. Default 2")]
		[Range(1f, 4f)]
		public float stretchRatio;

		[SerializeField]
		private AnimationCurve _elbowLimitCurve;

		[SerializeField]
		private AnimationCurve _wristElbowIsNotCurve;

		private Vector3 _handVectorLf;

		private Vector3 _handVectorRt;

		private Quaternion _neutHumLf;

		private Quaternion _neutHumRt;

		private float _leftHandTwist;

		private float _rightHandTwist;

		public float leftHandDevia;

		public float rightHandDevia;

		private float _wristRelaxLerpLf;

		private float _wristRelaxLerpRt;

		private const float sDisplaceDegreesToXzMult = 0.00485f;

		private const float sDisplaceDegreesToYMult = 0.62f;

		private const float accelLeanWeight = 0.33f;

		private const float dragWeight = 2f;

		private const float pACdProduct = 2f;

		private Vector3 _velLerp;

		private Vector3 _velSanGravNormal;

		private float _velSanGravMag;

		private float _accelSanGravMag;

		public BodyPose bodyPose
		{
			get
			{
				return null;
			}
		}

		public float suppressChestVelocityTwist
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public override void OnStart()
		{
		}

		protected SimpleTransform LimitSpineRotation(SimpleTransform from, SimpleTransform to, Vector4 rangeOfMotion, [Out] float limitedTilt, [Out] float limitedTwist, [Out] float tiltRom, [Out] float tiltDir, [Out] Vector2 xzFromUp)
		{
			return default(SimpleTransform);
		}

		protected Vector3 LimitSpinePosition(Vector3 trackedOffsetLocal, float length, float limitedTilt, float limitedTwist, float tiltRom, float twistRom, Vector2 xzFromUp)
		{
			return default(Vector3);
		}

		protected SimpleTransform VerifyThorLumbarSpinePositional(SimpleTransform inChest, SimpleTransform inSpine, SimpleTransform inPelvis, SLZ.VRMK.Avatar avatar, [Out] SimpleTransform spine)
		{
			return default(SimpleTransform);
		}

		protected SimpleTransform AimSpineTowardPelvis(SimpleTransform inHead, SimpleTransform inChest, SimpleTransform inSpine, SimpleTransform inPelvis, SimpleTransform pelvisTarget, SLZ.VRMK.Avatar avatar, [Out] SimpleTransform outChest, [Out] SimpleTransform outSpine)
		{
			return default(SimpleTransform);
		}

		protected Vector3 ExtrapolateCervical(Quaternion skullRot, Quaternion chestRot, SLZ.VRMK.Avatar avatar)
		{
			return default(Vector3);
		}

		protected SimpleTransform ExtrapolateThorLumbar(SimpleTransform inChest, Quaternion inSpineRot, Quaternion inPelvisRot, SLZ.VRMK.Avatar avatar, [Out] SimpleTransform outSpine)
		{
			return default(SimpleTransform);
		}

		protected SimpleTransform SolveChest(SLZ.VRMK.Avatar avatar, Rig inRig, float deltaTime, bool slerp = false, float mantle = 0f, float footSupported = 1f, float handSupported = 0f, float physKneeOffset = 0f)
		{
			return default(SimpleTransform);
		}

		protected float SolveT1UpOffset(float heightWeight, float mantle, float footSupported, float handSupported, float velocityInLegs, float lastOffset, float offsetVel, bool slerp = false)
		{
			return default(float);
		}

		protected float SolveSacrumUpOffset(float heightWeight, float mantle, float footSupported, float handSupported, float velocityInLegs)
		{
			return default(float);
		}

		protected Quaternion SolveT1ToHands(Rig inRig, SLZ.VRMK.Avatar avatar, SimpleTransform t1World)
		{
			return default(Quaternion);
		}

		protected SimpleTransform SolvePelvis(SLZ.VRMK.Avatar avatar, SimpleTransform chest, float deltaTime, [Out] SimpleTransform spine, SimpleTransform pelvisLocalAnimOff, bool slerp = false, float mantle = 0f, float footSupported = 1f, float handSupported = 0f, float physKneeOffset = 0f)
		{
			return default(SimpleTransform);
		}

		protected void SolveClavicles(Rig inRig, SLZ.VRMK.Avatar avatar)
		{
		}

		protected ValueTuple<float, float, Vector3> SolveArmReach(Vector3 handLocal, Vector3 neutralDir, float armLength, float clavicalLength, float fwdDegrees, float backDegrees, float upDegrees, float downDegrees, bool isLeft)
		{
			return default(ValueTuple<float, float, Vector3>);
		}

		protected void LimitHands(SLZ.VRMK.Avatar avatar, [Out] float armMultLf, [Out] float armMultRt)
		{
		}

		private bool HandLimiter(float currentMag, float defaultMag, float minPerc, [Out] float newLimbMag, [Out] float armMult)
		{
			return default(bool);
		}

		protected SimpleTransform SolveFeetCenter(SimpleTransform head, SimpleTransform chest, SimpleTransform pelvis, bool dragOffset = true)
		{
			return default(SimpleTransform);
		}

		protected void SolveArms(Rig inRig, SLZ.VRMK.Avatar avatar, float armMultLf, float armMultRt)
		{
		}

		private void WristRelax(Vector3 leftHandVector3, Vector3 rightHandVector3, Quaternion neutralHumerusLf, Quaternion neutralHumerusRt)
		{
		}

		private float ElbowIsNot(Vector3 armVectorNormed, Vector3 neutralGh, Quaternion neutralGlenhumeral, float twistFloat)
		{
			return default(float);
		}

		private float ElbowIsNotRt(Vector3 armVectorNormed, Vector3 neutralGh, Quaternion neutralGlenhumeral, float twistFloat)
		{
			return default(float);
		}

		public void CalibratePlayerBodyScale(SLZ.VRMK.Avatar avatar)
		{
		}

		protected Vector3 BodyVelocity(Vector2 vel, Vector2 accel, float deltaTime)
		{
			return default(Vector3);
		}

		protected void ExtractProportions(SimpleTransform palmLf, SimpleTransform palmRt, Rig inRig, SLZ.VRMK.Avatar avatar, BodyPose bodyPose)
		{
		}

		protected void ApplyProportions(SimpleTransform palmLf, SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose)
		{
		}

		protected void ExtractHandProximity(SimpleTransform palmLf, SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, BodyPose bodyPose)
		{
		}

		protected void ApplyHandProximity(SimpleTransform palmLf, SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg)
		{
		}

		protected void ExtractTorsoProximity(SimpleTransform palmLf, SimpleTransform palmRt, Rig inRig, SLZ.VRMK.Avatar avatar, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, BodyPose bodyPose)
		{
		}

		protected void ApplyTorsoProximity(SimpleTransform palmLf, SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg)
		{
		}

		protected float GetSixAxisBoundsMag(Vector3 localNormedDirection, Vector3 boundsPositive, Vector3 boundsNegative)
		{
			return default(float);
		}

		protected bool PointInTorso(SimpleTransform pointWorld, Vector3 pointBoundsPos, Vector3 pointBoundsNeg, Vector3 pelFromChestNorm, float pelFromChestMag, SLZ.VRMK.Avatar player, SimpleTransform c1, SimpleTransform sternum, SimpleTransform spine, SimpleTransform pelvis, [Out] float t, [Out] float yPercRemapped, [Out] Vector2 sin, [Out] Quaternion spineRotInWorld, [Out] Vector3 spineInPointNormed)
		{
			return default(bool);
		}

		protected void HandTorsoSpacewarp(SimpleTransform palm, Vector3 pointBoundsPos, Vector3 pointBoundsNeg, SLZ.VRMK.Avatar avatar, SimpleTransform head, SimpleTransform chest, SimpleTransform spine, SimpleTransform pelvis, Quaternion spineRot, float yPercRemapped, Vector2 sin, float t, Vector3 spineInPointNormed)
		{
		}

		public HeptaRig()
			: base()
		{
		}
	}
}
