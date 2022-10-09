using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		public class SpineEffector
		{
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			public SpineEffector()
				: base()
			{
			}

			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
				: this()
			{
			}
		}

		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		public SpineEffector[] spine;

		private Transform[] feet;

		private Vector3 spineOffset;

		private bool firstSolve;

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

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void Initiate()
		{
		}

		private void OnSolverUpdate()
		{
		}

		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnDestroy()
		{
		}

		public GrounderFBBIK()
			: base()
		{
		}
	}
}
