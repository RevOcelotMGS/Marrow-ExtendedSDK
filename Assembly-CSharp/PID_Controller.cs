using UnityEngine;

public class PID_Controller : MonoBehaviour
{
	public Rigidbody rb;

	public ConfigurableJoint joint;

	public Transform followTran;

	public float pGain;

	public float iGain;

	public float dGain;

	private Vector3 _lastError;

	private Vector3 _errorSum;

	private void FixedUpdate()
	{
	}

	public PID_Controller()
		: base()
	{
	}
}
