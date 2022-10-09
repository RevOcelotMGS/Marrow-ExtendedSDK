using System;
using System.Runtime.CompilerServices;
using SLZ.Data.SaveData;
using SLZ.Zones;
using UnityEngine;

public class DescentZoneProgression : MonoBehaviour
{
	[Serializable]
	private struct ResumePoint
	{
		public SaveIndication cameraSaveIndication;

		public bool ignoreCamera;

		[Tooltip("Additional Spawners to be disabled on progression")]
		[Header("Spawners deactive all previous spawners")]
		public ZoneSpawner[] spawners;

		[Header("Disable and enable objects are unique to point")]
		[Tooltip("Game Objects to be disabled on this progression point")]
		public GameObject[] disableObjects;

		[Tooltip("Game Objects to be enabled on this progression point")]
		public GameObject[] enableObjects;
	}

	[SerializeField]
	[Tooltip("0 = Start, 1 = Pit, 2 = DungeonStart, 3 = Lava Jump, 4 = ConveyerBelts, 5 = Pipe")]
	private ResumePoint[] _progressionPoints;

	public ActivateCheckpoints activateCheckpoints;

	private int _progress;

	private bool _resumingProgress;

	private static PlayerProgression Progression
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void ResumeProgress()
	{
	}

	public void UpdateProgress(int newProgression)
	{
	}

	public DescentZoneProgression()
		: base()
	{
	}
}
