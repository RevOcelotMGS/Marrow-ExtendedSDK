using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		public enum ColliderType
		{
			Box = 0,
			Capsule = 1
		}

		[Serializable]
		public enum JointType
		{
			Configurable = 0,
			Character = 1
		}

		[Serializable]
		public enum Direction
		{
			X = 0,
			Y = 1,
			Z = 2
		}

		public struct CreateJointParams
		{
			public struct Limits
			{
				public float minSwing;

				public float maxSwing;

				public float swing2;

				public float twist;

				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
					this.twist = default(float);
					this.swing2 = default(float);
					this.maxSwing = default(float);
					this.minSwing = default(float);
				}
			}

			public Rigidbody rigidbody;

			public Rigidbody connectedBody;

			public Transform child;

			public Vector3 worldSwingAxis;

			public Limits limits;

			public JointType type;

			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
				this.type = default(JointType);
				this.limits = default(Limits);
				this.worldSwingAxis = default(Vector3);
				this.child = default(Transform);
				this.connectedBody = default(Rigidbody);
				this.rigidbody = default(Rigidbody);
			}
		}

		public static void ClearAll(Transform root)
		{
		}

		protected static void ClearTransform(Transform transform)
		{
		}

		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		protected static void Vector3Abs(Vector3 v)
		{
		}

		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		protected static Rigidbody GetConnectedBody(Transform bone, Transform[] bones)
		{
			return null;
		}

		protected static void CreateJoint(CreateJointParams p)
		{
		}

		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		public RagdollCreator()
			: base()
		{
		}
	}
}
