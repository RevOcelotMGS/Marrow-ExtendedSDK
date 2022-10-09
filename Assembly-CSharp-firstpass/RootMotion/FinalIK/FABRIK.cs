using UnityEngine;

namespace RootMotion.FinalIK
{
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		public IKSolverFABRIK solver;

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		public override IKSolver GetIKSolver()
		{
			return null;
		}

		public FABRIK()
			: base()
		{
		}
	}
}
