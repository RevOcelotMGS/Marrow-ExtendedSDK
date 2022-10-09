using System;
using UnityEngine;

namespace RootMotion
{
	[Serializable]
	public class BipedReferences
	{
		public struct AutoDetectParams
		{
			public bool legsParentInSpine;

			public bool includeEyes;

			public static AutoDetectParams Default
			{
				get
				{
					return default(AutoDetectParams);
				}
			}

			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
				this.includeEyes = default(bool);
				this.legsParentInSpine = default(bool);
			}
		}

		public Transform root;

		public Transform pelvis;

		public Transform leftThigh;

		public Transform leftCalf;

		public Transform leftFoot;

		public Transform rightThigh;

		public Transform rightCalf;

		public Transform rightFoot;

		public Transform leftUpperArm;

		public Transform leftForearm;

		public Transform leftHand;

		public Transform rightUpperArm;

		public Transform rightForearm;

		public Transform rightHand;

		public Transform head;

		public Transform[] spine;

		public Transform[] eyes;

		public virtual bool isFilled
		{
			get
			{
				return default(bool);
			}
		}

		public bool isEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		public static bool AutoDetectReferences(BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		public static void DetectReferencesByNaming(BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		public static void AssignHumanoidReferences(BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		public static bool SetupError(BipedReferences references, string errorMessage)
		{
			return default(bool);
		}

		public static bool SetupWarning(BipedReferences references, string warningMessage)
		{
			return default(bool);
		}

		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		private static bool AddBoneToEyes(Transform bone, BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		private static bool AddBoneToSpine(Transform bone, BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform firstBone, Transform secondBone, Transform lastBone, Transform[] transforms)
		{
		}

		private static void AddBoneToHierarchy(Transform[] bones, Transform transform)
		{
		}

		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, string errorMessage)
		{
			return default(bool);
		}

		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, string warningMessage)
		{
			return default(bool);
		}

		private static bool SpineError(BipedReferences references, string errorMessage)
		{
			return default(bool);
		}

		private static bool SpineWarning(BipedReferences references, string warningMessage)
		{
			return default(bool);
		}

		private static bool EyesError(BipedReferences references, string errorMessage)
		{
			return default(bool);
		}

		private static bool EyesWarning(BipedReferences references, string warningMessage)
		{
			return default(bool);
		}

		private static bool RootHeightWarning(BipedReferences references, string warningMessage)
		{
			return default(bool);
		}

		private static bool FacingAxisWarning(BipedReferences references, string warningMessage)
		{
			return default(bool);
		}

		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		public BipedReferences()
			: base()
		{
		}
	}
}
