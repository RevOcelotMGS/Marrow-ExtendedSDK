using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class MuscleEDIT
	{
		[Serializable]
		public enum Group
		{
			Hips = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Hand = 4,
			Leg = 5,
			Foot = 6,
			Tail = 7,
			Prop = 8
		}

		[Serializable]
		public class Props
		{
			[Tooltip("Which body part does this muscle belong to?")]
			public Group group;

			[Range(0f, 1f)]
			[Tooltip("The weight (multiplier) of mapping this muscle's target to the muscle.")]
			public float mappingWeight;

			[Tooltip("The weight (multiplier) of pinning this muscle to it's target's position using a simple AddForce command.")]
			[Range(0f, 1f)]
			public float pinWeight;

			[Tooltip("The muscle strength (multiplier).")]
			[Range(0f, 1f)]
			public float muscleWeight;

			[Range(0f, 1f)]
			[Tooltip("Multiplier of the positionDamper of the ConfigurableJoints' Slerp Drive.")]
			public float muscleDamper;

			[Tooltip("If true, will map the target to the world space position of the muscle. Normally this should be true for only the root muscle (the hips).")]
			public bool mapPosition;

			public Props()
				: base()
			{
			}

			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
				: this()
			{
			}

			public void Clamp()
			{
			}
		}

		public struct State
		{
			public float mappingWeightMlp;

			public float pinWeightMlp;

			public float muscleWeightMlp;

			public float maxForceMlp;

			public float muscleDamperMlp;

			public float muscleDamperAdd;

			public float immunity;

			public float impulseMlp;

			public Vector3 velocity;

			public Vector3 angularVelocity;

			public static State Default
			{
				get
				{
					return default(State);
				}
			}

			public void Clamp()
			{
			}
		}

		[HideInInspector]
		public string name;

		public ConfigurableJoint joint;

		public Transform target;

		public Props props;

		public State state;

		[HideInInspector]
		public int[] parentIndexes;

		[HideInInspector]
		public int[] childIndexes;

		[HideInInspector]
		public bool[] childFlags;

		[HideInInspector]
		public int[] kinshipDegrees;

		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[HideInInspector]
		public Vector3 positionOffset;

		private JointDrive slerpDrive;

		private float lastJointDriveRotationWeight;

		private float lastRotationDamper;

		private Vector3 defaultPosition;

		private Vector3 defaultTargetLocalPosition;

		private Vector3 lastMappedPosition;

		private Quaternion defaultLocalRotation;

		private Quaternion localRotationConvert;

		private Quaternion toParentSpace;

		private Quaternion toJointSpaceInverse;

		private Quaternion toJointSpace;

		private Quaternion toJointSpaceDefault;

		private Quaternion targetAnimatedRotation;

		private Quaternion targetAnimatedWorldRotation;

		private Quaternion defaultRotation;

		private Quaternion rotationRelativeToTarget;

		private Quaternion defaultTargetLocalRotation;

		private Quaternion lastMappedRotation;

		private Transform targetParent;

		private Transform connectedBodyTransform;

		private ConfigurableJointMotion angularXMotionDefault;

		private ConfigurableJointMotion angularYMotionDefault;

		private ConfigurableJointMotion angularZMotionDefault;

		private bool directTargetParent;

		private bool initiated;

		private Collider[] _colliders;

		private float lastReadTime;

		private float lastWriteTime;

		private bool[] disabledColliders;

		public Transform transform { get; private set; }

		public Rigidbody rigidbody { get; private set; }

		public Transform connectedBodyTarget { get; private set; }

		public Vector3 targetAnimatedPosition { get; private set; }

		public Collider[] colliders
		{
			get
			{
				return null;
			}
		}

		public Vector3 targetVelocity { get; private set; }

		public Vector3 targetAngularVelocity { get; private set; }

		public Vector3 mappedVelocity { get; private set; }

		public Vector3 mappedAngularVelocity { get; private set; }

		public Quaternion targetRotationRelative { get; private set; }

		private Quaternion localRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		private Quaternion parentRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		private Quaternion targetParentRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		private Quaternion targetLocalRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		public bool IsValid(bool log)
		{
			return default(bool);
		}

		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		public void UpdateColliders()
		{
		}

		public void DisableColliders()
		{
		}

		public void EnableColliders()
		{
		}

		private void AddColliders(Transform t, Collider[] C, bool includeMeshColliders)
		{
		}

		private void AddCompoundColliders(Transform t, Collider[] colliders)
		{
		}

		public void IgnoreCollisions(Muscle m, bool ignore)
		{
		}

		public void IgnoreAngularLimits(bool ignore)
		{
		}

		public void FixTargetTransforms()
		{
		}

		public void Reset()
		{
		}

		public void MoveToTarget()
		{
		}

		public void Read()
		{
		}

		public void ClearVelocities()
		{
		}

		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged)
		{
		}

		public void Map(float mappingWeightMaster)
		{
		}

		public void CalculateMappedVelocity()
		{
		}

		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff)
		{
		}

		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		public MuscleEDIT()
			: base()
		{
		}
	}
}
