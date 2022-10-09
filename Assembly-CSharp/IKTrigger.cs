using UnityEngine;

public class IKTrigger : MonoBehaviour
{
	[SerializeField]
	private bool isEnablingIK;

	private void OnTriggerEnter(Collider other)
	{
	}

	public IKTrigger()
		: base()
	{
	}
}
