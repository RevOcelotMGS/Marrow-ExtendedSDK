using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		public class Limb
		{
			public FBIKChain.Smoothing reachSmoothing;

			public float maintainRelativePositionWeight;

			public float mappingWeight;

			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			public Limb()
				: base()
			{
			}
		}

		public FullBodyBipedIK ik;

		public bool disableAfterStart;

		public Limb leftArm;

		public Limb rightArm;

		public Limb leftLeg;

		public Limb rightLeg;

		public float rootPin;

		public bool bodyEffectChildNodes;

		public void UpdateSettings()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public FBBIKSettings()
			: base()
		{
		}
	}
}
