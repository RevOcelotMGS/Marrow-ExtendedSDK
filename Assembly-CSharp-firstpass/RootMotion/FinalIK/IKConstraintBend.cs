using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKConstraintBend
	{
		public Transform bone1;

		public Transform bone2;

		public Transform bone3;

		public Transform bendGoal;

		public Vector3 direction;

		public Quaternion rotationOffset;

		[Range(0f, 1f)]
		public float weight;

		public Vector3 defaultLocalDirection;

		public Vector3 defaultChildDirection;

		[NonSerialized]
		public float clampF;

		private int chainIndex1;

		private int nodeIndex1;

		private int chainIndex2;

		private int nodeIndex2;

		private int chainIndex3;

		private int nodeIndex3;

		private bool limbOrientationsSet;

		public bool initiated { get; private set; }

		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		public IKConstraintBend()
			: base()
		{
		}

		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
			: this()
		{
		}

		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		public void Initiate(IKSolverFullBody solver)
		{
		}

		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
}
