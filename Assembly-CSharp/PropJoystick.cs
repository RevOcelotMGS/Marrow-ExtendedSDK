using SLZ.Interaction;
using UnityEngine;

public class PropJoystick : SphereGrip
{
	public struct JoystickData
	{
		public Vector2 xyLocalNormaled;

		public Quaternion baseRotationWorld;
	}

	public Transform locator;

	public Rigidbody rb_Joystick;

	[HideInInspector]
	public Vector2 rot_xy;

	public Transform rotBall;

	public float maxDegrees;

	public float deadzoneDegrees;

	public GameObject[] msg_Objects;

	private Quaternion rot_Start;

	private JoystickData _joystickData;

	protected void Update()
	{
	}

	public PropJoystick()
		: base()
	{
	}
}
