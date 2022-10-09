using UnityEngine;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		private Transform[] feet;

		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		public override void ResetPosition()
		{
		}

		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		private void Update()
		{
		}

		private void Initiate()
		{
		}

		private void OnSolverUpdate()
		{
		}

		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		private void OnPostSolverUpdate()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnDestroy()
		{
		}

		public GrounderVRIK()
			: base()
		{
		}
	}
}
