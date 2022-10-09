using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IrisDoorCtrl : MonoBehaviour
{
	public OcclusionPortal occlusionPortal;

	public Transform closeTarget;

	public Transform[] irisTransform;

	public GameObject doorTrigger;

	public bool closedOnStart;

	private bool[] _bladeClosed;

	private float _closeTolerance;

	private Coroutine _irisDoorCheck;

	private bool _irisIsOpen;

	private float _waitTime;

	private void Start()
	{
	}

	public void EnableTrigger()
	{
	}

	public void DisableTrigger()
	{
	}

	public void ToggleTrigger()
	{
	}

	public void IrisOpening()
	{
	}

	public void IrisClosing()
	{
	}

	private IEnumerator checkDoor()
	{
		return null;
	}

	public IrisDoorCtrl()
		: base()
	{
	}
}
