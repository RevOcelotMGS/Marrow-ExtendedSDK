using UnityEngine;

public class AwakeVelocity : MonoBehaviour
{
	public Rigidbody rb;

	public GameObject target;

	public float strength;

	public Vector3 initialRotation;

	public bool runOnce;

	private bool setVelocity;

	private void Awake()
	{
	}

	public AwakeVelocity()
		: base()
	{
	}
}
