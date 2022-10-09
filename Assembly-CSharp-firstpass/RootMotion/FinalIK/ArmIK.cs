using UnityEngine;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		public IKSolverArm solver;

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

		public ArmIK()
			: base()
		{
		}
	}
}
