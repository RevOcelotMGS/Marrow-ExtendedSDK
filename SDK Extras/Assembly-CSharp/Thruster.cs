using UnityEngine;

public class Thruster : MonoBehaviour
{
	public float error;

	public float thrustValue;

	public bool thrustOverride;

	public float minHover;

	public float maxHover;

	public float hoverHeight;

	public Transform groundCastTrans;

	public float currentGroundDistance;

	public float maxSpeed;

	private Rigidbody rb;

	private float weight;

	public Vector2 thrustDir;

	public Rigidbody parentRb;

	public bool gravityBool;

	public Vector3 baseThrustVector;

	public bool blockingThrust;

	public bool blockPullForce;

	public float hoverMod;

	public float destMod;

	public int layer_mask;

	public int[] excludeLayerMask;

	public Vector3 finalHoverForce;

	public Vector3 finalDestinationForce;

	public float additionalMass;

	public string rayIgnoreTag;

	public int noCollideLayer;

	private void Start()
	{
	}

	public void UpdateWeight()
	{
	}

	private void FixedUpdate()
	{
	}

	private void CalcGroundDistance()
	{
	}

	private void HandleHoverForce()
	{
	}

	public void HandleDestinationForce(float destError)
	{
	}

	public void HandleVelocityError(float velError)
	{
	}

	public Thruster()
		: base()
	{
	}
}
