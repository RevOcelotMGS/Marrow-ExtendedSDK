using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Biped Ragdoll Creator")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		public struct Options
		{
			public float weight;

			[Header("Optional Bones")]
			public bool spine;

			public bool chest;

			public bool hands;

			public bool feet;

			[Header("Joints")]
			public JointType joints;

			public float jointRange;

			[Header("Colliders")]
			public float colliderLengthOverlap;

			public ColliderType torsoColliders;

			public ColliderType headCollider;

			public ColliderType armColliders;

			public ColliderType handColliders;

			public ColliderType legColliders;

			public ColliderType footColliders;

			public static Options Default
			{
				get
				{
					return default(Options);
				}
			}
		}

		public bool canBuild;

		public BipedRagdollReferences references;

		public Options options;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		public BipedRagdollCreator()
			: base()
		{
		}
	}
}
