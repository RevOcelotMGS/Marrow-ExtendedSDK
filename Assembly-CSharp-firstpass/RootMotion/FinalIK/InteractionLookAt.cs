using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class InteractionLookAt
	{
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[HideInInspector]
		public bool isPaused;

		private Transform lookAtTarget;

		private float stopLookTime;

		private float weight;

		private bool firstFBBIKSolve;

		public void Look(Transform target, float time)
		{
		}

		public void OnFixTransforms()
		{
		}

		public void Update()
		{
		}

		public void SolveSpine()
		{
		}

		public void SolveHead()
		{
		}

		public InteractionLookAt()
			: base()
		{
		}
	}
}
