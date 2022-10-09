using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Input;
using UnityEngine;

namespace SLZ.Rig
{
	public class BaseController : MonoBehaviour
	{
		public enum GesturePose
		{
			OpenHand = 0,
			IndexPoint = 1,
			MiddleFinger = 2,
			PeaceSign = 3,
			ThumbsUp = 4,
			ThumbsDown = 5,
			Fist = 6
		}

		public Handedness handedness;

		[HideInInspector]
		public ControllerRig manager;

		private Haptor _haptor;

		protected GesturePose _gesturePose;

		protected float _nextGestureUpdateTime;

		protected float _gesturePoseIntensity;

		protected bool isBelowGripThreshold;

		protected bool isGrabInputPressedFinal;

		protected bool isGrabInputReleasedFinal;

		protected bool _isGrabInputPressedState;

		protected bool _isGrabInputReleasedState;

		protected float _simGripAxisVive;

		protected float _simIndexTouch;

		protected float _simThumbAxis;

		protected float _simGripAxisHolo;

		protected float _processedIndex;

		protected float _processedMiddle;

		protected float _processedRing;

		protected float _processedPinky;

		protected float _processedThumb;

		protected float _solvedGrip;

		protected float _solvedGripVelocity;

		protected float _lastTimeGrabbed;

		protected Vector3 _localVelocity;

		protected Vector3 _lastHandHeadPos;

		protected float _primaryAxis;

		protected float _gripForce;

		protected float _menuTapTimer;

		protected Vector2 _thumbstickAxis;

		protected Vector2 _touchPadAxis;

		protected bool _primaryInteractionButton;

		protected bool _primaryInteractionButtonUp;

		protected bool _primaryInteractionButtonDown;

		protected bool _secondaryInteractionButton;

		protected bool _secondaryInteractionButtonUp;

		protected bool _secondaryInteractionButtonDown;

		protected bool _thumbstick;

		protected bool _thumbstickUp;

		protected bool _thumbstickDown;

		protected bool _thumbstickTouch;

		protected bool _touchPad;

		protected bool _touchPadUp;

		protected bool _touchPadDown;

		protected bool _touchPadTouch;

		protected bool _aButton;

		protected bool _aButtonUp;

		protected bool _aButtonDown;

		protected bool _bButton;

		protected bool _bButtonUp;

		protected bool _bButtonDown;

		protected bool _menuTap;

		protected bool _isThumbTouch;

		protected bool _appMenuUp;

		protected bool _appMenuDown;

		protected bool _appMenu;

		public XRControllerType Type { get; protected set; }

		public Haptor haptor
		{
			get
			{
				return null;
			}
		}

		public virtual GesturePose GetGesturePose([Out] float poseIntensity, bool forceUpdate = false)
		{
			return default(GesturePose);
		}

		public virtual void OnUpdate()
		{
		}

		public virtual void OnFixedUpdate(float secFromNow = 0f)
		{
		}

		public virtual void OnVrFixedUpdate(Vector3 headPos)
		{
		}

		public virtual bool GetPrimaryInteractionButtonDown()
		{
			return default(bool);
		}

		public virtual bool GetPrimaryInteractionButtonUp()
		{
			return default(bool);
		}

		public virtual bool GetPrimaryInteractionButton()
		{
			return default(bool);
		}

		public virtual float GetPrimaryInteractionButtonAxis()
		{
			return default(float);
		}

		public virtual bool GetSecondaryInteractionButtonDown()
		{
			return default(bool);
		}

		public virtual float GetSecondaryInteractionButtonAxis()
		{
			return default(float);
		}

		public virtual bool GetSecondaryInteractionButtonUp()
		{
			return default(bool);
		}

		public virtual bool GetSecondaryInteractionButton()
		{
			return default(bool);
		}

		public virtual float GetGripForce()
		{
			return default(float);
		}

		public virtual float GetIndexCurlAxis()
		{
			return default(float);
		}

		public virtual float GetMiddleCurlAxis()
		{
			return default(float);
		}

		public virtual float GetRingCurlAxis()
		{
			return default(float);
		}

		public virtual float GetPinkyCurlAxis()
		{
			return default(float);
		}

		public virtual float GetThumbCurlAxis()
		{
			return default(float);
		}

		public virtual bool HasBeenGrabbed()
		{
			return default(bool);
		}

		public virtual void ClearHasBeenGrabbed()
		{
		}

		public virtual float GetLastTimeGrabbed()
		{
			return default(float);
		}

		public virtual bool IsGrabbed()
		{
			return default(bool);
		}

		public virtual bool IsReleased()
		{
			return default(bool);
		}

		public virtual bool GetGrabbedState()
		{
			return default(bool);
		}

		public virtual bool GetReleasedState()
		{
			return default(bool);
		}

		public virtual bool GetSecondaryMenuButtonDown()
		{
			return default(bool);
		}

		public virtual bool GetSecondaryMenuButtonUp()
		{
			return default(bool);
		}

		public virtual bool GetSecondaryMenuButton()
		{
			return default(bool);
		}

		public virtual bool GetMenuTap()
		{
			return default(bool);
		}

		public virtual bool GetAppMenuDown()
		{
			return default(bool);
		}

		public virtual bool GetAppMenuUp()
		{
			return default(bool);
		}

		public virtual bool GetAppMenu()
		{
			return default(bool);
		}

		public virtual bool GetMenuButtonDown()
		{
			return default(bool);
		}

		public virtual bool GetMenuButtonUp()
		{
			return default(bool);
		}

		public virtual bool GetMenuButton()
		{
			return default(bool);
		}

		public virtual float GetGripVelocity()
		{
			return default(float);
		}

		public virtual void HapticAction(float secondsFromNow, float durationSeconds, float frequency, float amplitude)
		{
		}

		public virtual void Haptic(float microFloat)
		{
		}

		public virtual bool GetAButtonDown()
		{
			return default(bool);
		}

		public virtual bool GetAButtonUp()
		{
			return default(bool);
		}

		public virtual bool GetAButton()
		{
			return default(bool);
		}

		public virtual bool GetBButtonDown()
		{
			return default(bool);
		}

		public virtual bool GetBButtonUp()
		{
			return default(bool);
		}

		public virtual bool GetBButton()
		{
			return default(bool);
		}

		public virtual Vector2 GetThumbStickAxis()
		{
			return default(Vector2);
		}

		public virtual bool GetThumbStickDown()
		{
			return default(bool);
		}

		public virtual bool GetThumbStickUp()
		{
			return default(bool);
		}

		public virtual bool GetThumbStick()
		{
			return default(bool);
		}

		public virtual bool GetThumbStickTouch()
		{
			return default(bool);
		}

		public virtual Vector2 GetTouchPadAxis()
		{
			return default(Vector2);
		}

		public virtual bool GetTouchPadDown()
		{
			return default(bool);
		}

		public virtual bool GetTouchPadUp()
		{
			return default(bool);
		}

		public virtual bool GetTouchPad()
		{
			return default(bool);
		}

		public virtual bool GetTouchPadTouch()
		{
			return default(bool);
		}

		public virtual bool GetThumbTouch()
		{
			return default(bool);
		}

		public virtual Vector3 GetRelativeVelocityInWorld()
		{
			return default(Vector3);
		}

		public void StampController(BaseController fromController)
		{
		}

		public BaseController()
			: base()
		{
		}
	}
}
