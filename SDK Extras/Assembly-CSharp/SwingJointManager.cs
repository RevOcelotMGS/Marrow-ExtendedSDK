using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SwingJointManager : MonoBehaviour
{
	public SwingJointInverter[] swingObjs;

	public float delay;

	public bool reset;

	public float wait_timer;

	private bool start;

	public void Start()
	{
	}

	private IEnumerator WaitTimer()
	{
		return null;
	}

	private IEnumerator WaitReset()
	{
		return null;
	}

	public void DeathReset()
	{
	}

	public void RespawnReset()
	{
	}

	public void Update()
	{
	}

	public IEnumerator CoEnableSwingers()
	{
		return null;
	}

	public SwingJointManager()
		: base()
	{
	}
}
