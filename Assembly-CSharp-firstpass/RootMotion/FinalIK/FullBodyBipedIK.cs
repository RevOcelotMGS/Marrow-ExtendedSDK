using UnityEngine;

namespace RootMotion.FinalIK
{
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		public BipedReferences references;

		public IKSolverFullBodyBiped solver;

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
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

		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		public override IKSolver GetIKSolver()
		{
			return null;
		}

		public bool ReferencesError(string errorMessage)
		{
			return default(bool);
		}

		public bool ReferencesWarning(string warningMessage)
		{
			return default(bool);
		}

		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		public FullBodyBipedIK()
			: base()
		{
		}
	}
}
