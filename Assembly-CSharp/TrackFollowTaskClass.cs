using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TrackFollowTaskClass : TaskClass
{
	public FollowObjective followObjective;

	private GameObject objectiveObj;

	public GameObject objectivePrefab;

	public float[] currentParams;

	public InfiniteTrackClass infTrack;

	private VehicleSceneContextManager context;

	private float spawnDistance;

	private float maxSpeed;

	public float spawnBuffer;

	[Header("Timer Section")]
	[Tooltip("Master clock for how long this track task objective has been active")]
	public float currentTrackTime;

	[Tooltip("The max amount of time this task can be active for before resetting")]
	public float maxTrackTime;

	[Tooltip("To use the master timer or not")]
	public bool useTrackTimer;

	private bool firstTime;

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	protected override void FixedUpdate()
	{
	}

	public override void GenerateTask()
	{
	}

	private IEnumerator CheckVP()
	{
		return null;
	}

	private void PopulateTask()
	{
	}

	protected override void ClearContestants()
	{
	}

	private void ClearTask()
	{
	}

	private void ClearObjective()
	{
	}

	[ContextMenu("ResetTask")]
	public override void ResetTask()
	{
	}

	private void HandleTaskCompleted(bool successful)
	{
	}

	private void UpdateContestantSpeeds(float desiredSpeed)
	{
	}

	private void UpdateContestantGoalRadius(float goalRadius)
	{
	}

	private void UpdateContestantProxRadius(float proxRadius)
	{
	}

	private void HandleTrackTimer()
	{
	}

	private void InitObjective()
	{
	}

	protected override void PlaceObjective()
	{
	}

	public override Vector3 GetLineUpPosition(int i, float start_distance, float spacing, float offset_spacing, GameObject temp_contestant, TrackClass trackClass, float additionalY = 0f)
	{
		return default(Vector3);
	}

	protected override void PlaceAndRegisterContestants()
	{
	}

	public TrackFollowTaskClass()
		: base()
	{
	}
}
