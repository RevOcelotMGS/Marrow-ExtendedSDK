using UnityEngine;

namespace RootMotion
{
	public class SolverManager : MonoBehaviour
	{
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		private Animator animator;

		private Animation legacy;

		private bool updateFrame;

		private bool componentInitiated;

		private bool skipSolverUpdate;

		private bool animatePhysics
		{
			get
			{
				return default(bool);
			}
		}

		private bool isAnimated
		{
			get
			{
				return default(bool);
			}
		}

		public void Disable()
		{
		}

		protected virtual void InitiateSolver()
		{
		}

		protected virtual void UpdateSolver()
		{
		}

		protected virtual void FixTransforms()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void Initiate()
		{
		}

		private void Update()
		{
		}

		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		public void UpdateSolverExternal()
		{
		}

		public SolverManager()
			: base()
		{
		}
	}
}
