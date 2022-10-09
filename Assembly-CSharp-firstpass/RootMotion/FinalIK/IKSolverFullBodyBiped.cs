using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		public Transform rootNode;

		[Range(0f, 1f)]
		public float spineStiffness;

		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		private Vector3 offset;

		public IKEffector bodyEffector
		{
			get
			{
				return null;
			}
		}

		public IKEffector leftShoulderEffector
		{
			get
			{
				return null;
			}
		}

		public IKEffector rightShoulderEffector
		{
			get
			{
				return null;
			}
		}

		public IKEffector leftThighEffector
		{
			get
			{
				return null;
			}
		}

		public IKEffector rightThighEffector
		{
			get
			{
				return null;
			}
		}

		public IKEffector leftHandEffector
		{
			get
			{
				return null;
			}
		}

		public IKEffector rightHandEffector
		{
			get
			{
				return null;
			}
		}

		public IKEffector leftFootEffector
		{
			get
			{
				return null;
			}
		}

		public IKEffector rightFootEffector
		{
			get
			{
				return null;
			}
		}

		public FBIKChain leftArmChain
		{
			get
			{
				return null;
			}
		}

		public FBIKChain rightArmChain
		{
			get
			{
				return null;
			}
		}

		public FBIKChain leftLegChain
		{
			get
			{
				return null;
			}
		}

		public FBIKChain rightLegChain
		{
			get
			{
				return null;
			}
		}

		public IKMappingLimb leftArmMapping
		{
			get
			{
				return null;
			}
		}

		public IKMappingLimb rightArmMapping
		{
			get
			{
				return null;
			}
		}

		public IKMappingLimb leftLegMapping
		{
			get
			{
				return null;
			}
		}

		public IKMappingLimb rightLegMapping
		{
			get
			{
				return null;
			}
		}

		public IKMappingBone headMapping
		{
			get
			{
				return null;
			}
		}

		public Vector3 pullBodyOffset { get; private set; }

		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		public override bool IsValid(string message)
		{
			return default(bool);
		}

		public void SetToReferences(BipedReferences references, Transform rootNode = default(Transform))
		{
		}

		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		protected override void ReadPose()
		{
		}

		private void PullBody()
		{
		}

		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		protected override void ApplyBendConstraints()
		{
		}

		protected override void WritePose()
		{
		}

		public IKSolverFullBodyBiped()
			: base()
		{
		}
	}
}
