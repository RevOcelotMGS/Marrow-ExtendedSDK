using UnityEngine;

public class Powerable_Vehicle : Powerable
{
	[Header("VOLTAGE")]
	public bool isBinary;

	[Range(-1f, 1f)]
	[Space(5f)]
	public float cur_InputVoltage;

	private float att_Voltage;

	[Space(5f)]
	[Range(-1f, 1f)]
	public float min_InputVoltage;

	[Range(-1f, 1f)]
	public float max_InputVoltage;

	[Space(5f)]
	public float min_TargetVoltage;

	public float max_TargetVoltage;

	[Space(5f)]
	[Header("MOTOR CONTROL")]
	[SerializeField]
	private float m_TargetVelocity;

	[SerializeField]
	private float m_MaxForce;

	[SerializeField]
	private float m_PositionDamper;

	public ConfigurableJoint jnt_to_rotate;

	private float stored_Draw;

	private float _totalVoltage;

	private bool _joystickRecieved;

	private Vector3 _joystickVel;

	private Vector3 _joystickForwardWorld;

	private void Start()
	{
	}

	public void JOYSTICK(PropJoystick.JoystickData joyData)
	{
	}

	public float GetAttenuatedVoltage(int id = 0)
	{
		return default(float);
	}

	public Vector3 GetJoystickWorld(int id = 0)
	{
		return default(Vector3);
	}

	public float GetTotalVoltage()
	{
		return default(float);
	}

	public int GetTotalPowerSources()
	{
		return default(int);
	}

	private void SETJOINT(float voltage = 1f)
	{
	}

	public Powerable_Vehicle()
		: base()
	{
	}
}
