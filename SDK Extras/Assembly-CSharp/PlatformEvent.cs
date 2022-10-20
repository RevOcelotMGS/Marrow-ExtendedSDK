using UnityEngine;
using UnityEngine.Events;

public class PlatformEvent : MonoBehaviour
{
	private enum Platform
	{
		Android = 0,
		PC = 1
	}

	public UnityEvent PCEvent;

	public UnityEvent AndroidEvent;

	[SerializeField]
	private Platform platform;

	private void Awake()
	{
	}

	public PlatformEvent()
		: base()
	{
	}
}
