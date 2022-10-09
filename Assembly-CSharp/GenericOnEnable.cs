using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class GenericOnEnable : MonoBehaviour
{
	[SerializeField]
	private UnityEvent StartEvent;

	private bool wasJustAwake;

	private void Awake()
	{
	}

	private IEnumerator CoDelaySpawn()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	public GenericOnEnable()
		: base()
	{
	}
}
