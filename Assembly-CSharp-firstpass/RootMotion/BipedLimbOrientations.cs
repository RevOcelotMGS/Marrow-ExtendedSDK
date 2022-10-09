using System;
using UnityEngine;

namespace RootMotion
{
	[Serializable]
	public class BipedLimbOrientations
	{
		[Serializable]
		public class LimbOrientation
		{
			public Vector3 upperBoneForwardAxis;

			public Vector3 lowerBoneForwardAxis;

			public Vector3 lastBoneLeftAxis;

			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
				: base()
			{
			}
		}

		public LimbOrientation leftArm;

		public LimbOrientation rightArm;

		public LimbOrientation leftLeg;

		public LimbOrientation rightLeg;

		public static BipedLimbOrientations UMA
		{
			get
			{
				return null;
			}
		}

		public static BipedLimbOrientations MaxBiped
		{
			get
			{
				return null;
			}
		}

		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
			: base()
		{
		}
	}
}
