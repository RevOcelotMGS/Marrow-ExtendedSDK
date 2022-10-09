using UnityEngine;

namespace RootMotion.FinalIK
{
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIKSlz : IK
	{
		public IKSolverLimbSlz solver;

		public override IKSolver GetIKSolver()
		{
			return null;
		}

		public LimbIKSlz()
			: base()
		{
		}
	}
}
