using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class VignetteController : MonoBehaviour
{
	private enum FadeType
	{
		On = 0,
		Off = 1
	}

	[SerializeField]
	[HideInInspector]
	private Renderer rend;

	private void Start()
	{
	}

	public void FadeToFull()
	{
	}

	public void FadeOn()
	{
	}

	public void FadeOn(float Time)
	{
	}

	public void FadeOff()
	{
	}

	public void FadeOff(float Time)
	{
	}

	private IEnumerator Fader(FadeType Fade, float FadeTime)
	{
		return null;
	}

	public VignetteController()
		: base()
	{
	}
}
