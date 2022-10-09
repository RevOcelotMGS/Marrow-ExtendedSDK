using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		public class EffectorLink
		{
			public FullBodyBipedEffector effector;

			public Vector3 offset;

			public Vector3 pin;

			public Vector3 pinWeight;

			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			public EffectorLink()
				: base()
			{
			}
		}

		public EffectorLink[] effectorLinks;

		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		public OffsetPose()
			: base()
		{
		}
	}
}
