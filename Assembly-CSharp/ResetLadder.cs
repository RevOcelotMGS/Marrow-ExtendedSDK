using SLZ.Interaction;
using UnityEngine;

public class ResetLadder : MonoBehaviour
{
	public GameObject obj;

	public Rigidbody rb;

	public TimedJointEvents trigger;

	public InteractableHost host;

	private Vector3 objPos;

	private Quaternion objRot;

	private bool jointBroken;

	public ConfigurableJoint joint;

	public SoftJointLimit lowAngularXLimit;

	public SoftJointLimit highAngularXLimit;

	private ConfigurableJoint newJoint;

	private void OnEnable()
	{
	}

	public void LadderReset()
	{
	}

	public ResetLadder()
		: base()
	{
	}
}
