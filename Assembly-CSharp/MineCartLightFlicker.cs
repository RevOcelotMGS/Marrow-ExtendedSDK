using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MineCartLightFlicker : MonoBehaviour
{
	public Light cartLight;

	public AnimationCurve OnCurve;

	public AnimationCurve OffCurve;

	public float flickerLength;

	private float _curTime;

	private float _endTime;

	private float _cachedOnIntensity;

	private Coroutine _flickerCo;

	public bool offOnStart;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[ContextMenu("Flicker On")]
	public void FlickerOn()
	{
	}

	[ContextMenu("Flicker Off")]
	public void FlickerOff()
	{
	}

	private IEnumerator Flicker(AnimationCurve curve, float curIntensity, float targetIntesity, bool isTurningOn)
	{
		return null;
	}

	public MineCartLightFlicker()
		: base()
	{
	}
}
