using SLZ.AI;
using UnityEngine;

public class KillTrigger : MonoBehaviour
{
	private Collider m_Collider;

	public bool isKillingPlayer;

	public bool isKillingNPCs;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void KillNPC(TriggerRefProxy proxy)
	{
	}

	private void KillPlayer(TriggerRefProxy proxy)
	{
	}

	public KillTrigger()
		: base()
	{
	}
}
