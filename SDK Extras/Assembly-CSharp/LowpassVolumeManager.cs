using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LowpassVolumeManager : MonoBehaviour
{
	public AudioLowPassFilter lpf;

	public AudioSource audioSource;

	[Range(10f, 22000f)]
	public float cutoffFreqLow;

	[Range(10f, 22000f)]
	public float cutoffFreqHigh;

	[Range(0f, 1f)]
	public float minVolume;

	[Range(0f, 1f)]
	public float maxVolume;

	public float lerpTime;

	public bool[] volumes;

	private bool isInVolume;

	private IEnumerator lerpEnumerator;

	private float currentLerpVal;

	private float currentVolumeVal;

	private void Start()
	{
	}

	public void EnterVolume(int i)
	{
	}

	public void ExitVolume(int i)
	{
	}

	private void CheckConfig()
	{
	}

	private IEnumerator LerpBlend(float fromCutoff, float toCutoff, float fromVol, float toVol)
	{
		return null;
	}

	public LowpassVolumeManager()
		: base()
	{
	}
}
