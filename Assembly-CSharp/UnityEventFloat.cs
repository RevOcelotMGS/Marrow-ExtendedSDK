using System;
using UnityEngine.Events;

[Serializable]
public class UnityEventFloat : UnityEvent<float>
{
	public UnityEventFloat()
		: base()
	{
	}
}
