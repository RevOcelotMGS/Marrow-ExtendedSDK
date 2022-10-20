using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class UnityEventCollision : UnityEvent<Collider, Vector3, Vector3>
{
	public UnityEventCollision()
		: base()
	{
	}
}
