using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		public class Multiplier
		{
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			public Multiplier()
				: base()
			{
			}
		}

		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		private Quaternion defaultLocalRotation;

		private Transform lastPivot;

		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
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

		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		public void ResetRotation()
		{
		}

		public void RotateTo(Vector3 position)
		{
		}

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		public InteractionTarget()
			: base()
		{
		}
	}
}
