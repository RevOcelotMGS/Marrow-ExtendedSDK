using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

public class KartRaceTaskClass : MonoBehaviour
{
	private ContestantPrefabSpawner contestantSpawner;

	private RaceCountdownDisplay countdownDisplay;

	[Tooltip("Spawnable")]
	[SerializeField]
	private Spawnable playerKart;

	[Tooltip("Spawnable")]
	[SerializeField]
	private Spawnable aiKart;

	public string vehicleComponentName;

	public GameObject[] spawnLocations;

	public GameObject[] checkpointArray;

	public RaceTaskContestant[] contestants;

	public int nb_contestants;

	public Contestant[] finalPlacements;

	public int nb_completed;

	public GameObject countdownButton;

	[Header("Inference Section")]
	public BarracudaModelManagerMono bmm;

	public ModelManagerConfig bmmConfig;

	public int nbNetworkSlices;

	public int actionMaskSize;

	public int trainedDelay;

	public int displayedContestants;

	[Tooltip("Best times for each checkpoint")]
	[Header("Race Specific Section")]
	public float[] checkpointTimes;

	[Tooltip("The farthest contestant on the track")]
	public RaceTaskContestant leader;

	public float defaultSeatedMass;

	private bool firstTime;

	private RaceUtils raceUtils;

	private int firstRaysPerSlice;

	private int firstNbSlices;

	private int shutdownCount;

	private void ShutdownAcademy()
	{
	}

	protected void Awake()
	{
	}

	private void BMMSetup()
	{
	}

	public IEnumerator AcademyShutdownDelay()
	{
		return null;
	}

	protected void Start()
	{
	}

	public void ConnectAgentToBmm(GameObject agent, int agentId)
	{
	}

	private void StartBMM()
	{
	}

	public void MoveContestant(RaceTaskContestant contestant, GameObject contestantGo, GameObject spawn)
	{
	}

	[ContextMenu("More Contestants")]
	public void MoreContestants()
	{
	}

	[ContextMenu("Less Contestants")]
	public void LessContestants()
	{
	}

	[ContextMenu("Reset Contestants")]
	public void ResetContestants()
	{
	}

	private void SpawnAllContestants()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SpawnContestant(Spawnable spawnable, int ind)
	{
	}

	private void SetLockJoint(ConfigurableJoint lockJoint)
	{
	}

	private void UnsetLockJoint(ConfigurableJoint lockJoint)
	{
	}

	public void UnfreezeContestants()
	{
	}

	[ContextMenu("Assign Checkpoints")]
	private void AssignCheckpoints()
	{
	}

	private void LinkCheckpoints()
	{
	}

	protected virtual void PlaceAndRegisterContestants()
	{
	}

	private void PopulateTask()
	{
	}

	private void UpdateContestantSpeeds(float desiredSpeed)
	{
	}

	public float SplitTime(int checkpointCounter, float cp_time)
	{
		return default(float);
	}

	[ContextMenu("Increase Slices")]
	public void IncreaseSlices()
	{
	}

	[ContextMenu("Decrease Slices")]
	public void DecreaseSlices()
	{
	}

	[ContextMenu("Increase Sim Steps")]
	public void IncreaseSimSteps()
	{
	}

	[ContextMenu("Decrease Sim Steps")]
	public void DecreaseSimSteps()
	{
	}

	[ContextMenu("Increase Rays Per Slice")]
	public void IncreaseRaysPerSlice()
	{
	}

	[ContextMenu("Decrease Rays Per Slice")]
	public void DecreaseRaysPerSlice()
	{
	}

	public KartRaceTaskClass()
		: base()
	{
	}

	public event Action RaceStart;

	public event Action IncrementContestants;

	public event Action DecrementContestants;
}
