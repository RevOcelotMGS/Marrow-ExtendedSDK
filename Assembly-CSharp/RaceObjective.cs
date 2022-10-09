using UnityEngine;

public class RaceObjective : TaskObjective
{
	[Tooltip("A square trigger collider to use rather than sphere collider (like follow task)")]
	public BoxCollider triggerCollider;

	[Tooltip("Reference for contestants")]
	public int checkpointNumber;

	[Tooltip("Reference to the objective to be passed to contestant upon completition")]
	public RaceObjective nextObjective;

	private Vector3 new_size;

	private RaceTaskContestant tempContestant;

	private new void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public RaceObjective()
		: base()
	{
	}
}
