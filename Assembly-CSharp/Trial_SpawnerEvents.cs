using System;
using SLZ.Zones;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Trial_SpawnerEvents : MonoBehaviour
{
	[SerializeField]
	private ZoneSpawner[] zSpawners;

	public int deadCount;

	public int totalCount;

	public float requiredPerc;

	[Tooltip("Use the spawner count to set req kill count rather than required perc for each gate")]
	public bool useSpawnerTotal;

	[SerializeField]
	private AudioClip killAllClip;

	public bool sendTotalEvents;

	public bool sentKillEvent;

	public UnityEvent OnKilledAll;

	public static Action<int> OnTotalKillCalc;

	public TMP_Text deadText;

	public TMP_Text totalText;

	private void Start()
	{
	}

	public void OnSpawnerDeath()
	{
	}

	public void OnDrawGizmosSelected()
	{
	}

	public Trial_SpawnerEvents()
		: base()
	{
	}
}
