using SLZ;
using UnityEngine;

public class RunOffDoorControl : MonoBehaviour
{
	public float rightArmPositionWeight;

	public float lookAtWeight;

	public bool pressButton;

	public DisableDelay disableDelay;

	public GameObject brett;

	public Rigidbody gun;

	public float timeDelayFromButton;

	public Vector3 gunVelocity;

	public Vector3 gunAngVelocity;

	public GarageDoor_Phys_Powerable garageDoor;

	private bool _buttonPressedOneTime;

	private bool _gunPushedOneTime;

	private float _timer;

	private void Update()
	{
	}

	public RunOffDoorControl()
		: base()
	{
	}
}
