using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class GenericWaitForForwardEvent : MonoBehaviour
{
	[SerializeField]
	private UnityEvent ForwardEvent;

	public void FowardEvents(float delay)
	{
	}

	private IEnumerator CoDelayForward(float delay)
	{
		return null;
	}

	public GenericWaitForForwardEvent()
		: base()
	{
	}
}
