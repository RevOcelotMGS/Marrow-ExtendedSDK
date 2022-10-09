using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKMapping
	{
		[Serializable]
		public class BoneMap
		{
			public Transform transform;

			public int chainIndex;

			public int nodeIndex;

			public Vector3 defaultLocalPosition;

			public Quaternion defaultLocalRotation;

			public Vector3 localSwingAxis;

			public Vector3 localTwistAxis;

			public Vector3 planePosition;

			public Vector3 ikPosition;

			public Quaternion defaultLocalTargetRotation;

			private Quaternion maintainRotation;

			public float length;

			public Quaternion animatedRotation;

			private Transform planeBone1;

			private Transform planeBone2;

			private Transform planeBone3;

			private int plane1ChainIndex;

			private int plane1NodeIndex;

			private int plane2ChainIndex;

			private int plane2NodeIndex;

			private int plane3ChainIndex;

			private int plane3NodeIndex;

			public Vector3 swingDirection
			{
				get
				{
					return default(Vector3);
				}
			}

			public bool isNodeBone
			{
				get
				{
					return default(bool);
				}
			}

			private Quaternion lastAnimatedTargetRotation
			{
				get
				{
					return default(Quaternion);
				}
			}

			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			public void StoreDefaultLocalState()
			{
			}

			public void FixTransform(bool position)
			{
			}

			public void SetLength(BoneMap nextBone)
			{
			}

			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			public void UpdatePlane(bool rotation, bool position)
			{
			}

			public void SetIKPosition()
			{
			}

			public void MaintainRotation()
			{
			}

			public void SetToIKPosition()
			{
			}

			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = default(IKSolver.Node))
			{
			}

			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			public void RotateToMaintain(float weight)
			{
			}

			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			public BoneMap()
				: base()
			{
			}
		}

		public virtual bool IsValid(IKSolver solver, string message)
		{
			return default(bool);
		}

		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		protected bool BoneIsValid(Transform bone, IKSolver solver, string message, Warning.Logger logger = default(Warning.Logger))
		{
			return default(bool);
		}

		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		public IKMapping()
			: base()
		{
		}
	}
}
