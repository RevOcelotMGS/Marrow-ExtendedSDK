using UnityEngine;

public class BallThrustPointManager : MonoBehaviour
{
	public Thruster x;

	public Thruster negx;

	public Thruster y;

	public Thruster negy;

	public Thruster z;

	public Thruster negz;

	public Thruster[] thrusters;

	public bool goToDest;

	public GameObject destination;

	private Vector3 destinationError;

	private int layer_mask;

	public bool activated;

	public bool speedGovern;

	public float maxVelMag;

	private Vector3 maxVel;

	private Vector3 velError;

	public float destThresh;

	public void DeactivateThrusters()
	{
	}

	public void ActivateThrusters()
	{
	}

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public BallThrustPointManager()
		: base()
	{
	}
}
