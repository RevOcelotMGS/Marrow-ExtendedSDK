using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

public class ContestantPrefabSpawner : MonoBehaviour
{
	[SerializeField]
	[Tooltip("Spawnable")]
	private Spawnable playerKart;

	[Tooltip("Spawnable")]
	[SerializeField]
	private Spawnable aiKart;

	private int nbContestants;

	private int nbActiveContestants;

	public GameObject[] spawnLocations;

	public List<GameObject> contestants;

	public int NBContestants
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	[ContextMenu("Increase Contestants")]
	public void IncreaseContestants()
	{
	}

	[ContextMenu("Decrease Contestants")]
	public void DecreaseContestants()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void UpdateContestants()
	{
	}

	public void MovePrefab(GameObject prefab, GameObject spawn)
	{
	}

	public void SpawnPrefab(Spawnable spawnable, GameObject spawn)
	{
	}

	public ContestantPrefabSpawner()
		: base()
	{
	}
}
