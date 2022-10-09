using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		public IterationDelegate OnPreIteration;

		private bool[] limitedBones;

		private Vector3[] solverLocalPositions;

		protected override bool boneLengthCanBeZero
		{
			get
			{
				return default(bool);
			}
		}

		public void SolveForward(Vector3 position)
		{
		}

		public void SolveBackward(Vector3 position)
		{
		}

		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnUpdate()
		{
		}

		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		private void OnPreSolve()
		{
		}

		private void OnPostSolve()
		{
		}

		private void Solve(Vector3 targetPosition)
		{
		}

		private void ForwardReach(Vector3 position)
		{
		}

		private void SolverMove(int index, Vector3 offset)
		{
		}

		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		private Quaternion GetLimitedRotation(int index, Quaternion q, [Out] bool changed)
		{
			return default(Quaternion);
		}

		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		private void BackwardReach(Vector3 position)
		{
		}

		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		private void BackwardReachLimited(Vector3 position)
		{
		}

		private void MapToSolverPositions()
		{
		}

		private void MapToSolverPositionsLimited()
		{
		}

		public IKSolverFABRIK()
			: base()
		{
		}
	}
}
