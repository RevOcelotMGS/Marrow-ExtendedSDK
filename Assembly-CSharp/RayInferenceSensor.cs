using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class RayInferenceSensor : BaseInferenceSensor
{
	[Tooltip("Reference to the ML-Agents Ray Sensor Component")]
	public RayPerceptionSensorComponent3D raySensor;

	private int obs_counter;

	[Tooltip("To encode observations class as a single integer (more obs) or a float value (one ob)")]
	public bool useOneHot;

	[Tooltip("Print how many observations total are counted for rays")]
	public bool debugRayCount;

	[Tooltip("Spread the collection of ray data over multiple fixed updates")]
	public bool useSlices;

	[Tooltip("Total number of fixed update calls to use for ray collection")]
	public int nbSlices;

	[Tooltip("The final fraction of slices to use for collection")]
	public float delayFraction;

	private int delayCounter;

	[Tooltip("Total number of rays to fire per fixed update")]
	public int raysPerSlice;

	private int sliceInd;

	private BarracudaModelManagerMono bmm;

	public bool isActive;

	private int outputCounter;

	private RayPerceptionOutput eyes_output;

	private int nbRays;

	private int hot_index;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void RaySensorsUpdate()
	{
	}

	public IEnumerator SlicedSensorsUpdate()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public RayInferenceSensor()
		: base()
	{
	}
}
