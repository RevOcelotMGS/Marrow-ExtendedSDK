using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Data;
using UnityEngine;

public class TruckChaseTaskClass : MonoBehaviour
{
	private ContestantPrefabSpawner contestantSpawner;

	private GameControl_TruckChase gameController;

	private RaceCountdownDisplay countdownDisplay;

	[SerializeField]
	[Tooltip("Spawnable")]
	private Spawnable playerKart;

	[Tooltip("Spawnable")]
	[SerializeField]
	private Spawnable aiKart;

	[Tooltip("Spawnable")]
	[SerializeField]
	private Spawnable aiTruck;

	public GameObject playerKartGo;

	public GameObject aiKartGo;

	public GameObject aiTruckGo;

	public string vehicleComponentName;

	public GameObject playerKartSpawn;

	public GameObject semiTruckSpawn;

	public GameObject[] spawnLocations;

	public GameObject[] checkpointArray;

	public Contestant[] contestants;

	public int nb_karts;

	public Contestant[] finalPlacements;

	public int nb_completed;

	[Header("Inference Section")]
	public BarracudaModelManagerMono followBmm;

	public BarracudaModelManagerMono raceBmm;

	public ModelManagerConfig followBmmConfig;

	public ModelManagerConfig raceBmmConfig;

	public int nbNetworkSlices;

	public int actionMaskSize;

	public int displayedContestants;

	[Header("Race Specific Section")]
	public InfiniteTrackClass track;

	[Tooltip("Best times for each checkpoint")]
	public float[] checkpointTimes;

	[Tooltip("The farthest contestant on the track")]
	public RaceTaskContestant leader;

	public float defaultSeatedMass;

	private bool firstTime;

	private RaceUtils raceUtils;

	private TrackUtils trackUtils;

	protected void Awake()
	{
	}

	protected void Start()
	{
	}

	public void ConnectAgentToBmm(GameObject agent, int agentId, BarracudaModelManagerMono bmm)
	{
	}

	private void StartBMM(BarracudaModelManagerMono bmm)
	{
	}

	[ContextMenu("Start Race BMM")]
	public void StartRaceBMM()
	{
	}

	[ContextMenu("Start Follow BMM")]
	private void StartFollowBMM()
	{
	}

	public void MoveContestant(GameObject contestant, GameObject spawn)
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
	public void ResetContestants(BarracudaModelManagerMono bmm)
	{
	}

	private void SpawnAllContestants()
	{
	}

	[ContextMenu("SpawnPlayerVehicle")]
	public void SpawnPlayerVehicle()
	{
	}

	[ContextMenu("Activate Semi Truck")]
	public void ActivateSemiTruck(bool val)
	{
	}

	[ContextMenu("Activate Player Kart")]
	public void ActivatePlayerKart(bool val)
	{
	}

	[ContextMenu("Spawn Semi-Truck")]
	public void SpawnSemiTruck()
	{
	}

	[ContextMenu("Spawn Contestant")]
	public void SpawnContestant(Spawnable spawnable, int ind, BarracudaModelManagerMono bmm = default(BarracudaModelManagerMono))
	{
	}

	public void UnfreezeContestants()
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

	[ContextMenu("Assign Checkpoints")]
	private void AssignCheckpoints()
	{
	}

	private void LinkCheckpoints()
	{
	}

	[ContextMenu("Move Checkpoints Down")]
	private void MoveCheckpoints()
	{
	}

	[ContextMenu("Delete Checkpoint Script")]
	private void DeleteCheckpoints()
	{
	}

	public TruckChaseTaskClass()
		: base()
	{
	}

	public event Action RaceStart;

	public event Action IncrementContestants;

	public event Action DecrementContestants;
}
