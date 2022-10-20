using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Vehicle
{
	public class Seat : MonoBehaviour
	{
		private enum SeatState
		{
			Ingress = 0,
			Seated = 1,
			Egress = 2
		}

		private enum AxisAssignment
		{
			LeanFwdBack = 0,
			LeanLeftRight = 1,
			TurnLeftRight = 2,
			UpDownInSeat = 3,
			None = 4
		}

		private const float maxTwistViaInput = 45f;

		public Rigidbody seatRb;

		public Transform footLf;

		public Transform footRt;

		public Vector3 minSeatBounds;

		public Vector3 maxSeatBounds;

		public bool frontIngress;

		public bool leftIngress;

		public bool rightIngress;

		public bool blockUnseatAction;

		[Tooltip("x = flexion, y = rotation, z = lateral flexion, w = extension")]
		public Vector4 spineRom;

		[HideInInspector]
		[SerializeField]
		private AxisAssignment primaryUpDown;

		[HideInInspector]
		[SerializeField]
		private AxisAssignment primaryLeftRight;

		[HideInInspector]
		[SerializeField]
		private AxisAssignment secondaryUpDown;

		[SerializeField]
		[HideInInspector]
		private AxisAssignment secondaryLeftRight;

		private RigManager _rig;

		private ConfigurableJoint _buttJoint;

		private ConfigurableJoint _footJoint;

		private bool _ingressAligned;

		private bool _avatarSwitchedThisPhysStep;

		private float _egressVelocity;

		private Vector2 _primaryAxis;

		private Vector2 _secondaryAxis;

		private Vector3 _ingressReelVelocity;

		private Vector3 _physicalSpineDisplaceInWorld;

		private Vector3 _buttOffset;

		private Vector3 _neutralThorLumbar;

		private Vector3 _locoOffsetInSeat;

		private Vector3 _locoTargetInSeat;

		private Vector3 _locoVelocity;

		private Vector3 _lastPostSpineOffsetWorld;

		private Vector3 _lastPostSpineFeetPosWorld;

		private Vector3 _lastPreSpineInSeat;

		private float _twistOffset;

		private float _twistTarget;

		private float _twistVelocity;

		private float _ingressSmoothTime;

		private Quaternion _initialRotation;

		private Quaternion _lastSeatRotation;

		private SimpleTransform _eyeNeutralInVrRoot;

		private SimpleTransform _buttInSeat;

		private SimpleTransform _ingressReelInSeat;

		private SimpleTransform _footLfInSeat;

		private SimpleTransform _footRtInSeat;

		private VirtualControllerOverride _activeIngressVc1;

		private VirtualControllerOverride _activeIngressVc2;

		private bool _sameFrameHold;

		private SeatState seatState;

		private const float kEpsilon = 1E-06f;

		public float ingressSmoothTime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float seatedPercent { get; private set; }

		public RigManager rigManager
		{
			get
			{
				return null;
			}
		}

		public ConfigurableJoint buttJoint
		{
			get
			{
				return null;
			}
		}

		public Vector3 buttTargetInWorld
		{
			get
			{
				return default(Vector3);
			}
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnDisable()
		{
		}

		public void ToggleSeatLock(bool locked)
		{
		}

		public void IngressRig(RigManager rigManager)
		{
		}

		public void EgressRig(bool immediate)
		{
		}

		public bool TeleportRigToSeat(RigManager rigManager)
		{
			return default(bool);
		}

		private void Register(RigManager rM)
		{
		}

		protected virtual void DeRegister()
		{
		}

		public void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public virtual void OnPlayerEarlyUpdate()
		{
		}

		public virtual bool OnPlayerAbstractInput(Vector2 primaryAxis, Vector2 secondaryAxis)
		{
			return default(bool);
		}

		public virtual Vector3 OnPlayerPreSpine(SimpleTransform head, SimpleTransform chest, SimpleTransform pelvis, float deltaTime, [Out] SimpleTransform pelvisTarget)
		{
			return default(Vector3);
		}

		public virtual Vector3 OnPlayerPostSpine(SimpleTransform head, SimpleTransform chest, SimpleTransform pelvis, float deltaTime, SimpleTransform feet)
		{
			return default(Vector3);
		}

		public virtual void OnPlayerAfterFixedUpdate()
		{
		}

		public virtual void OnPlayerUpdate()
		{
		}

		public virtual void OnPlayerPreArt()
		{
		}

		private Vector3 IngressBlend(float deltaTime)
		{
			return default(Vector3);
		}

		private bool EgressBlend(float deltaTime, [Out] Vector3 egressDelta)
		{
			return default(bool);
		}

		private Vector3 TetherVector3(Vector3 delta, Vector3 position, Vector3 minBound, Vector3 maxBound)
		{
			return default(Vector3);
		}

		private float TetherFloat(float delta, float position, float minBound, float maxBound)
		{
			return default(float);
		}

		private float GetSwingRom(Vector2 axisNormed, [Out] Vector2 xzLimits)
		{
			return default(float);
		}

		private void OnDrawGizmosSelected()
		{
		}

		public Seat()
			: base()
		{
		}

		public event Action RegisteredEvent;

		public event Action DeRegisteredEvent;
	}
}
