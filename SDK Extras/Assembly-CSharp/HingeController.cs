using UnityEngine;

public class HingeController : MonoBehaviour
{
	public HingeJoint hingeJoint;

	private JointMotor tempMotor;

	public float angle;

	public float limit_min;

	public float limit_max;

	public float vel;

	private void Start()
	{
	}

	private void ChangeVel()
	{
	}

	private void FixedUpdate()
	{
	}

	public HingeController()
		: base()
	{
	}
}
