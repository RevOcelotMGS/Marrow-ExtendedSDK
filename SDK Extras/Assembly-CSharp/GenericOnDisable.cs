using UnityEngine;
using UnityEngine.Events;

public class GenericOnDisable : MonoBehaviour
{
	[SerializeField]
	private UnityEvent DisableEvent;

	private void OnDisable()
	{
	}

	public GenericOnDisable()
		: base()
	{
	}
}
