using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Volume))]
public class FadeAndDisableVolume : MonoBehaviour
{
	public void FadeOff(float Seconds)
	{
	}

	public void FadeOn(float Seconds)
	{
	}

	private IEnumerator Fading(float Seconds)
	{
		return null;
	}

	private IEnumerator Unfading(float Seconds)
	{
		return null;
	}

	public FadeAndDisableVolume()
		: base()
	{
	}
}
