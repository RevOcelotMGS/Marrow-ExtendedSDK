using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

public class TorquePlate : MonoBehaviour
{
	private Rigidbody rb;

	private ConfigurableJoint jnt;

	public float launchReturnSeconds;

	private Coroutine _moveCoroutine;

	public AudioClip launchClip;

	public AudioMixerGroup mixergroup;

	public float rotTargetHigh;

	public float rotTargetLow;

	private void Awake()
	{
	}

	public void Launch()
	{
	}

	public IEnumerator CoLaunch()
	{
		return null;
	}

	public TorquePlate()
		: base()
	{
	}
}
