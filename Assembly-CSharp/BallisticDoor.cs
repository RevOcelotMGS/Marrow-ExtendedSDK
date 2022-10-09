using UnityEngine;

public class BallisticDoor : MonoBehaviour
{
	private ConfigurableJoint jnt_DoorHinge;

	private Quaternion rot_TargetOpen;

	private Quaternion rot_TargetClosed;

	public bool locked;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public BallisticDoor()
		: base()
	{
	}
}
