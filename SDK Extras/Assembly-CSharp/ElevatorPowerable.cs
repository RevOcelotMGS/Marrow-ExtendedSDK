using UnityEngine;

public class ElevatorPowerable : Powerable
{
	[Header("Elevator REFS")]
	[Space(5f)]
	public bool isBinary;

	[Header("VOLTAGE OFFSET")]
	[Range(0f, 0.2f)]
	[Space(5f)]
	public float lowerOffSet;

	[Range(0f, 0.8f)]
	public float higherOffset;

	[Range(-1f, 1f)]
	[Space(5f)]
	public float min_InputVoltage;

	[Range(-1f, 1f)]
	public float max_InputVoltage;

	[Space(5f)]
	public float min_TargetVoltage;

	public float max_TargetVoltage;

	[Header("JOINTS")]
	[Space(5f)]
	public ConfigurableJoint m_configJoint;

	public Rigidbody m_rb;

	[Space(3f)]
	public Rigidbody ConnectedRB;

	public float parentScale;

	private Vector3 Anchor;

	private Vector3 axis_slide;

	private float limit_Linear;

	private float bounce;

	private float contactDistance;

	public float springPower;

	public float damperPower;

	public float motor_forcePower;

	[Tooltip("Changing the force to not be able to hold up the platform when there's no power")]
	public float NoPowerForce;

	[Tooltip("Modifier for the garage door's movement in Time.deltaTime")]
	public float speedMod;

	[Space(5f)]
	public float tarPos_down;

	public float tarPos_up;

	private Vector3 desiredPosition;

	private float stored_Draw;

	[Header("DEBUG")]
	public bool isDebugging;


	private float SetMoveRate(float Voltage)
	{
		return default(float);
	}


	public ElevatorPowerable()
		: base()
	{
	}
}
