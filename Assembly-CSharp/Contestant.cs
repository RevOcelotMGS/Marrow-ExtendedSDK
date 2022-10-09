using Assets.Marrow_ExtendedSDK.StubClasses;
using System;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using UnityEngine;
using VehicleAI;

public class Contestant : MonoBehaviour
{
	public delegate void CheckpointCompletedDelegate(Contestant contestant, int cp_ind, float currentCpTime);

	public delegate void WrongCheckpointDelegate();

	public delegate void TimeoutDelegate(Contestant contestant, int cp_ind);

	[Header("Vehicle Section")]
	[Tooltip("Vehicle class reference")]
	public BaseVehicle baseVehicle;

	[Tooltip("Game Object reference")]
	public GameObject vehicle;

	[Header("Contestant Section")]
	[Tooltip("Used for lineup calculation")]
	public int contestantNumber;

	[Tooltip("Not used yet")]
	public int team_id;

	[Header("Checkpoint Section")]
	[Tooltip("Amount of time the contestant has been on current checkpoint")]
	public float currentCpTime;

	[Tooltip("Checkpoint this contestant is on")]
	public int cp_ind;

	public bool cp_lockout;

	[Tooltip("Total amount of time a contestant have before its reset (this value set to zero on success event)")]
	public float cpTimeOut;

	[Tooltip("Reset if checkpoint timer has finished")]
	public bool use_timeout;

	[Header("Statistics Section")]
	[Tooltip("For stats collection and early stopping")]
	public int concurrent_incorrect;

	[Tooltip("For stats collection")]
	public int nb_wrong_cps;

	[Tooltip("For stats collection")]
	public int nb_fails;

	public EnvironmentParameters envParams;

	public CheckpointCompletedDelegate checkpointCompletedDelegate;

	public WrongCheckpointDelegate wrongCheckpointDelegate;

	public TimeoutDelegate timeoutDelegate;

	public virtual void Respawn()
	{
	}

	public virtual void SoftReset()
	{
	}

	public void RegisterSuccess()
	{
	}

	protected virtual void TimeoutTicker()
	{
	}

	public virtual void HandleCheckpoint(CheckPoint temp_cp)
	{
	}

	public Contestant()
		: base()
	{
	}

	public event Action ContestantRegistered;

	public event Action TimeoutEvent;
}
