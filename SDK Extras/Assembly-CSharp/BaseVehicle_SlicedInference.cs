using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.MLAgentsExamples;
using UnityEngine;
using VehicleAI;

public class BaseVehicle_SlicedInference : InferenceAgent
{
	[Header("Base Agent Components")]
	[Header("Base Vehicle Inference Class")]
	public BaseVehicle vehicle;

	public VehicleConfig vehicleConfig;

	public BaseVehicleController baseController;

	public BaseVehicleSensors baseSensors;

	[HideInInspector]
	public float time_alive;

	public bool collisionReset;

	public PhysVehicleAIInput physInput;

	[Header("Sensors")]
	public GameObject currentObjective;

	public OrientationCubeController orientation_cube;

	public InputVis vis;

	public GameObject eyes;

	[Header("Game State")]
	protected bool initialized;

	public bool full_reset_on_timeout;

	public float dbgMotor;

	public float dbgSteer;

	public float dbgHB;

	private float[] incomingActions;

	private Dictionary<string, float[]> lastActionDict;

	private int current_updates;

	private bool observation_ready;

	private float[] delayed_buffers;

	private int sensor_counter;

	private bool actionReady;

	public bool heuristic;

	public BaseVehicle_SlicedInference()
		: base()
	{
	}

	public event Action AgentInit;
}
