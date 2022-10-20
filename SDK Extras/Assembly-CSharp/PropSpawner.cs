using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

public class PropSpawner : MonoBehaviour
{
	private static ComponentCache<PropSpawner> _cache;

	[HideInInspector]
	public Rigidbody propRb;

	public Rigidbody attachRb;

	public Collider[] ignoreColliders;

	public Vector3 localPosOffset;

	public Vector3 localRotOffset;

	public Vector3 anchorFix;

	public Spawnable headSpawnable;

	public Spawnable altHeadSpawnable;

	[SerializeField]
	private GameObject gO;

	public bool isAltObj;

	private ConfigurableJoint _faceJoint;

	private Collider[] _cols;

	private AssetPoolee _propPoolee;

	private AssetPoolee _poolee;

	[HideInInspector]
	public bool _hasBeenSpawnedOnce;

	public bool spawnOnEnable;

	public bool despawnDetachedProp;

	public static ComponentCache<PropSpawner> Cache
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void OnDespawn(GameObject go)
	{
	}

	public void OnSpawn(GameObject gameObject)
	{
	}

	public void OnPropDespawn(GameObject go)
	{
	}

	private void FixedUpdate()
	{
	}

	private void IgnoreCollisions(Collider[] cols, bool ignore = true)
	{
	}

	private void SpawnHatJoint()
	{
	}

	public PropSpawner()
		: base()
	{
	}
}
