using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		public class Avoider
		{
			[Serializable]
			public class EffectorLink
			{
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				public EffectorLink()
					: base()
				{
				}
			}

			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			private Vector3 offset;

			private Vector3 offsetTarget;

			private Vector3 offsetV;

			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			public Avoider()
				: base()
			{
			}
		}

		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		protected override void OnModifyOffset()
		{
		}

		public PenetrationAvoidance()
			: base()
		{
		}
	}
}
