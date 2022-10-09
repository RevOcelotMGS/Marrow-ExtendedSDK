using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKMappingSpine : IKMapping
	{
		public Transform[] spineBones;

		public Transform leftUpperArmBone;

		public Transform rightUpperArmBone;

		public Transform leftThighBone;

		public Transform rightThighBone;

		[Range(1f, 3f)]
		public int iterations;

		[Range(0f, 1f)]
		public float twistWeight;

		private int rootNodeIndex;

		private BoneMap[] spine;

		private BoneMap leftUpperArm;

		private BoneMap rightUpperArm;

		private BoneMap leftThigh;

		private BoneMap rightThigh;

		private bool useFABRIK;

		public override bool IsValid(IKSolver solver, string message)
		{
			return default(bool);
		}

		public IKMappingSpine()
			: base()
		{
		}

		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
			: this()
		{
		}

		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
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

		private bool UseFABRIK()
		{
			return default(bool);
		}

		public void ReadPose()
		{
		}

		public void WritePose(IKSolverFullBody solver)
		{
		}

		public void ForwardReach(Vector3 position)
		{
		}

		private void BackwardReach(Vector3 position)
		{
		}

		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
}
