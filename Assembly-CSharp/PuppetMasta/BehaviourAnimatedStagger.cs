using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PuppetMasta
{
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourAnimatedStagger")]
	public class BehaviourAnimatedStagger : BehaviourBase
	{
		[Serializable]
		public struct FallParams
		{
			public float startPinWeightMlp;

			public float startMuscleWeightMlp;

			public float losePinSpeed;
		}

		[Serializable]
		public struct FallParamsGroup
		{
			public Muscle.Group[] groups;

			public FallParams fallParams;
		}

		[Header("Master Properties")]
		public LayerMask groundLayers;

		public float animationBlendSpeed;

		public float animationMag;

		public float momentumMag;

		public float unbalancedMuscleWeightMlp;

		public float unbalancedMuscleDamperAdd;

		public bool dropProps;

		public float maxGetUpVelocity;

		public float minHipHeight;

		public SubBehaviourCOM centerOfMass;

		[Header("Muscle Group Properties")]
		public FallParams defaults;

		public FallParamsGroup[] groupOverrides;

		[Header("Events")]
		public PuppetEvent onUngrounded;

		public PuppetEvent onFallOver;

		public PuppetEvent onRest;

		[HideInInspector]
		public Vector3 moveVector;

		[HideInInspector]
		public bool isGrounded;

		[HideInInspector]
		public Vector3 forward;

		protected override void OnInitiate()
		{
		}

		protected override void OnActivate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		private IEnumerator LoseBalance()
		{
			return null;
		}

		private FallParams GetFallParams(Muscle.Group group)
		{
			return default(FallParams);
		}

		public BehaviourAnimatedStagger()
			: base()
		{
		}
	}
}
