using SLZ.Interaction;
using UnityEngine;

public class Cable_Powerable : Powerable
{
	private enum CableMode
	{
		BIDIRECTIONAL = 0,
		ON_OFF = 1
	}

	[Header("CABLE REFS")]
	[Space(5f)]
	public CylinderGrip m_grip;

	public Renderer m_rend;

	public Transform m_CableMesh;

	[SerializeField]
	private CableMode m_Mode;

	[Space(5f)]
	[Header("LEVER REF")]
	public bool isBinary;

	[Space(5f)]
	[Range(0f, 0.2f)]
	[Header("VOLTAGE OFFSET")]
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

	private float stored_Draw;

	private float m_length;

	private float offSetY;

	private float m_minVelocity;

	private float m_maxVelocity;

	private float m_noVelocity;

	private void Start()
	{
	}

	public void SetMesh(Vector3 scale)
	{
	}

	public void SetGrip(float radius, float length, float velocity)
	{
	}

	private float SetVelocityRate(float Voltage)
	{
		return default(float);
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision c)
	{
	}

	private void OnCollisionStay(Collision c)
	{
	}

	private void AddForce(Collision c)
	{
	}

	public Cable_Powerable()
		: base()
	{
	}
}
