namespace RootMotion.FinalIK
{
	public abstract class IK : SolverManager
	{
		public abstract IKSolver GetIKSolver();

		protected override void UpdateSolver()
		{
		}

		protected override void InitiateSolver()
		{
		}

		protected override void FixTransforms()
		{
		}

		protected abstract void OpenUserManual();

		protected abstract void OpenScriptReference();

		public IK()
			: base()
		{
		}
	}
}
