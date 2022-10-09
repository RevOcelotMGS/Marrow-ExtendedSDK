using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class Grounding
	{
		[Serializable]
		public enum Quality
		{
			Fastest = 0,
			Simple = 1,
			Best = 2
		}

		public class Leg
		{
			public Quaternion rotationOffset;

			public bool invertFootCenter;

			private Grounding grounding;

			private float lastTime;

			private float deltaTime;

			private Vector3 lastPosition;

			private Quaternion toHitNormal;

			private Quaternion r;

			private RaycastHit heelHit;

			private Vector3 up;

			public bool isGrounded { get; private set; }

			public Vector3 IKPosition { get; private set; }

			public bool initiated { get; private set; }

			public float heightFromGround { get; private set; }

			public Vector3 velocity { get; private set; }

			public Transform transform { get; private set; }

			public float IKOffset { get; private set; }

			public float stepHeightFromGround
			{
				get
				{
					return default(float);
				}
			}

			private float rootYOffset
			{
				get
				{
					return default(float);
				}
			}

			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			public void OnEnable()
			{
			}

			public void Reset()
			{
			}

			public void Process()
			{
			}

			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			private void RotateFoot()
			{
			}

			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			public Leg()
				: base()
			{
			}
		}

		public class Pelvis
		{
			private Grounding grounding;

			private Vector3 lastRootPosition;

			private float damperF;

			private bool initiated;

			private float lastTime;

			public Vector3 IKOffset { get; private set; }

			public float heightOffset { get; private set; }

			public void Initiate(Grounding grounding)
			{
			}

			public void Reset()
			{
			}

			public void OnEnable()
			{
			}

			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			public Pelvis()
				: base()
			{
			}
		}

		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle;

		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		private bool initiated;

		public Leg[] legs { get; private set; }

		public Pelvis pelvis { get; private set; }

		public bool isGrounded { get; private set; }

		public Transform root { get; private set; }

		public RaycastHit rootHit { get; private set; }

		public bool rootGrounded
		{
			get
			{
				return default(bool);
			}
		}

		public Vector3 up
		{
			get
			{
				return default(Vector3);
			}
		}

		private bool useRootRotation
		{
			get
			{
				return default(bool);
			}
		}

		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		public bool IsValid(string errorMessage)
		{
			return default(bool);
		}

		public void Initiate(Transform root, Transform[] feet)
		{
		}

		public void Update()
		{
		}

		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		public void Reset()
		{
		}

		public void LogWarning(string message)
		{
		}

		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		public Grounding()
			: base()
		{
		}
	}
}
