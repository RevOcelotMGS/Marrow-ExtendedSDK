using UnityEngine;

namespace RootMotion.FinalIK
{
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		public BipedReferences references;

		public BipedIKSolvers solvers;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
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

		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		public void SetSpineWeight(float weight)
		{
		}

		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		public void InitiateBipedIK()
		{
		}

		public void UpdateBipedIK()
		{
		}

		public void SetToDefaults()
		{
		}

		protected override void FixTransforms()
		{
		}

		protected override void InitiateSolver()
		{
		}

		protected override void UpdateSolver()
		{
		}

		public void LogWarning(string message)
		{
		}

		public BipedIK()
			: base()
		{
		}
	}
}
