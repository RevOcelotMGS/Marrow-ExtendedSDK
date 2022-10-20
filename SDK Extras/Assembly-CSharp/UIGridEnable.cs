using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UIGridEnable : MonoBehaviour
{
	public AnimationCurve curve_spawn;

	public Vector2 spacing_start;

	private Vector2 spacing_end;

	private float timeToSpace;

	private float cur_timeToSpace;

	private Vector2 cur_spacing;

	private Vector2 tar_spacing;

	public GridLayoutGroup grid;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void GRIDSPACER()
	{
	}

	private IEnumerator FXChange()
	{
		return null;
	}

	public UIGridEnable()
		: base()
	{
	}
}
