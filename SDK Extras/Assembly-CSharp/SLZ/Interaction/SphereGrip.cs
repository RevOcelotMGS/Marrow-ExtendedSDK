using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SphereGrip : TargetGrip
	{
		[Tooltip("Auto configure friction, limit, and radius")]
		[Header("Sphere Options")]
		public bool autoConfigure;

		[Tooltip("Overwritten by autoconfigure")]
		public float dynamicFriction;

		[Tooltip("Overwritten by autoconfigure")]
		public float staticFriction;

		private HashSet<Hand> _isJointFree;

		private float _maxRadius;

		protected override void Awake()
		{
		}

		public override SimpleTransform GetVirtualTargetInHost(Hand hand)
		{
			return default(SimpleTransform);
		}

		public bool IsJointFree(Hand hand)
		{
			return default(bool);
		}

		public override SimpleTransform GetForcePullHandTransform(Hand hand)
		{
			return default(SimpleTransform);
		}

		private Quaternion GetTargetFlippedRotation(Hand hand)
		{
			return default(Quaternion);
		}

		public override SimpleTransform GetNeutralTargetInWorld(Hand hand)
		{
			return default(SimpleTransform);
		}

		public override SimpleTransform GetForcePullTransform(Hand hand)
		{
			return default(SimpleTransform);
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public override bool OnHandHoverUpdate(Hand hand, bool isOverride)
		{
			return default(bool);
		}

		public override void OnRTSkeleFixedUpdate(Hand hand)
		{
		}

		private SimpleTransform SolveTargetInLimits(Hand hand, SimpleTransform newTargetInWorld, bool applyOffsetBlending = true)
		{
			return default(SimpleTransform);
		}

		private void LockJoint(Hand hand)
		{
		}

		private void FreeJoint(Hand hand)
		{
		}

		private void UpdateTargetFromHand(Hand hand)
		{
		}

		private SimpleTransform ClampHandleInTarget(SimpleTransform handleInTarget)
		{
			return default(SimpleTransform);
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

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		public override void CheckHandPriority(HandGripPair primary, HandGripPair secondary)
		{
		}

		protected override void SetupConfiguration(HandJointConfiguration config)
		{
		}

		public override float GetSwingLimit(Hand hand)
		{
			return default(float);
		}

		protected override void UpdateJointConfiguration(Hand hand)
		{
		}

		public override float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default(float);
		}

		public SphereGrip()
			: base()
		{
		}
	}
}
