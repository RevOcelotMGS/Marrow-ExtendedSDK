using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PathCreation;
using PathCreation.Examples;
using UnityEngine;

public class TrackGenerator : PathCreator
{
	[Tooltip("TrackGenerator gets reference values from the TrackClass/InfTrackClass")]
	[Header("Full Track Section")]
	public TrackClass trackClass;

	[SerializeField]
	public RoadMeshCreator_Custom rmc;

	[Tooltip("List of all road mesh chunks")]
	public List<RoadMeshCreator_Custom> rmcs;

	[Tooltip("List of all inner wall mesh chunks")]
	public List<RoadMeshCreator_Custom> innerWalls;

	[Tooltip("List of all outer wall mesh chunks")]
	public List<RoadMeshCreator_Custom> outerWalls;

	[Tooltip("Reference for predefined path")]
	public PathCreator pathCreator;

	[HideInInspector]
	[Header("Partition Section")]
	public bool usePartitions;

	[Tooltip("Length of bez path that designates a partition (as a fraction of total)")]
	public float partitionLengthPercent;

	[Tooltip("How many chunks to have active before and after current chunk")]
	public float windowSize;

	[Tooltip("What is used to keep track of what partitions to load")]
	public GameObject heroObject;

	[Tooltip("False for chunked tracks, true for a single track")]
	public bool continuousTrack;

	[Tooltip("For triggering regeneration event")]
	[Header("MISC Section")]
	public bool regen_bool;

	[Tooltip("Display debug objects (vertex path points)")]
	public bool debug_mode;

	[HideInInspector]
	public bool collision_free;

	private string assetPath;

	private float inner_scale;

	private float outer_scale;

	private float vertDistance;

	public static bool Regen { get; set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	public void DisplacePoints(Vector3[] points)
	{
	}

	private BezierPath MakeBezPath()
	{
		return null;
	}

	private void MakeVertexPath()
	{
	}

	private void DisplayMasterPath(VertexPath innerVp, VertexPath outerVp)
	{
	}

	private void MakeWalls(VertexPath innerVp, Vector3[] innerWallVerts, VertexPath outerVp, Vector3[] outerWallVerts)
	{
	}

	private void MakeWallPartitions(int i, GameObject road_partition_go, float nb_splits, int bp_counter, float pointsPerPartition, float finalLeftover, bool lastPart, VertexPath innerVp = default(VertexPath), Vector3[] innerWallVerts = default(Vector3[]), VertexPath outerVp = default(VertexPath), Vector3[] outerWallVerts = default(Vector3[]))
	{
	}

	private void MakeChunkTriggers(int i, GameObject road_partition_go, float nb_splits, int bp_counter)
	{
	}

	private void MakePartitions(VertexPath innerVp = default(VertexPath), Vector3[] innerWallVerts = default(Vector3[]), VertexPath outerVp = default(VertexPath), Vector3[] outerWallVerts = default(Vector3[]))
	{
	}

	[ContextMenu("Generate Path")]
	public void GeneratePath()
	{
	}

	private void MaterializeRMC(RoadMeshCreator_Custom rmc, GameObject temp_part_go, PathCreator pathCreator, VertexPath vp, Material top, Material bottom, float width, float thickness, float tileVal, VertexPath innerVp = default(VertexPath), VertexPath outerVp = default(VertexPath), PhysicMaterial roadPhysMat = default(PhysicMaterial))
	{
	}

	private Vector3[] PaddedPoint(VertexPath vp, float width, int inner_outer)
	{
		return null;
	}

	private Vector3[] GenerateWallVerts(Vector3[] roadPoints, float s)
	{
		return null;
	}

	public TrackGenerator()
		: base()
	{
	}

	public event Action TrackGenerated;
}
