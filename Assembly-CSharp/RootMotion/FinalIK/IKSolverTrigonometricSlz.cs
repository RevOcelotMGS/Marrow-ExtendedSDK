using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverTrigonometricSlz : IKSolver
	{
		[Serializable]
		public class TrigonometricBone : Bone
		{
			private Quaternion targetToLocalSpace;

			private Vector3 defaultLocalBendNormal;

			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			public TrigonometricBone()
				: base()
			{
			}
		}

		public Transform target;

		[Range(0f, 1f)]
		public float IKRotationWeight;

		public Quaternion IKRotation;

		public Vector3 bendNormal;

		public TrigonometricBone bone1;

		public TrigonometricBone bone2;

		public TrigonometricBone bone3;

		protected Vector3 weightIKPosition;

		protected bool directHierarchy;

		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		public void SetBendPlaneToCurrent()
		{
		}

		public void SetIKRotation(Quaternion rotation)
		{
		}

		public void SetIKRotationWeight(float weight)
		{
		}

		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		public float GetIKRotationWeight()
		{
			return default(float);
		}

		public override Point[] GetPoints()
		{
			return null;
		}

		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		public override bool IsValid(string message)
		{
			return default(bool);
		}

		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		private void InitiateBones()
		{
		}

		protected virtual void OnInitiateVirtual()
		{
		}

		protected virtual void OnUpdateVirtual()
		{
		}

		protected virtual void OnPostSolveVirtual()
		{
		}

		protected Vector3 GetBendDirection(Vector3 direction, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		public IKSolverTrigonometricSlz()
			: base()
		{
		}
	}
}
