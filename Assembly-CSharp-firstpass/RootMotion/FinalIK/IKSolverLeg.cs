using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverLeg : IKSolver
	{
		[Range(0f, 1f)]
		public float IKRotationWeight;

		public Quaternion IKRotation;

		public Point pelvis;

		public Point thigh;

		public Point calf;

		public Point foot;

		public Point toe;

		public IKSolverVR.Leg leg;

		public Vector3 heelOffset;

		private Vector3[] positions;

		private Quaternion[] rotations;

		public override bool IsValid(string message)
		{
			return default(bool);
		}

		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
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

		public override void StoreDefaultLocalState()
		{
		}

		public override void FixTransforms()
		{
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void Solve()
		{
		}

		private void Read()
		{
		}

		private void Write()
		{
		}

		public IKSolverLeg()
			: base()
		{
		}
	}
}
