using PuppetMasta;
using SLZ.AI;
using UnityEngine;

public class BoidAgentKillVolume : MonoBehaviour
{
	private BehaviourBoid tempAgent;

	private TriggerRefProxy tempTrp;

	private void OnTriggerEnter(Collider other)
	{
	}

	public BoidAgentKillVolume()
		: base()
	{
	}
}
