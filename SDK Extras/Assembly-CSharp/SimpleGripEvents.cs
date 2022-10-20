using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

public class SimpleGripEvents : MonoBehaviour
{
	public UnityEvent OnIndexDown;

	public UnityEvent OnMenuTapDown;

	public Grip[] Grips;

	private void Awake()
	{
	}

	public void OnAttachedUpdateDelegate(Hand hand)
	{
	}

	private void OnDestroy()
	{
	}

	public SimpleGripEvents()
		: base()
	{
	}
}
