using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ColorMaterialPropertyBlock : MonoBehaviour
{
	[SerializeField]
	private Renderer[] Renderers;

	[SerializeField]
	private string[] PropertyNames;

	[SerializeField]
	private bool ColorOnAwake;

	[SerializeField]
	[ColorUsage(true, true)]
	private Color DefaultColor;

	private int[] propIDs;

	private MaterialPropertyBlock propertyBlock;

	private void Awake()
	{
	}

	public void SetAllColors(Color color)
	{
	}

	public void SetDefaultColors()
	{
	}

	public void SetColorsToBlack()
	{
	}

	public void LerpClearToWhite(float Time)
	{
	}

	public void LerpWhiteToClear(float Time)
	{
	}

	public void LerpColor(Color Target)
	{
	}

	public void LerpColor(Color Target, float Time)
	{
	}

	public void LerpColor(Color Base, Color Target, float Time)
	{
	}

	private IEnumerator LerpColorCo(Color Base, Color Target, float LerpTime)
	{
		return null;
	}

	public ColorMaterialPropertyBlock()
		: base()
	{
	}
}
