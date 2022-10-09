using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic
	{
		public IterationDelegate OnPreIteration;

		public void FadeOutBoneWeights()
		{
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void Solve(Vector3 targetPosition)
		{
		}

		public IKSolverCCD()
			: base()
		{
		}
	}
}
