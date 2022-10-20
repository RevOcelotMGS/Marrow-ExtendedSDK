using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.VRMK
{
	public class SLZ_Body : MonoBehaviour
	{
		[Serializable]
		public class FollowObjects
		{
			public Transform head;

			public Transform chest;

			public Transform leftHand;

			public Transform rightHand;

			public Transform pelvis;

			public Transform lfFoot;

			public Transform rtFoot;

			[Tooltip("Used for up / gravity direction and default floor plane")]
			public Transform playerRoot;

			public FollowObjects()
				: base()
			{
			}
		}

		[Serializable]
		public class Spine
		{
			public bool computeVelocity;

			public bool thoracicLumbarSpine;

			public bool feetCenter;

			[Range(0f, 1f)]
			public float trackedPelvisWeight;

			public bool noSlerp;

			[Range(0f, 1f)]
			[Tooltip("Weight of spine leaning to maintain balance due to acceleration (0 to 1)")]
			public float accelLeanWeight;

			[Range(0f, 4f)]
			[Tooltip("Weight of spine leaning to maintain balance due to fluid drag (0 to 4, 1 default)")]
			public float dragWeight;

			[Tooltip("Product of p(mass density) * A(area) * Cd(drag coef). p = 1.2 at 20celcius, A ~= .4m2, Cd ~= .6 - 1")]
			public float pACdProduct;

			public float accelDragTan;

			public float dragTan;

			public Vector3 dragUpDir;

			public float angularVelocity;

			[HideInInspector]
			public Vector3 velocitySanGrav;

			[HideInInspector]
			public Vector3 accelerationSanGrav;

			[HideInInspector]
			public Vector3 velocitySanGravNormal;

			[HideInInspector]
			public Vector3 accelerationSanGravNormal;

			[HideInInspector]
			public float velocitySanGravMag;

			public AnimationCurve thoracicTwistCurve;

			public float spineCrouchOffset;

			private float deltaLerpTime;

			private Vector3 lastAngularFwd;

			internal void BodyVelocity(Vector3 vel, Vector3 accel, Quaternion feetCenterRot)
			{
			}

			public Spine()
				: base()
			{
			}
		}

		[Serializable]
		public class Footstep
		{
			public float stepSpeed;

			public Vector3 characterSpaceOffset;

			public Vector3 position;

			public Quaternion rotation;

			public bool isSupportLeg;

			public Vector3 stepFrom;

			public Vector3 stepTo;

			private Quaternion stepFromRot;

			private Quaternion stepToRot;

			private float supportLegW;

			private float supportLegWV;

			private float minAngle;

			public Quaternion grounderRotOffset;

			private Grounder grounder;

			private Quaternion toHitNormal;

			private RaycastHit toeHit;

			private Transform hip;

			private bool _wasGrounded;

			private float _wasGroundedTimer;

			public bool isStepping
			{
				get
				{
					return default(bool);
				}
			}

			public float stepProgress { get; private set; }

			public float heightFromFeet { get; private set; }

			public Vector3 grounderOffset { get; private set; }

			public bool isGrounded { get; private set; }

			public Footstep(Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset, Grounder ground, Transform hipTran, float relaxTwistMinAngle)
				: base()
			{
			}

			public void Reset(Vector3 footPosition, Quaternion footRotation)
			{
			}

			public void StartStep(Vector3 p, Quaternion rootRotation)
			{
			}

			public void UpdateStepping(Vector3 p, Vector3 comVelGrndVector, Vector3 accel, float angularVel, Quaternion rootRotation, float stepSpeedUpdate, float stepLZ, Vector3 rootUp)
			{
			}

			public void UpdateStanding(Quaternion rootRotation, Vector3 rootUp)
			{
			}

			public void UpdateSoaring(Vector3 comToeLz, Quaternion rootRotation, Vector3 rootUp)
			{
			}

			public void Update(FootstepSFX stepSfx, AnimationCurve stepZInterpolation, bool rightFoot, float stepRadius, Vector3 velAccel, Quaternion rootRotation)
			{
			}

			public void AddDeltaRotation(float delta, Vector3 pivot)
			{
			}

			public void AddDeltaPosition(Vector3 delta)
			{
			}

			public void ProcessGrounder(Vector3 rootUp)
			{
			}

			private RaycastHit GetRaycastHit(Vector3 offsetFromToe, Vector3 rootUp)
			{
				return default(RaycastHit);
			}

			private void SetFootToPoint(Vector3 normal, Vector3 point, Vector3 rootUp)
			{
			}
		}

		[Serializable]
		public class Locomotion
		{
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Tooltip("Percentage of previous step completion before another can be triggered 0-1f")]
			public float stepProgressThresholdLf;

			[Tooltip("Percentage of previous step completion before another can be triggered 0-1f")]
			public float stepProgressThresholdRt;

			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			public float stepLzLf;

			public float stepLzRt;

			[Tooltip("The speed of steps.")]
			[Range(0.5f, 5f)]
			public float stepSpeed;

			[Tooltip("Degrees splayed 'Y' over 0 - 1 squat factor 'X'.")]
			public AnimationCurve FootDistanceVCurve;

			public AnimationCurve StepThresholdVCurve;

			public AnimationCurve StepSpeedVCurve;

			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle;

			[Range(0f, 1f)]
			public float animCycle;

			public int gearLf;

			public int gearRt;

			public Gear[] gears;

			public Grounder grounder;

			public FootstepSFX leftStepSfx;

			public FootstepSFX rightStepSfx;

			private Footstep[] footsteps;

			private float lastAnimCycle;

			private bool wasStepping;

			public void Initiate(SkeletonRig animRig)
			{
			}

			public void Reset(SkeletonRig animRig)
			{
			}

			public void AddDeltaRotation(float delta, Vector3 pivot)
			{
			}

			public void AddDeltaPosition(Vector3 delta)
			{
			}

			public Vector3 GetFootstepNeutralOffset(int stepIndex)
			{
				return default(Vector3);
			}

			public void Solve(SkeletonRig animRig, Spine spine, float legLength, float sacrumHeightWeight, int supportLegIndex, [Out] Vector3 leftFootPosition, [Out] Vector3 rightFootPosition, [Out] Quaternion leftFootRotation, [Out] Quaternion rightFootRotation, [Out] float leftFootOffset, [Out] float rightFootOffset, [Out] float leftHeelOffset, [Out] float rightHeelOffset)
			{
			}

			public void UpdateAnimCycle()
			{
			}

			private bool CanStep()
			{
				return default(bool);
			}

			private void GearShifter(Vector3 velocity, Vector3 accel, int gear)
			{
			}

			public Locomotion()
				: base()
			{
			}
		}

		[Serializable]
		public class Gear
		{
			public float upshiftVel;

			public float downshiftVel;

			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			public AnimationCurve stepHeightBackwards;

			public AnimationCurve heelHeightBackwards;

			public AnimationCurve StepProgressThreshVCurve;

			public AnimationCurve StepSpeedVCurve;

			public AnimationCurve StepLandingZoneVCurve;

			public AnimationCurve StepZInterpolationVCurve;

			public Gear()
				: base()
			{
			}
		}

		[Serializable]
		public class Grounder
		{
			[Serializable]
			public enum Quality
			{
				ToeRay = 0,
				ToeHeelRay = 1
			}

			public bool useGrounder;

			[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
			public LayerMask layers;

			[Tooltip("The raycasting quality.")]
			public Quality quality;

			[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
			public float maxStep;

			[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
			[Range(0f, 90f)]
			public float maxFootRotationAngle;

			[Tooltip("The speed of moving the feet up/down.")]
			public float footSpeed;

			[Tooltip("Speed of slerping the feet to their grounded rotations.")]
			public float footRotationSpeed;

			public Grounder()
				: base()
			{
			}
		}

		private int supportLegIndex;

		private Vector3 _playerUp;

		private Quaternion feetAngleSlerp;

		private float _hipZDamped;

		private float _hipZVelocity;

		public SkeletonRig animationRig;

		public Spine spine;

		public Locomotion locomotion;

		[HideInInspector]
		public float footLength;

		[Tooltip("The transforms to solve the body for.")]
		public FollowObjects followObjects;

		public bool sitting;

		public void OnStart(Avatar avatar, PhysicsRig physRig)
		{
		}

		public void SetAvatar(Avatar avatar)
		{
		}

		private void FeetCenter()
		{
		}

		private void LimbLimit(float limbMag, float upperLength, float lowerLength, [Out] float newLimbMag)
		{
		}

		private void SolveLegs(Avatar avatar, [Out] SimpleTransform pelvisOffset, bool fullBody = false)
		{
		}

		public void CalibratePlayerBodyScale(Avatar avatar)
		{
		}

		public void FullBodyUpdate3(float deltaTime, Vector3 pelvisVelocity, Vector3 pelvisAccel, PhysicsRig physRig, SimpleTransform pelvisOffset, bool fullBody = false)
		{
		}

		public SLZ_Body()
			: base()
		{
		}
	}
}
