using Assets.Marrow_ExtendedSDK.StubClasses;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.MLAgentsExamples;
using UnityEngine;
using VehicleAI;

public class BaseVehicle_SlicedTrainer : Agent
{
	[Header("Base Vehicle Trainer Class")]
	[Header("Reward Section")]
	public bool log_cum_reward;

	[Header("Base Agent Components")]
	public BaseVehicle vehicle;

	public BaseVehicleController baseController;

	public BaseVehicleSensors baseSensors;

	public PhysVehicleAIInput physInput;

	[Header("Sliced Training Section")]
	public bool between_actions;

	public bool between_action_rewards;

	public int nb_updates;

	protected int current_updates;

	protected bool observation_ready;

	protected ActionBuffers delayed_buffers;

	[Header("Sensors")]
	public OrientationCubeController orientation_cube;

	public BaseInferenceSensor[] customSensors;

	public Vector3 accel;

	[Header("Game State")]
	protected bool initialized;

	public float dbgMotor;

	public float dbgSteer;

	public float dbgHB;

	private int temp;


	public virtual void InitComponents()
	{
	}

	public void PassFailTask(bool pass)
	{
	}

	private void Awake()
	{
	}

	public virtual void InitVehicle()
	{
	}

	private void Start()
	{
	}

	protected virtual void FixedUpdate()
	{
	}


	private void UpdateOrientationObjects()
	{
	}


	private void TakeDelayedAction(ActionBuffers actionBuffers)
	{
	}

	public virtual void MoveAgent(ActionSegment<int> act)
	{
	}

	public virtual void MoveAgent(ActionSegment<float> act)
	{
	}

	public BaseVehicle_SlicedTrainer()
		: base()
	{
	}
}
