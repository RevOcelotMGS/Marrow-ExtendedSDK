using UnityEngine;

public class PinTracker : MonoBehaviour
{
	public LayerMask layersToIgnore;

	public BowlingResetMechanism pinManager;

	private void OnCollisionEnter(Collision collision)
	{
	}

	public PinTracker()
		: base()
	{
	}
}
