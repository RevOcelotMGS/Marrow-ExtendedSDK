using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		public Transform bone;

		[Range(0f, 1f)]
		public float maintainRotationWeight;

		private BoneMap boneMap;

		public override bool IsValid(IKSolver solver, string message)
		{
			return default(bool);
		}

		public IKMappingBone()
			: base()
		{
		}

		public IKMappingBone(Transform bone)
			: this()
		{
		}

		public void StoreDefaultLocalState()
		{
		}

		public void FixTransforms()
		{
		}

		public override void Initiate(IKSolverFullBody solver)
		{
		}

		public void ReadPose()
		{
		}

		public void WritePose(float solverWeight)
		{
		}
	}
}
