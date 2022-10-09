using UnityEngine;

public class FollowTaskContestant : Contestant
{
	[HideInInspector]
	public BaseVehicle_SlicedTrainer trainingAgent;

	[Tooltip("Where amongst other contestants does this one place during/at the end of a race")]
	public int standing;

	[Tooltip("The race task that this contestant belongs to")]
	public TrackFollowTaskClass followTask;

	[Tooltip("Whether to set the reward to -1 for an agent when it fails the task and is respawned")]
	public bool penalizeOnReset;

	public float startLength;

	private void Awake()
	{
	}

	private void Start()
	{
	}


	private void FixedUpdate()
	{
	}


	public void UpdateProxRadius(float radius)
	{
	}

	public void UpdateGoalRadius(float radius)
	{
	}

	public FollowTaskContestant()
		: base()
	{
	}
}
