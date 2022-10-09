using UnityEngine;
using UnityEngine.Events;

public class RenderObjectBroadcaster : MonoBehaviour
{
	public UnityEvent RenderEvent;

	private void OnRenderObject()
	{
	}

	public RenderObjectBroadcaster()
		: base()
	{
	}
}
