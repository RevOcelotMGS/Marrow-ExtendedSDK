using System;
using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using SLZ.UI;
using SLZ.VRMK;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Rig
{
	public class ControllerRig : Rig
	{
		public enum TraversalState
		{
			Walk = 0,
			Jog = 1,
			Run = 2,
			Jump = 3,
			Leap = 4,
			Airborne = 5,
			HandClimb = 6,
			QuadClimb = 7,
			FootClimb = 8
		}

		public enum VertState
		{
			Stand = 0,
			Crouch = 1,
			Kneel = 2,
			Prone = 3,
			Supine = 4,
			SitChair = 5,
			SitFloor = 6
		}

		public enum DirectionMode
		{
			Controller = 0,
			Head = 1,
			Custom = 2
		}

		public enum CurveMode
		{
			Linear = 0,
			Poles = 1,
			GenesisDpad = 2,
			Dpad = 3,
			SmoothGenesis = 4,
			SmoothDpad = 5
		}

		public enum VrVertState
		{
			Stand = 0,
			Crouch = 1,
			Sit = 2,
			Kneel = 3,
			Prone = 4
		}

		public enum ThirdPersonCameraMode
		{
			World = 0,
			LocalWorld = 1
		}

		[Header("Controller Vars")]
		public BaseController leftController;

		public BaseController rightController;

		public Transform vrRoot;

		[Header("Enabled Inputs")]
		public bool primaryEnabled;

		public bool jumpEnabled;

		public bool quickmenuEnabled;

		public bool slowMoEnabled;

		public bool isRightHanded;

		public bool autoLiftLegs;

		public bool doubleJump;

		[Header("Movement")]
		public float maxVelocity;

		public float maxAcceleration;

		public float jumpVelocity;

		public float dragPerSec;

		public float brakingMult;

		public float doubleJumpPower;

		public TraversalState travState;

		public VertState vertState;

		private Vector2 _currentVelocity;

		private Vector2 _currentAcceleration;

		protected float currentMaxVelocity;

		public float feetOffset;

		public AnimationCurve JumpCurve;

		protected bool _feetThisFrame;

		protected float _crouchTarget;

		protected float _crouchLimit;

		protected bool _crouchHeld;

		private bool _chargeInput;

		private HeadSFX _headSfx;

		private bool _jumping;

		private int _jumpStage;

		private float _jumpCycle;

		private float _timeOfFlight;

		private float _jumpCharge;

		private Vector2 _trackedDebt;

		private Vector2 _locoDebt;

		private Vector2 _physDebt;

		private Vector2 _trackedApplied;

		private Vector2 _locoApplied;

		private Vector2 _physApplied;

		private Vector2 _artificialDelta;

		protected Vector3 _lastTrackedHead;

		protected SimpleTransform _lastHmdLocal;

		protected SimpleTransform _lastContLfLocal;

		protected SimpleTransform _lastContRtLocal;

		private Vector3 _trackedHeadDelta;

		[Range(0f, 1f)]
		public float holdTrackedGround;

		[Range(0f, 1f)]
		public float holdLocoGround;

		[Range(0f, 1f)]
		public float holdPhysGround;

		[Range(0.1f, 5f)]
		public float debtApplierMult;

		public float realDeltaTime;

		protected float lastFixedTime;

		private float _spineCrouchOff;

		[Header("Steam Vars")]
		public AnimationCurve curve_Linear;

		public AnimationCurve curve_Poles;

		[FormerlySerializedAs("curve_OctoWeighted")]
		public AnimationCurve curve_Genesis;

		public AnimationCurve curve_Dpad;

		[FormerlySerializedAs("curve_Brandons")]
		public AnimationCurve curve_SmoothGenesis;

		[FormerlySerializedAs("curve_Alexs")]
		public AnimationCurve curve_SmoothDpad;

		protected AnimationCurve touchPadCurve;

		private float _twistDebt;

		private float _twistDebtVel;

		private float _smoothTwist;

		[Space(10f)]
		public float degreesPerSnap;

		public int snapDegreesPerFrame;

		public AnimationCurve SwingCounterCurve;

		public VrVertState vrVertState;

		public DirectionMode directionMode;

		public CurveMode curveMode;

		public Transform CustomDirection;

		private Transform controllerTransform;

		private Transform hmdTransform;

		private Transform directionMasterTransform;

		private float _jogCoolTime;

		private bool _secondaryFlickReady;

		[Header("Knoll Filter")]
		[Range(0f, 20f)]
		public float maxMillimeters;

		[Range(0f, 20f)]
		public float maxDegreesSwing;

		public Transform leftFilter;

		public Transform rightFilter;

		public Transform trackerChest;

		public Transform trackerPelvis;

		public Transform trackerFootLf;

		public Transform trackerFootRt;

		protected Vector2 _doubleFlickMem;

		protected float _lastFlickTime;

		protected bool _wasOverFlickThresh;

		protected float _turnVel;

		protected float _smoothInput;

		protected bool _lockViveJump;

		[Header("Popup UI")]
		[Space(10f)]
		public GameObject menu_UI_Left;

		public GameObject menu_UI_Right;

		protected Control_UI_PopUpMenu popUp_UI_Left;

		protected Control_UI_PopUpMenu popUp_UI_Right;

		protected bool menu_Left_Active;

		protected bool menu_Right_Active;

		protected bool lockMenus;

		protected int _fixedCount;

		protected float _time;

		protected float _deltaTime;

		protected float _realTime;

		protected bool _runFixedUpdates;

		private bool _ballLocoEnabled;

		public static Action<float> onPlayerJump;

		private static bool _isPaused;

		private Vector2 _axisPrimary;

		private Vector2 _axisSecondary;

		protected bool _primaryStick;

		protected bool _primaryStickUp;

		protected bool _primaryStickDown;

		protected bool _primaryStickTouch;

		protected bool _secondaryStick;

		protected bool _secondaryStickUp;

		protected bool _secondaryStickDown;

		protected bool _secondaryStickTouch;

		protected bool _axisPrimaryDirty;

		protected bool _primaryAButton;

		protected bool _primaryAButtonUp;

		protected bool _primaryAButtonDown;

		protected bool _secondaryAButton;

		protected bool _secondaryAButtonUp;

		protected bool _secondaryAButtonDown;

		public bool IsMenuTapDisabled;

		public static Action<bool> OnPauseStateChange;

		private bool _counterDirty;

		private float _counterAngle;

		private Vector3 _counterAxis;

		private SimpleTransform _vrRootCounterCache;

		private Quaternion _rotationOffset;

		private bool _rotationOffsetDirty;

		private bool _rotationOffsetWasDirty;

		protected bool CooledJogTog
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsPaused
		{
			get
			{
				return default(bool);
			}
			protected set
			{
			}
		}

		public override void OnRigEnable()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnAfterFixedUpdate()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		protected virtual void ApplyMovement(Vector2 axis, bool inputPressed, float deltaTime)
		{
		}

		private Vector2 LocoDebtPre(Vector2 artiDelta, float deltaTime)
		{
			return default(Vector2);
		}

		private void LocoDebtPost()
		{
		}

		private void SnapRotate(bool inputPressed, float x = 0f)
		{
		}

		private void SmoothRotate(float input, float deltaTime)
		{
		}

		private void ApplyRotation(float deltaTime)
		{
		}

		private void CounterRotateForRender(bool undo)
		{
		}

		public void SetTwist(float degrees)
		{
		}

		public void SetRotate(Quaternion offset)
		{
		}

		private void JumpCharge(float deltaTime, bool chargeInput = true)
		{
		}

		private void Jump()
		{
		}

		private void Jumping(float deltaTime)
		{
		}

		private void JumpEnd()
		{
		}

		protected virtual void CrouchHold(float deltaTime, float crouchRate = -1f, bool crouchInput = true)
		{
		}

		protected void MoveSpineCrouchOffTowards(float target, float deltaTime, float rate = 6.5f)
		{
		}

		private bool MantleGesture([Out] float mantle)
		{
			return default(bool);
		}

		protected virtual void QuickMenuLf(bool down = true)
		{
		}

		protected virtual void QuickMenuRt(bool down = true)
		{
		}

		private bool MagnitudeRemapAxis(Vector2 axis, float minLerp, float maxLerp, [Out] Vector2 axisProcessed)
		{
			return default(bool);
		}

		private void ProcessSecondaryThumbstick(Vector2 axis, float deltaTime)
		{
		}

		private void ProcessSecondaryTouchpad(Vector2 axis, [Out] Vector2 secondaryAxis, [Out] bool secondaryAButtonHold)
		{
		}

		private bool CheckDoubleFlick(Vector2 axis, float time, Vector2 doubleFlickMem, float lastFlickTime, bool wasOverFlickThresh)
		{
			return default(bool);
		}

		public override void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public void SetDirectionMasterTransform(DirectionMode directionMode)
		{
		}

		public void SetTouchPadCurve(CurveMode curveMode)
		{
		}

		public Vector3 GetTrackedHeadDelta()
		{
			return default(Vector3);
		}

		public Vector2 GetAcceleration()
		{
			return default(Vector2);
		}

		public Vector2 GetVelocity()
		{
			return default(Vector2);
		}

		public BaseController GetController(Handedness handedness)
		{
			return null;
		}

		private Vector2 TouchPadCurve(Vector2 axis, AnimationCurve curve)
		{
			return default(Vector2);
		}

		private void KnollFilter(Transform filter, Vector3 trackedPos, Quaternion trackedRot, float grip = 1f)
		{
		}

		public ControllerRig()
			: base()
		{
		}
	}
}
