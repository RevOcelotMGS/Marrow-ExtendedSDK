using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class control_sign_LVLUP : MonoBehaviour
{
	public GameObject L1;

	public GameObject glint_L1_l;

	public GameObject glint_L1_u;

	public GameObject V;

	public GameObject glint_V_l;

	public GameObject glint_V_u;

	public GameObject L2;

	public GameObject glint_L2_l;

	public GameObject glint_L2_u;

	public GameObject U;

	public GameObject P;

	public GameObject dot_outer;

	public GameObject dot_inner;

	public GameObject arrow_outer;

	public GameObject arrow_inner;

	public GameObject arrow_middle_A;

	public GameObject arrow_middle_B;

	public GameObject credits_A;

	public GameObject credits_B;

	public GameObject credits_C;

	public int creditsOwned;

	[ColorUsage(true, true)]
	public Color yellow;

	[ColorUsage(true, true)]
	public Color white;

	[ColorUsage(true, true)]
	public Color blue;

	[ColorUsage(true, true)]
	public Color green;

	[ColorUsage(true, true)]
	public Color pink;

	[ColorUsage(true, true)]
	public Color red;

	[ColorUsage(true, true)]
	public Color color_dead;

	private void Start()
	{
	}

	private void SetDefaultNeon()
	{
	}

	private void Update()
	{
	}

	private IEnumerator ArrowBlink()
	{
		return null;
	}

	private IEnumerator GlintBlink()
	{
		return null;
	}

	private IEnumerator BlinkRed()
	{
		return null;
	}

	private void CheckLights()
	{
	}

	private void CreditsSign()
	{
	}

	public control_sign_LVLUP()
		: base()
	{
	}
}
