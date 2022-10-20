using UnityEngine;
using UnityEngine.Events;

public class GenericOnJointBreak : MonoBehaviour
{
	public UnityEvent JointBreakEvent;

	private void OnJointBreak(float breakForce)
	{
	}

	public GenericOnJointBreak()
		: base()
	{
	}
}
