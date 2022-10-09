using UnityEngine;

public class BoidBumper : MonoBehaviour
{
	public BoidController boidController;

	[Tooltip("Rigidbody to apply forces onto")]
	public Rigidbody _rb;

	[Tooltip("Force Magnifier")]
	public float reflectForce;

	[Tooltip("Dampen the current velocity")]
	public float dampenFactor;

	[Tooltip("Size of spherecast")]
	public float maxRayDistance;

	[Tooltip("Layers that will trigger a bumper response")]
	public int[] detectableLayers;

	[Tooltip("Max number of detections per cast")]
	public int maxColliders;

	[Tooltip("How many fixed updates to wait till the next cast")]
	public int fixedUpdateDelay;

	public bool drawGizmos;

	private RaycastHit[] rayHits;

	private int numColliders;

	private int fixedCounter;

	private int layerMask;

	private Vector3 collisionPosition;

	private Vector3 reflectVel;

	private Color gizmoColor;

	private Vector3[] directions;

	private int directionCounter;

	private void OnDrawGizmos()
	{
	}

	private void Start()
	{
	}

	protected void CastRay(Vector3 direction)
	{
	}

	private void FixedUpdate()
	{
	}

	public BoidBumper()
		: base()
	{
	}
}
