using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DoorLightControl : MonoBehaviour
{
	public Renderer mat_Render;

	[ColorUsage(true, true)]
	public Color hdr_OnColor;

	[ColorUsage(true, true)]
	public Color hdr_BlinkColor;

	[ColorUsage(true, true)]
	public Color hdr_OffColor;

	public bool LightOn;

	public bool Flicker;

	private MaterialPropertyBlock propertyBlock;

	private int _colorHash;

	private void Awake()
	{
	}

	private void InitializePropertyBlock()
	{
	}

	private void Start()
	{
	}

	public void BeginFlicker()
	{
	}

	private IEnumerator FlickerLight()
	{
		return null;
	}

	public void SetEmissive(bool On)
	{
	}

	public DoorLightControl()
		: base()
	{
	}
}
