using System.Collections.Generic;
using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using Unity.Mathematics;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[RequireComponent(typeof(Rigidbody))]
	public class SplineJoint : MonoBehaviour
	{
		private static ComponentCache<SplineJoint> _cache;

		private static float3 _right;

		private static float3 _up;

		private static float3 _forward;

		[Header("Configuration")]
		[SerializeField]
		private ContactCount _contactCount;

		[SerializeField]
		private Vector3 _axis;

		[SerializeField]
		private Vector3 _secondaryAxis;

		[SerializeField]
		private Vector2 _size;

		[SerializeField]
		private Vector3 _anchor;

		[Space(15f)]
		[SerializeField]
		private float _linearXDriveSpeed;

		[SerializeField]
		private DampenContactDrive _linearXDrive;

		[Space(15f)]
		[SerializeField]
		[Tooltip("Sets rotational twist motion on the configured axis")]
		private ConfigurableJointMotion _angularXMotion;

		[SerializeField]
		[Range(-177f, 177f)]
		private float _angularXMinLimit;

		[SerializeField]
		[Range(-177f, 177f)]
		private float _angularXMaxLimit;

		[SerializeField]
		private float _angularXDriveSpeed;

		[SerializeField]
		private SpringContactDrive _angularXDrive;

		[Space(15f)]
		[SerializeField]
		private SplineJointMotion _linearYZMotion;

		[SerializeField]
		private SoftSplineJointLimit _linearYZLimit;

		[SerializeField]
		private SpringContactDrive _linearYZDrive;

		[Space(15f)]
		[SerializeField]
		[Tooltip("Sets rotational swing motion on the configured axis")]
		private ConfigurableJointMotion _angularYZMotion;

		[SerializeField]
		[Range(0f, 177f)]
		private float _angularYZLimit;

		[SerializeField]
		private SpringContactDrive _angularYZDrive;

		[Header("References")]
		[SerializeField]
		private Rigidbody _rigidbody;

		[SerializeField]
		private PolyLine polyLine;

		private List<Contact> _contacts;

		private int _curSplineIndex;

		public static ComponentCache<SplineJoint> Cache
		{
			get
			{
				return null;
			}
		}

		private Quaternion AnchorRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		private Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
		}

		private Vector3 FrontContact
		{
			get
			{
				return default(Vector3);
			}
		}

		private Vector3 RightContact
		{
			get
			{
				return default(Vector3);
			}
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetAngularXDriveSpeed(float speed)
		{
		}

		public void SetAngularXDrivePositionSpring(float springForce)
		{
		}

		public void SetAngularXDrivePositionDamper(float damperForce)
		{
		}

		public void SetAngularXDriveMaxForce(float maxForce)
		{
		}

		public void SetYZDrivePositionSpring(float springForce)
		{
		}

		public void SetYZDrivePositionDamper(float damperForce)
		{
		}

		public void SetYZDriveMaxForce(float maxForce)
		{
		}

		public void SetLinearXDriveSpeed(float speed)
		{
		}

		public void SetLinearXDrivePositionDamper(float damperForce)
		{
		}

		public void SetLinearXDriveMaxForce(float maxForce)
		{
		}

		private static quaternion SynthesizeRotation(float3 right, float3 up)
		{
			return default(quaternion);
		}

		private void Update()
		{
		}

		private void Solve()
		{
		}

		private void AttachToBackPoint(float3 position, quaternion rotation)
		{
		}

		private bool IsBodyInverted(quaternion anchorRotation, quaternion rotation)
		{
			return default(bool);
		}

		private void CalculateTwoPointContact(float3 worldPos, [Out] float3 frontPosition, [Out] float3 backPosition, [Out] quaternion lookRotation, [Out] quaternion frontRotation, [Out] quaternion backRotation, [Out] int frontIndex, [Out] bool isFrontCapped, [Out] bool isBackCapped)
		{
		}

		private void Attach()
		{
		}

		private void RefreshContactConfig()
		{
		}

		public SimpleTransform GetContactOriginInWorld()
		{
			return default(SimpleTransform);
		}

		public void PlaceOnSpline()
		{
		}

		public void SetPolyLine(PolyLine polyline)
		{
		}

		public SplineJoint()
			: base()
		{
		}
	}
}
