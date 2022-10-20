using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.Zones;
using UnityEngine;

public class SuperSeeker : MonoBehaviour
{
	private static ComponentCache<SuperSeeker> _cache;

	[SerializeField]
	private GameObject targetObj;

	public RigManager rigManager;

	private bool scaleChild;

	private float scaleFactor;

	[SerializeField]
	private GameObject childObj;

	public ZoneSpawner spawner;

	[SerializeField]
	private AIManager aiBrain;

	public static ComponentCache<SuperSeeker> Cache
	{
		get
		{
			return null;
		}
	}

	public void Awake()
	{
	}

	public void SubToSpawner()
	{
	}

	public void OnDisable()
	{
	}

	private void OnSpawn(GameObject npcObj, GameObject playerObj)
	{
	}

	private void OnSpawnerDeath()
	{
	}

	private void OnDespawn(GameObject npcObj)
	{
	}

	public void SetSeekerTarget(GameObject targ, GameObject playerObj = default(GameObject))
	{
	}

	public void SeekCompletion()
	{
	}

	public void FixedUpdate()
	{
	}

	public SuperSeeker()
		: base()
	{
	}
}
