using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UIWobble : MonoBehaviour
{
	public float wobbleFrequency;

	public Vector3 wobbleAmplitude;

	public float rotWobbleAmplitude;

	public float smoothTime;

	public float rotSmoothTime;

	public AnimationCurve amplitudeCurve;

	public AnimationCurve smoothCurve;

	public float curveLength;

	private float wobbleTime;

	private float amplitudeProgress;

	private float smoothProgress;

	private Vector3 startPos;

	private Vector3 startRot;

	private Vector3 vectorVelocity;

	private float floatVelocity;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator Wobble()
	{
		return null;
	}

	private void Update()
	{
	}

	private Vector3 GetRandomPos(Vector3 starVar, Vector3 n)
	{
		return default(Vector3);
	}

	private float GetRandomFloat(float n)
	{
		return default(float);
	}

	public UIWobble()
		: base()
	{
	}
}
