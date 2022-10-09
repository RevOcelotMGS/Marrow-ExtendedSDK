using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class GenericGrip : Grip
	{
		private class HandToGenericGripState
		{
			public bool isRaycastHit;

			public Vector3 raycastNormal;

			public Vector3 raycastPoint;

			public SimpleTransform worldHandleTransform;

			public Vector3 backOfHandNormal;

			public HandToGenericGripState()
				: base()
			{
			}
		}

		private Dictionary<Hand, HandToGenericGripState> genericHandStates;

		private List<Collider> _targetColliders;

		protected override void Awake()
		{
		}

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

		protected override void UpdateJointConfiguration(Hand hand)
		{
		}

		protected override void SetupConfiguration(HandJointConfiguration config)
		{
		}

		public GenericGrip()
			: base()
		{
		}
	}
}
