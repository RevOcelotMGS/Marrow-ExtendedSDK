using UnityEngine;

public class GarageDoorStopTrigger : MonoBehaviour
{
	public GarageDoorPowerable m_gDoorRef;

	public GameObject SlatsIgnore;

	private void Awake()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public GarageDoorStopTrigger()
		: base()
	{
	}
}
