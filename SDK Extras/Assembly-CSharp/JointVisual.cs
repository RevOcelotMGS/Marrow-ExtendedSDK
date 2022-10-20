using UnityEngine;

public class JointVisual : MonoBehaviour
{
	[SerializeField]
	private ConfigurableJoint joint;

	[SerializeField]
	private GameObject connectedTransformObject;

	private void Awake()
	{
	}

	public void OnDrawGizmos()
	{
	}

	public void CreateKinematicConnectedObject()
	{
	}

	public JointVisual()
		: base()
	{
	}
}
