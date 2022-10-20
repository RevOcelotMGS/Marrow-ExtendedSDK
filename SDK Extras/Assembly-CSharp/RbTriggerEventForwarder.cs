using UnityEngine;
using UnityEngine.Events;

public class RbTriggerEventForwarder : MonoBehaviour
{
	[SerializeField]
	private LayerMask LayerFilter;

	public UnityEvent<Rigidbody> OnTriggerEnterEvent;

	public UnityEvent<Rigidbody> OnTriggerExitEvent;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public RbTriggerEventForwarder()
		: base()
	{
	}
}
