using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class FBIKChain
	{
		[Serializable]
		public class ChildConstraint
		{
			public float pushElasticity;

			public float pullElasticity;

			[SerializeField]
			private Transform bone1;

			[SerializeField]
			private Transform bone2;

			private float crossFade;

			private float inverseCrossFade;

			private int chain1Index;

			private int chain2Index;

			public float nominalDistance { get; private set; }

			public bool isRigid { get; private set; }

			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
				: base()
			{
			}

			public void Initiate(IKSolverFullBody solver)
			{
			}

			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		public enum Smoothing
		{
			None = 0,
			Exponential = 1,
			Cubic = 2
		}

		[Range(0f, 1f)]
		public float pin;

		[Range(0f, 1f)]
		public float pull;

		[Range(0f, 1f)]
		public float push;

		[Range(-1f, 1f)]
		public float pushParent;

		[Range(0f, 1f)]
		public float reach;

		public Smoothing reachSmoothing;

		public Smoothing pushSmoothing;

		public IKSolver.Node[] nodes;

		public int[] children;

		public ChildConstraint[] childConstraints;

		public IKConstraintBend bendConstraint;

		private float rootLength;

		private bool initiated;

		private float length;

		private float distance;

		private IKSolver.Point p;

		private float reachForce;

		private float pullParentSum;

		private float[] crossFades;

		private float sqrMag1;

		private float sqrMag2;

		private float sqrMagDif;

		private const float maxLimbLength = 0.99999f;

		public FBIKChain()
			: base()
		{
		}

		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
			: this()
		{
		}

		public void SetNodes(params Transform[] boneTransforms)
		{
			boneTransforms = default(Transform[]);
		}

		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		public bool IsValid(string message)
		{
			return default(bool);
		}

		public void Initiate(IKSolverFullBody solver)
		{
		}

		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		public void Reach(IKSolverFullBody solver)
		{
		}

		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		public void Stage1(IKSolverFullBody solver)
		{
		}

		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		public void ForwardReach(Vector3 position)
		{
		}

		private void BackwardReach(Vector3 position)
		{
		}
	}
}
