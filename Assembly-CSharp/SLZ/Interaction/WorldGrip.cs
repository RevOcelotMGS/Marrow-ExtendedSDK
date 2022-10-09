using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class WorldGrip : Grip
	{
		private class HandToGenericGripState
		{
			public bool isRaycastHit;

			public Vector3 raycastNormal;

			public Vector3 raycastPoint;

			public SimpleTransform worldHandleTransform;

			public Vector3 backOfHandNormal;

			public Collider[] targetColliders;

			public int targetColliderCount;

			public HandToGenericGripState()
				: base()
			{
			}
		}

		private Dictionary<Hand, HandToGenericGripState> genericHandStates;

		private List<Collider> ignoreColliders;

		protected override void Start()
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public override float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default(float);
		}

		public override void OnAttachedToHand(Hand hand)
		{
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		public override void OnJointAttached(Hand hand)
		{
		}

		protected override void UpdateJointConfiguration(Hand hand)
		{
		}

		protected override void SetupConfiguration(HandJointConfiguration config)
		{
		}

		public WorldGrip()
			: base()
		{
		}
	}
}
