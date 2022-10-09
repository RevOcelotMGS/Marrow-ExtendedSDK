using SLZ.AI;
using SLZ.Zones;
using UnityEngine;

public class AutoAgroBoid : MonoBehaviour
{
	public MLZoneSpawner_Child boidSpawner;

	public bool findBall;

	[Range(0f, 1f)]
	public float attackProbability;

	public bool useCordForceChange;

	public GameObject[] betweenAgroWaypoints;

	public bool setBumperRate;

	public int bumperUpdateRate;

	private void Awake()
	{
	}

	private void SetAgro(Behaviour go, TriggerRefProxy playerTrp)
	{
	}

	public AutoAgroBoid()
		: base()
	{
	}
}
