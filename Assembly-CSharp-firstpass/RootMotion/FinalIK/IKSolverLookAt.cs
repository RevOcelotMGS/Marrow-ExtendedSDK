using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		public class LookAtBone : Bone
		{
			public Vector3 forward
			{
				get
				{
					return default(Vector3);
				}
			}

			public LookAtBone()
				: base()
			{
			}

			public LookAtBone(Transform transform)
				: this()
			{
			}

			public void Initiate(Transform root)
			{
			}

			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		public Transform target;

		public LookAtBone[] spine;

		public LookAtBone head;

		public LookAtBone[] eyes;

		[Range(0f, 1f)]
		public float bodyWeight;

		[Range(0f, 1f)]
		public float headWeight;

		[Range(0f, 1f)]
		public float eyesWeight;

		[Range(0f, 1f)]
		public float clampWeight;

		[Range(0f, 1f)]
		public float clampWeightHead;

		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Range(0f, 2f)]
		public int clampSmoothing;

		public AnimationCurve spineWeightCurve;

		public Vector3 spineTargetOffset;

		private Vector3[] spineForwards;

		private Vector3[] headForwards;

		private Vector3[] eyeForward;

		private bool spineIsValid
		{
			get
			{
				return default(bool);
			}
		}

		private bool spineIsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		private bool headIsValid
		{
			get
			{
				return default(bool);
			}
		}

		private bool headIsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		private bool eyesIsValid
		{
			get
			{
				return default(bool);
			}
		}

		private bool eyesIsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public void SetLookAtWeight(float weight)
		{
		}

		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
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

		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void SolveSpine()
		{
		}

		private void SolveHead()
		{
		}

		private void SolveEyes()
		{
		}

		private Vector3[] GetForwards(Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		private void SetBones(Transform[] array, LookAtBone[] bones)
		{
		}

		public IKSolverLookAt()
			: base()
		{
		}
	}
}
