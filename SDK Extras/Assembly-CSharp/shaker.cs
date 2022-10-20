using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class shaker : MonoBehaviour
{
	[Range(0f, 1f)]
	[SerializeField]
	private float multiplier;

	[SerializeField]
	private Transform temptrans;

	[HideInInspector]
	[SerializeField]
	private Rigidbody bodyRB;

	private void Reset()
	{
	}

	public void TimedShake(float Shaketime)
	{
	}

	public void TimedShake(float Shaketime, float Frequency, Quaternion Direction)
	{
	}

	public void TimedShake(float Shaketime, float Frequency, Quaternion Direction, Vector3 AxisAlignedIntensity)
	{
	}

	public void ContinuousShake()
	{
	}

	private IEnumerator TimedShakeCo(float Shaketime, float Frequency, Quaternion Direction, Vector3 AxisAlignedIntensity)
	{
		return null;
	}

	private IEnumerator ContinuousShaking()
	{
		return null;
	}

	public shaker()
		: base()
	{
	}
}
