using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class PhysicsRig : Rig
	{
		public enum StepState
		{
			NeutralRoll = 0,
			HoldStep = 1,
			ReturnStep = 2,
			Dangle = 3,
			Climbing = 4,
			FreeRotation = 5,
			ReSprout = 6
		}

		[Header("PhysicsRig")]
		public Hand leftHand;

		public Hand rightHand;

		public PhysTorso torso;

		public PhysLimb legLf;

		public PhysLimb legRt;

		public PhysSoftBody softbody;

		public HeadSFX headSfx;

		public HashSet<Rigidbody> selfRbs;

		public int onLadder;

		public float ladderFade;

		private float _kneeCaY;

		private LadderInfo _ladderInfo;

		public bool bodyMassNaturalHold;

		private bool _bodyMassNatural;

		private Vector3 _lastHeadPos;

		private Vector3 _lastinputVel;

		private Vector3 _accelBuffer;

		private float _bufferVelocity;

		private Coroutine resetHandsCoroutine;

		private Vector3 _avgVel;

		private bool _ballLocoEnabled;

		private bool _legsKinematic;

		private bool _reEnable;

		private SimpleTransform _initialPelvis;

		private SimpleTransform _initialSpine;

		private SimpleTransform _initialChest;

		private SimpleTransform _initialNeck;

		private SimpleTransform _initialHead;

		private SimpleTransform _initialJaw;

		private SimpleTransform _initialKnee;

		private SimpleTransform _initialFeet;

		private SimpleTransform _initialGhLf;

		private SimpleTransform _initialElbowLf;

		private SimpleTransform _initialHandLf;

		private SimpleTransform _initialGhRt;

		private SimpleTransform _initialElbowRt;

		private SimpleTransform _initialHandRt;

		private Quaternion _initialHipLf;

		private Quaternion _initialKneeLf;

		private Quaternion _initialFootLf;

		private Quaternion _initialHipRt;

		private Quaternion _initialKneeRt;

		private Quaternion _initialFootRt;

		private float _monoRemainder;

		private float _monoVel;

		private float _doubleCooldown;

		private float _doubleLaunchWindow;

		private bool _doubleReady;

		[Header("Monofoot")]
		public GameObject knee;

		public GameObject feet;

		[SerializeField]
		private Rigidbody _kneeRb;

		[SerializeField]
		private Rigidbody _feetRb;

		[SerializeField]
		private ConfigurableJoint _kneePelJoint;

		[SerializeField]
		private ConfigurableJoint _feetKneeJoint;

		[SerializeField]
		private Servo _kneePelServo;

		public CapsuleCollider kneePelvisCol;

		public LayerMask footballColCheckMask;

		[SerializeField]
		private float _pelvisForceMult;

		[SerializeField]
		private float _monoDamperMult;

		private float _footballRadius;

		private float _maxStepHeight;

		private SphereCollider _football;

		private SphereCollider _kneeFender;

		private RaycastHit[] _footHits;

		private PhysGrounder physG;

		private float _footballCircum;

		private const float kneeFenderMult = 1.0444444f;

		private StepState _stepState;

		private float _climbingOffset;

		private Vector2 _stepDelta;

		private Vector2 _stepDeltaOverTimeBuffer;

		private Vector2 _stepVel;

		private bool _returnStepTranslates;

		private Vector3 _stepCastBuffer;

		private Vector3 _climbingNormal;

		private Vector3 _climbingVelocity;

		private Vector3 _lastClimbingPoint;

		private Vector3 _climbingKneeJointVelocity;

		private Quaternion _lastKneeRotation;

		public Vector3 wholeBodyVelocity { get; private set; }

		public Vector3 wholeBodyAccel { get; private set; }

		public Vector3 pelvisVelocity { get; private set; }

		public Vector3 groundVelocity { get; private set; }

		public Vector3 skidVelocity { get; private set; }

		public float skidSpeed { get; private set; }

		public float groundAngVelocity { get; private set; }

		public float footSupported { get; private set; }

		public Vector3 pelvisAccel { get; private set; }

		public Vector3 headDelta { get; private set; }

		public Vector3 physicalSpineDisplaceInWorld { get; private set; }

		public Vector3 grounderNormal
		{
			get
			{
				return default(Vector3);
			}
		}

		public bool ungroundedThisFrame
		{
			get
			{
				return default(bool);
			}
		}

		public float pelvisHeightMult { get; private set; }

		public float physicalKneeDisplaceInPelvisHeights { get; private set; }

		public Vector3 deviaVectorLfInHandle { get; private set; }

		public Vector3 deviaVectorRtInHandle { get; private set; }

		public Rigidbody rbKnee
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbFeet
		{
			get
			{
				return null;
			}
		}

		public ConfigurableJoint kneePelvisJoint
		{
			get
			{
				return null;
			}
		}

		public float footballRadius
		{
			get
			{
				return default(float);
			}
		}

		public StepState stepState
		{
			get
			{
				return default(StepState);
			}
		}

		public Vector3 climbingVelocity
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 climbingNormal
		{
			get
			{
				return default(Vector3);
			}
		}

		public void ResetHands(Handedness handedness)
		{
		}

		private IEnumerator CoResetHand(Handedness handedness)
		{
			return null;
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

		public override void OnRigEnable()
		{
		}

		public override void OnRigDisable()
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnAfterFixedUpdate()
		{
		}

		public override void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public void TeleportToPose()
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public void SetBodySlot(SLZ.VRMK.Avatar avatar)
		{
		}

		private void ProcessSlotContainer(SLZ.VRMK.Avatar avatar, SlotContainer slotContainer)
		{
		}

		public void UpdateLadderInfo(LadderInfo info)
		{
		}

		public void LadderForce()
		{
		}

		public bool CheckDoubleJump(float newtonSecond, float cooldown = 1f)
		{
			return default(bool);
		}

		private void DischargeMono()
		{
		}

		public void UpdateTotalDerivatives()
		{
		}

		private void CheckBodyMassDistribution()
		{
		}

		private void SetBodyMassDistribution()
		{
		}

		[ContextMenu("EnableBallLoco")]
		public void EnableBallLoco()
		{
		}

		[ContextMenu("DisableBallLoco")]
		public void DisableBallLoco()
		{
		}

		public void KinematicLegs()
		{
		}

		public void PhysicalLegs()
		{
		}

		[ContextMenu("RagdollRig")]
		public void RagdollRig()
		{
		}

		[ContextMenu("UnRagdollRig")]
		public void UnRagdollRig()
		{
		}

		public void OnMonofootUpdate()
		{
		}

		public void OnMonofootFixedUpdate()
		{
		}

		public void UpdateKnee(float feetTar)
		{
		}

		public void UpdateMonofootColliders()
		{
		}

		public void ApplyFeetForce(Vector3 delta, Vector3 velocity)
		{
		}

		public void CheckStep(Rig inRig, Vector3 inputDelta, Vector3 inputVelocity)
		{
		}

		private bool CheckDangle()
		{
			return default(bool);
		}

		private bool CheckClimb(Rig inRig, float castExtension, float mantle, [Out] Vector3 supportPoint, [Out] Vector3 virtuaPelvisWorld, [Out] Vector3 castDir, [Out] Vector3 trackPhysError, [Out] RaycastHit hitInfo)
		{
			return default(bool);
		}

		private void SwitchStepState(StepState to)
		{
		}

		private bool FootCast(Vector3 inputVelocity, float forwardProject, [Out] RaycastHit hitInfo, [Out] float hitHeight, [Out] float normalHitHeight)
		{
			return default(bool);
		}

		public bool SphereCastExcludeRbHashset(Vector3 origin, float radius, Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance, int layerMask, RaycastHit[] buffer, HashSet<Rigidbody> rbHashSet)
		{
			return default(bool);
		}

		public bool RaycastExcludeRbHashset(Vector3 origin, Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance, int layerMask, RaycastHit[] buffer, HashSet<Rigidbody> rbHashSet)
		{
			return default(bool);
		}

		private void HoldStep(Vector3 inputVelocity)
		{
		}

		private void StepFeet(Vector3 offsetWorld)
		{
		}

		private void ReturnStep(Vector3 inputVelocity)
		{
		}

		public void SetFootballSize(float mult)
		{
		}

		public void UpdateFootballRadius(bool runCheck = false)
		{
		}

		public void SetKneePelvisLimit(float minCrouchMeters, float maxCrouchMeters)
		{
		}

		public PhysicsRig()
			: base()
		{
		}
	}
}
