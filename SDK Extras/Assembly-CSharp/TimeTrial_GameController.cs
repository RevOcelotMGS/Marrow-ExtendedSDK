using System.Collections.Generic;
using SLZ.Zones;
using UnityEngine;
using UnityEngine.Events;

public class TimeTrial_GameController : BaseGameController
{
	public enum TimeTrialMode
	{
		KILLS = 0,
		SPEED_RUN = 1
	}

	public enum TimeTrialStartMode
	{
		ON_START = 0,
		ON_TRIGGER = 1
	}

	public TimeTrialMode timeTrialMode;

	public TimeTrialStartMode timeTrialStartMode;

	public GenGameControl_Trigger timeTrialStartTrigger;

	public GenGameControl_Trigger timeTrialEndTrigger;

	[SerializeField]
	private AudioClip timeTrialBeginClip;

	[SerializeField]
	private AudioClip timeTrialEndClip;

	[SerializeField]
	private int initLightAmmo;

	[SerializeField]
	private int initMedAmmo;

	[SerializeField]
	private int initHeavyAmmo;

	[SerializeField]
	private ZoneSpawner[] zSpawners;

	public int[] diffReqKillCount;

	[SerializeField]
	private int reqKillCount;

	public int remainSeekCount;

	private bool spawnedSeekers;

	public UnityEvent OnKilledAll;

	public bool isSingleSpawn;

	public List<ZoneSpawner> easySpawnerList;

	public List<ZoneSpawner> mediumSpawnerList;

	public List<ZoneSpawner> hardSpawnerList;

	public SpawnerDifficulties[] spawnerDifficulties;

	private List<ZoneSpawner> activeSpawnersList;

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	public void OnRegisteredNPC_Death(NPC_Data data)
	{
	}

	public void UpdateDifficulty(int difficulty)
	{
	}

	private void CheckTimeTrialKills()
	{
	}

	public void TIMETRIAL_PlayerStartTrigger()
	{
	}

	public void TIMETRIAL_PlayerEndTrigger()
	{
	}

	private void CreateActiveSpawnSeekers()
	{
	}

	public void ProgPointKillCount(int tCount)
	{
	}

	public void SetRequiredKillCount(int killCount)
	{
	}

	public TimeTrial_GameController()
		: base()
	{
	}
}
