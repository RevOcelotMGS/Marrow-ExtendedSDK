using UnityEngine;
using UnityEngine.Events;

public class GenericOnDestroy : MonoBehaviour
{
	[SerializeField]
	private UnityEvent DestroyEvent;

	private void OnDestroy()
	{
	}

	public GenericOnDestroy()
		: base()
	{
	}
}
