using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Interaction
{
	public class Hand : MonoBehaviour
	{
		private static ComponentCache<Hand> _cache;

		public Action<HandReciever> onRecieverAttached;

		public Action<HandReciever> onRecieverDetached;

		public Action<HandReciever> onRecieverHoverBegin;

		public Action<HandReciever> onRecieverHoverEnd;

		public Action onRTSkeleFixedUpdateDelegate;

		public Action<Hand, Vector3> onAnchorUpdate;

		public Action<Hand, Vector3> onConnectedAnchorUpdate;

		private HandReciever _mHoveringReceiver;

		private HandReciever m_FarHoveringReciever;

		private GameObject m_CurrentAttachedGO;

		private const int m_ColliderArraySize = 64;

		private Collider[] m_OverlappingColliders;

		private Collider[] m_HandColliders;

		private List<Collider> m_IgnoredColliders;

		private bool m_IsWarmup;

		public Collider collider;

		[HideInInspector]
		public Quaternion jointStartRotation;

		public ConfigurableJoint joint;

		public ConfigurableJoint tempJoint;

		[HideInInspector]
		public Rigidbody rb;

		[HideInInspector]
		public PhysHand physHand;

		[HideInInspector]
		public RigManager manager;

		public GameObject triggerRefProxyObject;

		public Handedness handedness;

		public Hand otherHand;

		public Transform palmPositionTransform;

		public LayerMask hoverLayerMask;

		public LayerMask farHoverLayerMask;

		public LayerMask playerLayerMask;

		public bool farHoverEnabled;

		private float _hoverSphereRadius;

		public HashSet<HandReciever> ignoredRecievers;

		private BaseController _controller;

		private SkeletonHand _virtualHeptaHand;

		private SkeletonHand _skeleton;

		private HandPoseAnimator _animator;

		public InventorySlot slot;

		private ConfigurableJoint _forearmJoint;

		private ConfigurableJoint _upperarmJoint;

		private bool _isTriggerPulledOnAttach;

		private bool _indexButtonDown;

		private bool _indexButtonUp;

		private bool _indexButton;

		private float _indexTriggerAxis;

		public static ComponentCache<Hand> Cache
		{
			get
			{
				return null;
			}
		}

		public float HoverSphereRadius
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public BaseController Controller
		{
			get
			{
				return null;
			}
		}

		public SkeletonHand VirtualHeptaHand
		{
			get
			{
				return null;
			}
		}

		public SkeletonHand Skeleton
		{
			get
			{
				return null;
			}
		}

		public HandPoseAnimator Animator
		{
			get
			{
				return null;
			}
		}

		public bool hoverLocked { get; private set; }

		public HandReciever AttachedReceiver { get; private set; }

		public HandReciever HoveringReceiver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HandReciever farHoveringReciever
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool GrabLock { get; private set; }

		private IEnumerator Start()
		{
			return null;
		}

		public void SetManager(RigManager m)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetGrabLock()
		{
		}

		public void AttachObject(GameObject objectToAttach)
		{
		}

		public void DetachJoint(bool isQuick = false, Grip lastGrip = default(Grip))
		{
		}

		private IEnumerator CoDelayDestroyJoint(ConfigurableJoint myJoint, bool isQuick, Grip lastGrip)
		{
			return null;
		}

		public void SetGripStrength(float perc)
		{
		}

		public SimpleTransform GetGripInHand()
		{
			return default(SimpleTransform);
		}

		public void UnignoreHostColliders(Grip grip)
		{
		}

		public void IgnoreHostColliders(Grip grip)
		{
		}

		public void PrepareJoint(GameObject objectToAttach, bool isSilent = false, Action OnBeforeAttach = default(Action))
		{
		}

		public void AttachJoint(GameObject objectToAttach)
		{
		}

		public void AttachIgnoreBodyJoints(GameObject objectToAttach)
		{
		}

		public void DetachIgnoreBodyJoints()
		{
		}

		public void DisableCollider()
		{
		}

		public void EnableCollider()
		{
		}

		public void OnRTSkeleFixedUpdate()
		{
		}

		public void OnPhysRigEarlyUpdate()
		{
		}

		public void OnPhysRigUpdate()
		{
		}

		private static Quaternion SynthesizeRotation(Vector3 right, Vector3 up)
		{
			return default(Quaternion);
		}

		public float WristToForearmAngle()
		{
			return default(float);
		}

		public void DetachObject()
		{
		}

		private void UpdateHovering()
		{
		}

		public SimpleTransform GetHandleInWorld()
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetControllerWristTransform(bool useSkeleOffset = true)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetControllerHandleTransform(HandPose handPose, bool useSkeleOffset = false)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetControllerHandleTransform(bool useSkeleOffset = true)
		{
			return default(SimpleTransform);
		}

		public bool HasAttachedObject()
		{
			return default(bool);
		}

		public void HoverLock()
		{
		}

		public void HoverUnlock()
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}

		private IEnumerator CoJointBreakCooldown()
		{
			return null;
		}

		private void CreateConfigurableJoint()
		{
		}

		public void UpdateConnectedAnchor(Vector3 connectedAnchor = default(Vector3), ConfigurableJoint j = default(ConfigurableJoint))
		{
		}

		public void UpdateConnectedAnchor(Vector3 connectedAnchor = default(Vector3))
		{
		}

		public void UpdateAnchor(Vector3 anchor = default(Vector3), ConfigurableJoint j = default(ConfigurableJoint))
		{
		}

		public void UpdateAnchor(Vector3 anchor = default(Vector3))
		{
		}

		private void EarlyUpdateHeldObjectInputs()
		{
		}

		private void SetIndexButtonAndTrigger()
		{
		}

		public bool GetIndexButtonDown()
		{
			return default(bool);
		}

		public bool GetIndexButtonUp()
		{
			return default(bool);
		}

		public bool GetIndexButton()
		{
			return default(bool);
		}

		public float GetIndexTriggerAxis()
		{
			return default(float);
		}

		public Hand()
			: base()
		{
		}
	}
}
