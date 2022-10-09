using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		public Transform target;

		public float tolerance;

		public int maxIterations;

		public bool useRotationLimits;

		public bool XY;

		public Bone[] bones;

		protected Vector3 lastLocalDirection;

		protected float chainLength;

		protected virtual int minBones
		{
			get
			{
				return default(int);
			}
		}

		protected virtual bool boneLengthCanBeZero
		{
			get
			{
				return default(bool);
			}
		}

		protected virtual bool allowCommonParent
		{
			get
			{
				return default(bool);
			}
		}

		protected virtual Vector3 localDirection
		{
			get
			{
				return default(Vector3);
			}
		}

		protected float positionOffset
		{
			get
			{
				return default(float);
			}
		}

		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		public void AddBone(Transform bone)
		{
		}

		public override void StoreDefaultLocalState()
		{
		}

		public override void FixTransforms()
		{
		}

		public override bool IsValid(string message)
		{
			return default(bool);
		}

		public override Point[] GetPoints()
		{
			return null;
		}

		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected void InitiateBones()
		{
		}

		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		private bool SingularityDetected()
		{
			return default(bool);
		}

		public IKSolverHeuristic()
			: base()
		{
		}
	}
}
