using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QT_LightFlicker : MonoBehaviour
{
	public float minFlickerSpeed;

	public float maxFlickerSpeed;

	public float minLightIntensity;

	public float maxLightIntensity;

	public bool ShiftLight;

	public float shiftAmount;

	private void Start()
	{
	}

	private IEnumerator Flicker()
	{
		return null;
	}

	public QT_LightFlicker()
		: base()
	{
	}
}
