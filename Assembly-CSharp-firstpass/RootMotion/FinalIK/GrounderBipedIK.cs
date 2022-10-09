using UnityEngine;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderBipedIK : Grounder
	{
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		private Transform[] feet;

		private Quaternion[] footRotations;

		private Vector3 animatedPelvisLocalPosition;

		private Vector3 solvedPelvisLocalPosition;

		private Vector3 spineOffset;

		private float lastWeight;

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

		private void OnDisable()
		{
		}

		private void OnSolverUpdate()
		{
		}

		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		private void OnPostSolverUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public GrounderBipedIK()
			: base()
		{
		}
	}
}
