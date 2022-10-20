using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Interaction
{
	public class Grip : HandReciever
	{
		public delegate void HandDelegate(Hand hand);

		private static ComponentCache<Grip> _cache;

		[Header("Grip")]
		public bool isThrowable;

		[Tooltip("use the original target grip when attaching the joint, not the virtualized one")]
		public bool ignoreGripTargetOnAttach;

		[HideInInspector]
		public Collider[] gripColliders;

		public Collider[] additionalGripColliders;

		private Vector3[] velocityHistory;

		private Vector3[] angVelocityHistory;

		private int velocityHistoryIndex;

		private Dictionary<Hand, SimpleTransform> gripTargetsInBaseTarget;

		private Dictionary<Hand, HandToGripState> _handStates;

		protected List<Hand> attachedHands;

		public AnimationCurve handleAmplifyCurve;

		public HandPose handPose;

		public Vector3 primaryMovementAxis;

		public Vector3 secondaryMovementAxis;

		[EnumFlags]
		[SerializeField]
		public InteractionOptions gripOptions;

		[Tooltip("Zero priority guarantees grip victory. 1 is Neutral >1 is low priority")]
		[Range(0f, 10f)]
		public float priority;

		public float minBreakForce;

		public float maxBreakForce;

		public float defaultGripDistance;

		[HideInInspector]
		public float gripDistanceSqr;

		private float _gripDistance;

		private bool hasStartedToGrip;

		protected bool _isInteractionDisabled;

		public float radius;

		public Transform targetTransform;

		public new static ComponentCache<Grip> Cache
		{
			get
			{
				return null;
			}
		}

		public float gripDistance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnDisable()
		{
		}

		public VirtualController GetVirtualController(Hand hand)
		{
			return null;
		}

		public virtual void CheckHandPriority(HandGripPair primary, HandGripPair secondary)
		{
		}

		public bool CanUpdateConnectedAnchor(Hand hand)
		{
			return default(bool);
		}

		public void SolveHandleAmplify(Hand hand)
		{
		}

		public SimpleTransform SolveHandTarget(Hand hand)
		{
			return default(SimpleTransform);
		}

		public virtual SimpleTransform GetVirtualTargetInHost(Hand hand)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetTargetInHost(Hand hand)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetTargetInBase(Hand hand)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetTargetInWorld(Hand hand)
		{
			return default(SimpleTransform);
		}

		public virtual SimpleTransform GetNeutralTargetInWorld(Hand hand)
		{
			return default(SimpleTransform);
		}

		public void SetTargetInBase(Hand hand, Vector3 localPosition = default(Vector3), Quaternion localRotation = default(Quaternion))
		{
		}

		public SimpleTransform SetTargetInWorld(Hand hand, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion))
		{
			return default(SimpleTransform);
		}

		protected void RemoveTarget(Hand hand)
		{
		}

		public SimpleTransform GetHandInTarget(Hand hand)
		{
			return default(SimpleTransform);
		}

		public virtual float GetSwingLimit(Hand hand)
		{
			return default(float);
		}

		public virtual float GetTwistLimit(Hand hand)
		{
			return default(float);
		}

		public bool HasGripFlag(Hand hand, GripFlags flag)
		{
			return default(bool);
		}

		public void AddGripFlag(Hand hand, GripFlags flag)
		{
		}

		public void RemoveGripFlag(Hand hand, GripFlags flag)
		{
		}

		public virtual Vector3 GetPrimaryAxis(Hand hand = default(Hand))
		{
			return default(Vector3);
		}

		public virtual Vector3 GetSecondaryAxis(Hand hand = default(Hand))
		{
			return default(Vector3);
		}

		public virtual Vector3 GetTertiaryAxis(Hand hand = default(Hand))
		{
			return default(Vector3);
		}

		public Quaternion HandleAxisSpace()
		{
			return default(Quaternion);
		}

		public Quaternion GetPrimaryAxisInversedRotation()
		{
			return default(Quaternion);
		}

		public Quaternion GetSecondaryAxisInversedRotation()
		{
			return default(Quaternion);
		}

		public virtual SimpleTransform GetForcePullTransform(Hand hand)
		{
			return default(SimpleTransform);
		}

		public virtual SimpleTransform GetForcePullHandTransform(Hand hand)
		{
			return default(SimpleTransform);
		}

		public void SetHandPose(Hand hand, HandPose handPose)
		{
		}

		public void RemoveHandPose(Hand hand)
		{
		}

		public HandPose GetHandPose(Hand hand = default(Hand))
		{
			return null;
		}

		protected virtual void SetupConfiguration(HandJointConfiguration config)
		{
		}

		protected virtual void UpdateJointConfiguration(Hand hand)
		{
		}

		public override void DisableInteraction()
		{
		}

		public override void EnableInteraction()
		{
		}

		public void ForceDetach(bool isQuick)
		{
		}

		public void ForceDetach()
		{
		}

		public void ForceDetach(Hand hand)
		{
		}

		public bool GetController([Out] BaseController controller)
		{
			return default(bool);
		}

		public bool HasAttachedHands()
		{
			return default(bool);
		}

		public Hand GetHand()
		{
			return null;
		}

		public HandToGripState GetHandState(Hand hand)
		{
			return null;
		}

		public virtual SimpleTransform GetGripNeutral(Hand hand)
		{
			return default(SimpleTransform);
		}

		protected void DisplayJointDebugger(ConfigurableJoint joint, Vector3 limits, SimpleTransform s, Quaternion worldRotation, Quaternion localRotation)
		{
		}

		private void SaveHistory(Vector3 velocity, Vector3 angVelocity)
		{
		}

		private void ClearHistory()
		{
		}

		private Vector3 GetAverageHistory(int start, int samples, [Out] Vector3 angVelocity)
		{
			return default(Vector3);
		}

		private Vector3 GetAverageHistory(float startDelayTime, float sampleTime, [Out] Vector3 angVelocity)
		{
			return default(Vector3);
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		private ValueTuple<Vector3, Vector3> CalculateDetatchVelocitys(float startDelayTime, float sampleTime, float amplificationMult, Vector3 wholeBodyVelocity)
		{
			return default(ValueTuple<Vector3, Vector3>);
		}

		public override void OnJointAttached(Hand hand)
		{
		}

		public override void OnAttachedToHand(Hand hand)
		{
		}

		public override void OnDetachedFromHand(Hand hand)
		{
		}

		public virtual void OnRTSkeleFixedUpdate(Hand hand)
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public void OnGrabConfirm(Hand hand, bool isOverride)
		{
		}

		public virtual bool OnHandHoverUpdate(Hand hand, bool isOverride)
		{
			return default(bool);
		}

		public override void OnHandHoverBegin(Hand hand)
		{
		}

		public virtual void OnHandHoverBegin(Hand hand, bool isOverride)
		{
		}

		public override void OnHandHoverEnd(Hand hand)
		{
		}

		public override void OnFarHandHoverUpdate(Hand hand)
		{
		}

		public override void OnFarHandHoverBegin(Hand hand)
		{
		}

		public override void OnFarHandHoverEnd(Hand hand)
		{
		}

		public override float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default(float);
		}

		[ContextMenu("Get Sub Colliders")]
		public void GetSubColliders()
		{
		}

		public virtual void CancelSnatch(Hand hand)
		{
		}

		public virtual void Snatch(Hand hand, bool isQuick = false)
		{
		}

		private IEnumerator CoSnatch(Hand hand, bool isQuick)
		{
			return null;
		}

		public Grip()
			: base()
		{
		}

		public event HandDelegate attachedUpdateDelegate;

		public event HandDelegate hoverBeginHandDelegate;

		public event HandDelegate hoverEndHandDelegate;

		public event HandDelegate hoverUpdateHandDelegate;

		public event HandDelegate farHoverBeginHandDelegate;

		public event HandDelegate farHoverEndHandDelegate;

		public event HandDelegate farHoverUpdateHandDelegate;

		public event HandDelegate attachedHandDelegate;

		public event HandDelegate detachedHandDelegate;

		public event HandDelegate forcePullCompleteDelegate;
	}
}
