using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class Muscle
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

			[Tooltip("The weight (multiplier) of mapping this muscle's target to the muscle.")]
			[Range(0f, 1f)]
			public float mappingWeight;

			[Tooltip("The muscle strength (multiplier).")]
			[Range(0f, 1f)]
			public float muscleWeight;

			[Tooltip("Multiplier of the positionDamper of the ConfigurableJoints' Slerp Drive.")]
			[Range(0f, 1f)]
			public float muscleDamper;

			[Tooltip("If true, will map the target to the world space position of the muscle. Normally this should be true for only the root muscle (the hips).")]
			public bool mapPosition;

			public int[] ignoredMuscleIndexs;

			public Props()
				: base()
			{
			}

			public Props(float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
				: this()
			{
			}
		}

		public struct State
		{
			public float mappingWeightMlp;

			public float muscleWeightMlp;

			public float muscleDamperMlp;

			public float maxForceMlp;

			public float muscleDamperAdd;

			public float immunity;

			public float impulseMlp;

			public static State Default
			{
				get
				{
					return default(State);
				}
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

		[HideInInspector]
		public Vector3 mappedVelocity;

		[HideInInspector]
		public Vector3 mappedAngularVelocity;

		private Transform rebuildParent;

		private Vector3 rebuildPosition;

		private Quaternion rebuildRotation;

		private Vector3 rebuildTargetPosition;

		private Quaternion rebuildTargetRotation;

		private ConfigurableJointMotion rebuildAngularXMotion;

		private ConfigurableJointMotion rebuildAngularYMotion;

		private ConfigurableJointMotion rebuildAngularZMotion;

		private ConfigurableJointMotion rebuildXMotion;

		private ConfigurableJointMotion rebuildYMotion;

		private ConfigurableJointMotion rebuildZMotion;

		private Vector3 _defaultConnectedAnchor;

		private Quaternion _lastTargetAnimRotation;

		private Quaternion _targetAnimRotation;

		private JointDrive slerpDrive;

		private float _lastSlerpSpring;

		private float _lastSlerpDamper;

		private float _lastSlerpMaxF;

		private Vector3 defaultPosition;

		private Vector3 defaultTargetLocalPosition;

		private Vector3 lastMappedPosition;

		private Quaternion defaultLocalRotation;

		private Quaternion toParentSpace;

		private Quaternion toJointSpace;

		private Quaternion toJointSpaceInverse;

		private Quaternion toJointSpaceDefault;

		private Quaternion targetAnimatedRotation;

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

		private float _maxForce;

		private Collider[] _colliders;

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

		public Quaternion targetRotationRelative { get; private set; }

		public Rigidbody rebuildConnectedBody { get; private set; }

		public Transform rebuildTargetParent { get; private set; }

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

		public void Rebuild()
		{
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

		public void FullDeath(float muscleWeight, float muscleDamper, float deadMuscleWeight)
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

		public void SetPdController(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		public void UpdateAnchor()
		{
		}

		public virtual void Update(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		public virtual void FixedUpdate(float t)
		{
		}

		public void Map(float mappingWeightMaster)
		{
		}

		public void CalculateMappedVelocity()
		{
		}

		private void MusclePdController()
		{
		}

		private void MusclePdDrive(float muscleWeightMaster, float muscleSpring, float muscleDamper)
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

		public Muscle()
			: base()
		{
		}
	}
}
