using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class ClockBPM : MonoBehaviour
{
	[Header("SETTINGS")]
	public bool playOnStart;

	[Header("TIMING")]
	public float BPM;

	[Range(1f, 8f)]
	public int stepsPerMeasure;

	[Range(1f, 8f)]
	public int steps;

	[Header("DISPLAY")]
	public int cur_measure;

	public int tot_steps;

	public int cur_step;

	public int cur_2step;

	public int cur_4step;

	public int cur_8step;

	public int scoreMultiplier;

	[Header("EVENTS")]
	public UnityEvent OnNewMeasure;

	public UnityEvent OnDownBeat;

	public UnityEvent HalfNote;

	public UnityEvent QuarterNote;

	public UnityEvent EighthNote;

	public UnityEvent[] Event_BeatDivisions;

	public UnityEvent[] Event_Steps;

	private float defaultBPM;

	private float interval;

	private float nextTime;

	private int cur_division;

	private bool paused;

	private WaitForSecondsRealtime time_eighthhNote;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private IEnumerator CountClock()
	{
		return null;
	}

	public void CLOCK_PLAY()
	{
	}

	public void CLOCK_STOP()
	{
	}

	public void CLOCK_RESET(bool play = false)
	{
	}

	public ClockBPM()
		: base()
	{
	}
}
