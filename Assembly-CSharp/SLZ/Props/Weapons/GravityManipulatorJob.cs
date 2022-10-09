using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Rig;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace SLZ.Props.Weapons
{
	public class GravityManipulatorJob : MonoBehaviour
	{
		private struct CalculateCurveJob : IJobParallelFor
		{
			[ReadOnly]
			public int pinCount;

			[ReadOnly]
			public int segmentCount;

			[ReadOnly]
			public Vector3 direction;

			[ReadOnly]
			public Vector3 up;

			[ReadOnly]
			public Vector3 startPosition;

			[ReadOnly]
			public Vector3 startTangent;

			[ReadOnly]
			public Vector3 endTangent;

			[NativeDisableParallelForRestriction]
			[ReadOnly]
			public NativeArray<Vector3> pinPositionNativeArray;

			public NativeArray<Vector3> linePositionsNativeArray;

			public void Execute(int i)
			{
			}

			private Vector3 GetSplinePoint(float perc, Vector3 start, Vector3 newStartTangent, Vector3 endTangent, Vector3 end)
			{
				return default(Vector3);
			}
		}

		private struct CalculateForwardsJob : IJobParallelFor
		{
			[ReadOnly]
			public float time;

			[ReadOnly]
			public int segmentCount;

			public NativeArray<Vector3> linePositionsNativeArray;

			public void Execute(int i)
			{
			}
		}

		[Header("Options")]
		public float targetMinDistance;

		public bool isAutoCollect;

		public float maxMoveSpeed;

		public float minimumGrabRatio;

		public LayerMask pullableLayerMask;

		public float fieldOffset;

		public float keepFieldRadius;

		public float minKeepFieldForce;

		public float maxKeepFieldForce;

		[Range(0f, 1f)]
		public float keepFieldDampening;

		public float deadZoneRadius;

		public float deadZoneForce;

		[Range(0f, 1f)]
		public float deadZoneDampening;

		public bool startActive;

		public int maxGravityObjects;

		[Range(0f, 30f)]
		public float grabFieldAngle;

		public float grabFieldOffset;

		public float distanceOffset;

		public Quaternion rotationOffset;

		[Header("Render")]
		public int maxLines;

		public Gradient color;

		public Material lineMaterial;

		public Material pointMaterial;

		[Header("References")]
		public RigManager relativeBody;

		public Transform firePoint;

		public Transform artPoint;

		public Transform spaceTimeDistortion;

		private float _grabFieldCos;

		private bool m_IsActivated;

		private int m_LineSegmentCount;

		private int m_ColliderCount;

		private float _lockSpeed;

		public Rigidbody lockedParentRigidbody;

		public Action OnJobStart;

		private Collider[] m_Colliders;

		private List<Collider> _lockedColliders;

		private float grabFieldFarRadius;

		private float grabFieldNearRadius;

		private Rigidbody[] rigidbodyKeyBuffer;

		private Dictionary<Rigidbody, Collider> m_RigidbodyColliderDictionary;

		private HashSet<Rigidbody> m_RigidbodyHashSet;

		private int m_LineEndpointCount;

		private WaitForFixedUpdate waitAfterFixed;

		private List<ConfigurableJoint> _helperJoints;

		private List<Rigidbody> _helperRigidbodies;

		private List<Quaternion> _helperStartRotations;

		private LineRenderer[] lineRenderers;

		private ParticleSystem _particleSystem;

		private ParticleSystemRenderer particleRenderer;

		private ParticleSystem.Particle[] particles;

		private Vector4[] particleData;

		private NativeArray<Vector3> m_LinePositionsNativeArray;

		private NativeArray<Vector3> m_PinPositionsNativeArray;

		private Rigidbody[] m_RigidbodyToPinPositions;

		private CalculateCurveJob m_CalculateCurveJob;

		private CalculateForwardsJob m_CalculateForwardsJob;

		private JobHandle m_CalculateCurveJobHandle;

		private JobHandle m_CalculateForwardsJobHandle;

		private Coroutine autoCollectCoroutine;

		private Vector3 _currentLockedVelocity;

		private Rigidbody m_LockedRigidbody;

		private Quaternion _lockedJointStartRotation;

		private Quaternion _lockedRigidbodyStartRotation;

		private ConfigurableJoint _joint;

		private int _solverVelocityIterations;

		private int _solverIterations;

		private Coroutine cleanupRbMapCoroutine;

		private Vector3 m_TargetPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		public bool IsRigidbodyLocked { get; private set; }

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private IEnumerator CoAutoCollect()
		{
			return null;
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupJobs()
		{
		}

		private void CleanupJobs()
		{
		}

		private void ScheduleLockedJobs()
		{
		}

		private void ScheduleJobs()
		{
		}

		private void CompleteJobs()
		{
		}

		private void HoverRigidbodies()
		{
		}

		public Vector3 GetRigidbodyPositionWithBounds(Rigidbody rb)
		{
			return default(Vector3);
		}

		private void LockRigidbody()
		{
		}

		public void SetColliders(List<Collider> colliders)
		{
		}

		public void ClearColliders()
		{
		}

		private void CapsuleCollect()
		{
		}

		public Rigidbody GetClosestRigidbody()
		{
			return null;
		}

		private void NormalizeJointConfiguration()
		{
		}

		private void ConfigureJoint(Rigidbody rigidbody)
		{
		}

		public void LockRigidbody(Rigidbody rigidbody)
		{
		}

		public Rigidbody LockClosestRigidbody()
		{
			return null;
		}

		public void ReleaseLockedRigidbody()
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		private void ClearEffects()
		{
		}

		private IEnumerator CoCleanupRbMap()
		{
			return null;
		}

		private void OnDrawGizmosSelected()
		{
		}

		public GravityManipulatorJob()
			: base()
		{
		}
	}
}
