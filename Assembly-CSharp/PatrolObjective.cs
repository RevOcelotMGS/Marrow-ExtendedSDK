using UnityEngine;

public class PatrolObjective : TaskObjective
{
	public SphereCollider triggerCollider;

	private float forward_align;

	private GameObject currentObj;

	private void MakeTriggerZone()
	{
	}

	private new void Awake()
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private new void HandleAttemptTimer()
	{
	}

	public PatrolObjective()
		: base()
	{
	}
}
