using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class Inertia : OffsetModifier
	{
		[Serializable]
		public class Body
		{
			[Serializable]
			public class EffectorLink
			{
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Tooltip("Weight of using this effector")]
				public float weight;

				public EffectorLink()
					: base()
				{
				}
			}

			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Tooltip("gravity applied to the Body")]
			public float gravity;

			private Vector3 delta;

			private Vector3 lazyPoint;

			private Vector3 direction;

			private Vector3 lastPosition;

			private bool firstUpdate;

			public void Reset()
			{
			}

			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			public Body()
				: base()
			{
			}
		}

		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		public void ResetBodies()
		{
		}

		protected override void OnModifyOffset()
		{
		}

		public Inertia()
			: base()
		{
		}
	}
}
