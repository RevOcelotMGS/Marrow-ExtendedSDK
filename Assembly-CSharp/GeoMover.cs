using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Props;
using UnityEngine;
using UnityEngine.Events;

public class GeoMover : MonoBehaviour
{
	public GeoManager geoManager;

	public bool isDeathPit;

	public bool isFloor;

	public bool isDynamic;

	public bool isBoxForest;

	public float moveUpDuration;

	[SerializeField]
	private float moveDownDuration;

	public Vector3 startPos;

	[SerializeField]
	private Vector3 endPos;

	private Coroutine moveRoutine;

	[SerializeField]
	private Spawnable spawnable;

	[SerializeField]
	private GameObject[] spawnPointObjs;

	[SerializeField]
	private GameObject[] boxForestSpawnObjs;

	[SerializeField]
	private int randBoxCount;

	[SerializeField]
	private int maxStackCount;

	private int edgeMaxStackCount;

	private int edgeThresh;

	[SerializeField]
	private List<ObjectDestructable> destList;

	[SerializeField]
	private List<AssetPoolee> pooleeList;

	private HashSet<int> boxHash;

	[SerializeField]
	private LayerMask boxLayerMask;

	[SerializeField]
	private List<SpawnableGroup> spawnableGroups;

	public UnityEvent onMoveUpComplete;

	public UnityEvent onStartMoveDown;

	[Header("TimerJointVals")]
	private float spring;

	private float damper;

	private float maxForce;

	private Vector3 targetAngVel;

	public ConfigurableJoint timberJoint;

	public void Awake()
	{
	}

	public void MoveGeo(bool moveUp)
	{
	}

	private IEnumerator CoMoveGeo(bool moveUp)
	{
		return null;
	}

	[ContextMenu("IncrementalMove")]
	public void IncrementGeo()
	{
	}

	private IEnumerator CoIncrementalMove()
	{
		return null;
	}

	public void SpawnDestructables()
	{
	}

	public void ClearDestructables()
	{
	}

	private IEnumerator CoSpawnBoxForest(bool spawnRand = true)
	{
		return null;
	}

	[ContextMenu("GetBoxSpawns")]
	public void GetBoxSpawns()
	{
	}

	public void CreateTimberJoint(GameObject timber)
	{
	}

	public void CleanupJoint()
	{
	}

	public GeoMover()
		: base()
	{
	}
}
