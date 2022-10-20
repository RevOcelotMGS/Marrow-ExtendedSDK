using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

public class GripTimerEvents : MonoBehaviour
{
	[SerializeField]
	private Grip[] grips;

	[SerializeField]
	private float elapsedTime;

	[SerializeField]
	private float firstThreshold;

	[SerializeField]
	private float secondThreshold;

	public UnityEvent OnFirstThreshold;

	public UnityEvent OnSecondThreshold;

	private Coroutine gripTimerRoutine;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnGrab(Hand hand)
	{
	}

	public void OnDrop(Hand hand)
	{
	}

	private IEnumerator CoGripTimerRoutine()
	{
		return null;
	}

	private IEnumerator CoCheckGrips()
	{
		return null;
	}

	public GripTimerEvents()
		: base()
	{
	}
}
