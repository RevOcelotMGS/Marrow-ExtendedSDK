using System;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class BipedIKSolvers
	{
		public IKSolverLimb leftFoot;

		public IKSolverLimb rightFoot;

		public IKSolverLimb leftHand;

		public IKSolverLimb rightHand;

		public IKSolverFABRIK spine;

		public IKSolverLookAt lookAt;

		public IKSolverAim aim;

		public Constraints pelvis;

		private IKSolverLimb[] _limbs;

		private IKSolver[] _ikSolvers;

		public IKSolverLimb[] limbs
		{
			get
			{
				return null;
			}
		}

		public IKSolver[] ikSolvers
		{
			get
			{
				return null;
			}
		}

		public void AssignReferences(BipedReferences references)
		{
		}

		public BipedIKSolvers()
			: base()
		{
		}
	}
}
