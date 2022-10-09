using UnityEngine;
using VehicleAI;

public class ObjectSpeedTracker : MonoBehaviour
{
	public Rigidbody trackedRb;

	public BaseVehicleSensors sensor;

	private void FixedUpdate()
	{
	}

	public ObjectSpeedTracker()
		: base()
	{
	}
}
