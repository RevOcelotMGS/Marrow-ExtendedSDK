using UnityEngine;

public class Powerable_TranBlender : Powerable
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

	public Transform[] ones;

	public Transform[] twos;

	public Transform[] writeTos;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ToggleVoltage()
	{
	}


	private void BLENDTRANS(float voltage = 1f)
	{
	}

	public Powerable_TranBlender()
		: base()
	{
	}
}
