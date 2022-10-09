using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using UnityEngine;

public class FollowTaskMover : MonoBehaviour
{
	public TrackGenerator trackGen;

	public FollowObjective followObjective;

	public float desiredSpeed;

	public float minTaskSpeed;

	public float maxTaskSpeed;

	private float stepDistance;

	private float stepPercent;

	public float delayedStart;

	private float start_timer;

	public float percent;

	private float total_track_length;

	public bool needsCountdown;

	public bool rndmStartDistance;

	public bool rndmInnerSpeed;

	public bool rndmSideMovement;

	public float speedUpdateProb;

	public float speedUpdateMod;

	public float sideUpdateProb;

	public float sideUpdateMod;

	public float difficulty;

	private float next_distance;

	private float next_width;

	private float current_width;

	private float next_speed;

	private Vector3 tempEuler;

	private Vector3 next_position;

	private Quaternion next_rotation;

	private Vector3 next_rot;

	private Vector3 lastPos;

	[HideInInspector]
	public EnvironmentParameters envParams;

	private void SetEnvParams()
	{
	}

	private void Awake()
	{
	}

	private void SideMovement()
	{
	}

	private void SpeedModulation()
	{
	}

	public IEnumerator MoveTaskOnPath()
	{
		return null;
	}

	private void FixedUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	public FollowTaskMover()
		: base()
	{
	}
}
