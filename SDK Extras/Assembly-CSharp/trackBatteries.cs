using UnityEngine;

public class trackBatteries : MonoBehaviour
{
	public enum ThisBattery
	{
		A = 0,
		B = 1
	}

	public GameControl_Hub gameControl;

	public GameObject dummyBattery;

	public ThisBattery thisBattery;

	public void BatteryPlaced()
	{
	}

	public trackBatteries()
		: base()
	{
	}
}
