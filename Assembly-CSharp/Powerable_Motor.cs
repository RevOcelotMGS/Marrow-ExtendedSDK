using UnityEngine;

public class Powerable_Motor : Powerable
{
	[Header("VOLTAGE")]
	public bool isBinary;

	[Range(-1f, 1f)]
	[Space(5f)]
	public float cur_InputVoltage;

	private float att_Voltage;

	[Range(-1f, 1f)]
	[Space(5f)]
	public float min_InputVoltage;

	[Range(-1f, 1f)]
	public float max_InputVoltage;

	[Space(5f)]
	public float min_TargetVoltage;

	public float max_TargetVoltage;

	[SerializeField]
	[Space(5f)]
	[Header("MOTOR CONTROL")]
	private float m_TargetVelocity;

	[SerializeField]
	private float m_MaxForce;

	[SerializeField]
	private float m_PositionDamper;

	private ConfigurableJoint jnt_this;

	private Rigidbody rb_this;

	private float stored_Draw;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SETJOINT(float voltage = 1f)
	{
	}

	public Powerable_Motor()
		: base()
	{
	}
}
