using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class Recoil : OffsetModifier
	{
		[Serializable]
		public class RecoilOffset
		{
			[Serializable]
			public class EffectorLink
			{
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Tooltip("Weight of using this effector")]
				public float weight;

				public EffectorLink()
					: base()
				{
				}
			}

			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity;

			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			private Vector3 additiveOffset;

			private Vector3 lastOffset;

			public void Start()
			{
			}

			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			public RecoilOffset()
				: base()
			{
			}
		}

		[Serializable]
		public enum Handedness
		{
			Right = 0,
			Left = 1
		}

		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[HideInInspector]
		public Quaternion rotationOffset;

		private float magnitudeMlp;

		private float endTime;

		private Quaternion handRotation;

		private Quaternion secondaryHandRelativeRotation;

		private Quaternion randomRotation;

		private float length;

		private bool initiated;

		private float blendWeight;

		private float w;

		private Quaternion primaryHandRotation;

		private bool handRotationsSet;

		private Vector3 aimIKAxis;

		public bool isFinished
		{
			get
			{
				return default(bool);
			}
		}

		private IKEffector primaryHandEffector
		{
			get
			{
				return null;
			}
		}

		private IKEffector secondaryHandEffector
		{
			get
			{
				return null;
			}
		}

		private Transform primaryHand
		{
			get
			{
				return null;
			}
		}

		private Transform secondaryHand
		{
			get
			{
				return null;
			}
		}

		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		public void Fire(float magnitude)
		{
		}

		protected override void OnModifyOffset()
		{
		}

		private void AfterFBBIK()
		{
		}

		private void AfterAimIK()
		{
		}

		protected override void OnDestroy()
		{
		}

		public Recoil()
			: base()
		{
		}
	}
}
