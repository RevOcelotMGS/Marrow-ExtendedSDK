using UnityEngine;

public class Powerable_Desk : Powerable
{
	public float map_low;

	public float map_high;

	public ConfigurableJoint jnt_this;

	public GameObject obj_Report;

	private void SendReport()
	{
	}

	public Powerable_Desk()
		: base()
	{
	}
}
