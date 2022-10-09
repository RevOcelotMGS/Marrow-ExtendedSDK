using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class UnityEventTrigger : UnityEvent<Collider>
{
	public UnityEventTrigger()
		: base()
	{
	}
}
