using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FollowTaskMover_Baked : MonoBehaviour
{
	public TrackClass trackClass;

	public float desiredSpeed;

	public float minSpeed;

	public float maxSpeed;

	private float stepDistance;

	private float stepPercent;

	public float delayedStart;

	public bool rndmStartDistance;

	private float start_timer;

	public float percent;

	private float total_track_length;

	private bool needsCountdown;

	public float sideUpdateProb;

	public float sideUpdateMod;

	public float difficulty;

	private float next_distance;

	private float next_width;

	private Vector3 next_position;

	private Vector3 next_rot;

	private Vector3 lastPos;

	public bool reverseSwitch;

	public float roadWidth;

	private int currentInd;

	private int WrapAroundInd(int ind, int len)
	{
		return default(int);
	}

	private void Awake()
	{
	}

	public IEnumerator MoveCarOnPath()
	{
		return null;
	}

	private void FixedUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	public FollowTaskMover_Baked()
		: base()
	{
	}
}
