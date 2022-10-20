using SLZ.Marrow.Utilities;
using UnityEngine;

public class RigidbodySettings : MonoBehaviour
{
	private static ComponentCache<RigidbodySettings> _cache;

	public bool disableITCalc;

	public bool scaleMass;

	public Transform comOverride;

	public float maxAv;

	public float iTensorMult;

	private Rigidbody rb;

	public bool ignoreHierarchy;

	public bool drawCom;

	public bool resetOnEnable;

	public Collider[] localColliders;

	public Collider[] collidersToIgnore;

	private float _nativeMass;

	private Vector3 _initialPos;

	private Quaternion _initialRot;

	public static ComponentCache<RigidbodySettings> Cache
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetCenter()
	{
	}

	public void IgnoreHierarchy()
	{
	}

	public void IgnoreColliders(bool ignore = true)
	{
	}

	public void SetVelocity(Vector3 velocity)
	{
	}

	public void SetVelocity(float minSpeed, float maxSpeed)
	{
	}

	public void SetAngularVelocity(Vector3 angularVelocity)
	{
	}

	public void SetAngularVelocity(float minAngularSpeed, float maxAngularSpeed)
	{
	}

	public RigidbodySettings()
		: base()
	{
	}
}
