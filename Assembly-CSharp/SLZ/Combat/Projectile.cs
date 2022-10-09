using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.AI;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace SLZ.Combat
{
	public class Projectile : MonoBehaviour
	{
		private static ComponentCache<Projectile> _cache;

		private Rigidbody rb;

		private bool isFinished;

		private int debugColorIdx;

		private Color[] debugColors;

		private int currentParticleSpawns;

		private float currentSpeed;

		private Vector3 _direction;

		public TrailRenderer trail;

		[Header("Projectile Attributes ")]
		[Tooltip("Bullet reference. Use stated values if empty")]
		private ProjectileData _data;

		[Tooltip("Velocity in Meters per Second")]
		[Space(5f)]
		[SerializeField]
		private float startSpeed;

		[SerializeField]
		[Tooltip("Mass in kg")]
		private float Mass;

		[SerializeField]
		private AttackType ammoAttribute;

		[SerializeField]
		private LayerMask collisionLayers;

		[SerializeField]
		private bool allowBulletDrop;

		[SerializeField]
		private bool applyRemainderForceToCollision;

		private TriggerRefProxy _proxy;

		public GameObject projectileMeshGameObject;

		[Tooltip("Max amount of impact particle systems allowed to spawn")]
		[Range(0f, 19f)]
		[SerializeField]
		[Space(5f)]
		[Header("Pool Options")]
		private int MaxParticleSpawns;

		[SerializeField]
		private UnityEvent onCreate;

		[SerializeField]
		private UnityEventCollision onCollision;

		[SerializeField]
		private UnityEvent onDestroy;

		[SerializeField]
		private bool showDebugLines;

		private bool _frameDelay;

		private bool _simulate;

		private int _lastFrameUdate;

		public static ComponentCache<Projectile> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void SetBulletObject(ProjectileData data, Transform startTransform, Vector3 locPos, Quaternion locRot, Rigidbody EmittingRigidbody = default(Rigidbody), TriggerRefProxy proxy = default(TriggerRefProxy))
		{
		}

		public void EstablishVariables(string name = default(string), Transform EmittingTransform = default(Transform), TriggerRefProxy proxy = default(TriggerRefProxy))
		{
		}

		private void Update()
		{
		}

		public void OnDestroy()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public Projectile()
			: base()
		{
		}
	}
}
