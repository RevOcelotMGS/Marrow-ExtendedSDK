using UnityEngine;

public class CheckPoint : MonoBehaviour
{
	public GameObject centerpoint;

	public int checkpointNumber;

	public BoxCollider selfCollider;

	public string vehicleComponentCpName;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public CheckPoint()
		: base()
	{
	}
}
