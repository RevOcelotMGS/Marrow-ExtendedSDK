using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		public class Arm : BodyPart
		{
			[Serializable]
			public enum ShoulderRotationMode
			{
				YawPitch = 0,
				FromTo = 1
			}

			[Tooltip("The hand target")]
			public Transform target;

			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Tooltip("Positional weight of the hand target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Tooltip("Rotational weight of the hand target")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Range(0f, 1f)]
			[Tooltip("The weight of shoulder rotation")]
			public float shoulderRotationWeight;

			[Range(0f, 1f)]
			[Tooltip("The weight of twisting the shoulders back when arms are lifted up.")]
			public float shoulderTwistWeight;

			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation.")]
			public Vector3 wristToPalmAxis;

			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation.")]
			public Vector3 palmToThumbAxis;

			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the arm shorter/longer.")]
			public float armLengthMlp;

			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length).")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[HideInInspector]
			public Vector3 handPositionOffset;

			private bool hasShoulder;

			private Vector3 chestForwardAxis;

			private Vector3 chestUpAxis;

			private Quaternion chestRotation;

			private Vector3 chestForward;

			private Vector3 chestUp;

			private Quaternion forearmRelToUpperArm;

			private const float yawOffsetAngle = 45f;

			private const float pitchOffsetAngle = -30f;

			public Vector3 position { get; private set; }

			public Quaternion rotation { get; private set; }

			private VirtualBone shoulder
			{
				get
				{
					return null;
				}
			}

			private VirtualBone upperArm
			{
				get
				{
					return null;
				}
			}

			private VirtualBone forearm
			{
				get
				{
					return null;
				}
			}

			private VirtualBone hand
			{
				get
				{
					return null;
				}
			}

			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			public override void PreSolve()
			{
			}

			public override void ApplyOffsets()
			{
			}

			private void Stretching()
			{
			}

			public void Solve(bool isLeft)
			{
			}

			public override void ResetOffsets()
			{
			}

			public override void Write(Vector3[] solvedPositions, Quaternion[] solvedRotations)
			{
			}

			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			public Arm()
				: base()
			{
			}
		}

		[Serializable]
		public abstract class BodyPart
		{
			[HideInInspector]
			public VirtualBone[] bones;

			protected bool initiated;

			protected Vector3 rootPosition;

			protected Quaternion rootRotation;

			protected int index;

			public float sqrMag { get; private set; }

			public float mag { get; private set; }

			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			public abstract void PreSolve();

			public abstract void Write(Vector3[] solvedPositions, Quaternion[] solvedRotations);

			public abstract void ApplyOffsets();

			public abstract void ResetOffsets();

			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			public void MovePosition(Vector3 position)
			{
			}

			public void MoveRotation(Quaternion rotation)
			{
			}

			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			public void Visualize(Color color)
			{
			}

			public void Visualize()
			{
			}

			public BodyPart()
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

			public Quaternion stepToRootRot;

			public bool isSupportLeg;

			public Vector3 stepFrom;

			public Vector3 stepTo;

			public Quaternion stepFromRot;

			public Quaternion stepToRot;

			private Quaternion footRelativeToRoot;

			private float supportLegW;

			private float supportLegWV;

			public bool isStepping
			{
				get
				{
					return default(bool);
				}
			}

			public float stepProgress { get; private set; }

			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
				: base()
			{
			}

			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		public class Leg : BodyPart
		{
			[Tooltip("The toe/foot target.")]
			public Transform target;

			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Tooltip("Positional weight of the toe/foot target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target.")]
			public float rotationWeight;

			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the knee bending direction.")]
			public float swivelOffset;

			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Tooltip("Use this to make the leg shorter/longer.")]
			[Range(0.01f, 2f)]
			public float legLengthMlp;

			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length).")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[HideInInspector]
			public float currentMag;

			private Vector3 footPosition;

			private Quaternion footRotation;

			private Vector3 bendNormal;

			private Quaternion calfRelToThigh;

			private Quaternion thighRelToFoot;

			private Vector3 bendNormalRelToPelvis;

			private Vector3 bendNormalRelToTarget;

			public Vector3 position { get; private set; }

			public Quaternion rotation { get; private set; }

			public bool hasToes { get; private set; }

			public VirtualBone thigh
			{
				get
				{
					return null;
				}
			}

			private VirtualBone calf
			{
				get
				{
					return null;
				}
			}

			private VirtualBone foot
			{
				get
				{
					return null;
				}
			}

			private VirtualBone toes
			{
				get
				{
					return null;
				}
			}

			public VirtualBone lastBone
			{
				get
				{
					return null;
				}
			}

			public Vector3 thighRelativeToPelvis { get; private set; }

			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			public override void PreSolve()
			{
			}

			public override void ApplyOffsets()
			{
			}

			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			public void Solve(bool stretch)
			{
			}

			private void Stretching()
			{
			}

			public override void Write(Vector3[] solvedPositions, Quaternion[] solvedRotations)
			{
			}

			public override void ResetOffsets()
			{
			}

			public Leg()
				: base()
			{
			}
		}

		[Serializable]
		public class Locomotion
		{
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			[Range(0f, 1f)]
			public float weight;

			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Range(0.9f, 1f)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Tooltip("The speed of steps.")]
			public float stepSpeed;

			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Range(0f, 180f)]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			public float relaxLegTwistMinAngle;

			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[HideInInspector]
			public bool blockingEnabled;

			[HideInInspector]
			public LayerMask blockingLayers;

			[HideInInspector]
			public float raycastRadius;

			[HideInInspector]
			public float raycastHeight;

			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			private Footstep[] footsteps;

			private Vector3 lastComPosition;

			private Vector3 comVelocity;

			private int leftFootIndex;

			private int rightFootIndex;

			public Vector3 centerOfMass { get; private set; }

			public Vector3 leftFootstepPosition
			{
				get
				{
					return default(Vector3);
				}
			}

			public Vector3 rightFootstepPosition
			{
				get
				{
					return default(Vector3);
				}
			}

			public Quaternion leftFootstepRotation
			{
				get
				{
					return default(Quaternion);
				}
			}

			public Quaternion rightFootstepRotation
			{
				get
				{
					return default(Quaternion);
				}
			}

			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			public void AddDeltaPosition(Vector3 delta)
			{
			}

			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, [Out] Vector3 leftFootPosition, [Out] Vector3 rightFootPosition, [Out] Quaternion leftFootRotation, [Out] Quaternion rightFootRotation, [Out] float leftFootOffset, [Out] float rightFootOffset, [Out] float leftHeelOffset, [Out] float rightHeelOffset)
			{
			}

			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			private bool CanStep()
			{
				return default(bool);
			}

			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			public Locomotion()
				: base()
			{
			}
		}

		[Serializable]
		public class Spine : BodyPart
		{
			[Tooltip("The head target.")]
			public Transform headTarget;

			[Tooltip("The pelvis target, useful with seated rigs.")]
			public Transform pelvisTarget;

			[Tooltip("Positional weight of the head target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the head target.")]
			public float rotationWeight;

			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target.")]
			public float pelvisPositionWeight;

			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target.")]
			public float pelvisRotationWeight;

			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the chest target.")]
			public float chestGoalWeight;

			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			public float bodyRotStiffness;

			[FormerlySerializedAs("chestRotationWeight")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Range(0f, 1f)]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			public float rotateChestByHands;

			[Range(0f, 1f)]
			[Tooltip("Clamps chest rotation.")]
			public float chestClampWeight;

			[Tooltip("Clamps head rotation.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 headPosition;

			private Quaternion headRotation;

			private Quaternion pelvisRotation;

			private Quaternion anchorRelativeToHead;

			private Quaternion anchorRelativeToPelvis;

			private Quaternion pelvisRelativeRotation;

			private Quaternion chestRelativeRotation;

			private Vector3 headDeltaPosition;

			private Quaternion pelvisDeltaRotation;

			private Quaternion chestTargetRotation;

			private int pelvisIndex;

			private int spineIndex;

			private int chestIndex;

			private int neckIndex;

			private int headIndex;

			private float length;

			private bool hasChest;

			private bool hasNeck;

			private bool hasLegs;

			private float headHeight;

			private float sizeMlp;

			private Vector3 chestForward;

			public VirtualBone pelvis
			{
				get
				{
					return null;
				}
			}

			public VirtualBone firstSpineBone
			{
				get
				{
					return null;
				}
			}

			public VirtualBone chest
			{
				get
				{
					return null;
				}
			}

			private VirtualBone neck
			{
				get
				{
					return null;
				}
			}

			public VirtualBone head
			{
				get
				{
					return null;
				}
			}

			public Quaternion anchorRotation { get; private set; }

			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			public override void PreSolve()
			{
			}

			public override void ApplyOffsets()
			{
			}

			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			private void SolvePelvis()
			{
			}

			public override void Write(Vector3[] solvedPositions, Quaternion[] solvedRotations)
			{
			}

			public override void ResetOffsets()
			{
			}

			private void AdjustChestByHands(Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			public Spine()
				: base()
			{
			}
		}

		[Serializable]
		public enum PositionOffset
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2,
			LeftHand = 3,
			RightHand = 4,
			LeftFoot = 5,
			RightFoot = 6,
			LeftHeel = 7,
			RightHeel = 8
		}

		[Serializable]
		public enum RotationOffset
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2
		}

		[Serializable]
		public class VirtualBone
		{
			public Vector3 readPosition;

			public Quaternion readRotation;

			public Vector3 solverPosition;

			public Quaternion solverRotation;

			public float length;

			public float sqrMag;

			public Vector3 axis;

			public VirtualBone(Vector3 position, Quaternion rotation)
				: base()
			{
			}

			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			public static float PreSolve(VirtualBone[] bones)
			{
				return default(float);
			}

			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		private Transform[] solverTransforms;

		private bool hasChest;

		private bool hasNeck;

		private bool hasShoulders;

		private bool hasToes;

		private bool hasLegs;

		private Vector3[] readPositions;

		private Quaternion[] readRotations;

		private Vector3[] solvedPositions;

		private Quaternion[] solvedRotations;

		private Quaternion[] defaultLocalRotations;

		private Vector3[] defaultLocalPositions;

		private Vector3 rootV;

		private Vector3 rootVelocity;

		private Vector3 bodyOffset;

		private int supportLegIndex;

		[Tooltip("If true, will keep the toes planted even if head target is out of reach.")]
		public bool plantFeet;

		[Tooltip("The spine solver.")]
		public Spine spine;

		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		private Leg[] legs;

		private Arm[] arms;

		private Vector3 headPosition;

		private Vector3 headDeltaPosition;

		private Vector3 raycastOriginPelvis;

		private Vector3 lastOffset;

		private Vector3 debugPos1;

		private Vector3 debugPos2;

		private Vector3 debugPos3;

		private Vector3 debugPos4;

		[HideInInspector]
		public VirtualBone rootBone { get; private set; }

		public void SetToReferences(VRIK.References references)
		{
		}

		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		public void DefaultAnimationCurves()
		{
		}

		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		public void Reset()
		{
		}

		public override void StoreDefaultLocalState()
		{
		}

		public override void FixTransforms()
		{
		}

		public override Point[] GetPoints()
		{
			return null;
		}

		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		public override bool IsValid(string message)
		{
			return default(bool);
		}

		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		private void UpdateSolverTransforms()
		{
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void WriteTransforms()
		{
		}

		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		private void Solve()
		{
		}

		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		private void Write()
		{
		}

		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		public IKSolverVR()
			: base()
		{
		}
	}
}
