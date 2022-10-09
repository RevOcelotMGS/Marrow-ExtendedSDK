using UnityEngine;

public class BoidBallMove : MonoBehaviour
{
	public float moveSpeed;

	private Vector3 targetDestination;

	private Vector3 m_startingPos;

	public float spawnRadius;

	private Vector3 randomPos;

	public float height_min;

	public float height_max;

	public Vector3 newTargetPos;

	private float destThresh;

	public bool active;

	public bool rndm_speed;

	public float min_speed;

	public float max_speed;

	public bool block_random_pos;

	public bool behaviour_mode;

	public GameObject phys_ref;

	public BallThrustPointManager thrustMngr;

	private void OnDrawGizmos()
	{
	}

	private void Start()
	{
	}

	public void MoveTargetToRandomPosition()
	{
	}

	private void FixedUpdate()
	{
	}

	public BoidBallMove()
		: base()
	{
	}
}
