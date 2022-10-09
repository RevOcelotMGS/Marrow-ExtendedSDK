using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class FingerRig : SolverManager
	{
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight;

		public Finger[] fingers;

		public bool initiated { get; private set; }

		public bool IsValid(string errorMessage)
		{
			return default(bool);
		}

		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = default(Transform))
		{
		}

		public void RemoveFinger(int index)
		{
		}

		private void AddChildrenRecursive(Transform parent, Transform[] array)
		{
		}

		protected override void InitiateSolver()
		{
		}

		public void UpdateFingerSolvers()
		{
		}

		public void FixFingerTransforms()
		{
		}

		public void StoreDefaultLocalState()
		{
		}

		protected override void UpdateSolver()
		{
		}

		protected override void FixTransforms()
		{
		}

		public FingerRig()
			: base()
		{
		}
	}
}
