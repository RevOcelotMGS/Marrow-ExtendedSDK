using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class UIClock : MonoBehaviour
{
	public TextMeshPro txt_clock;

	private DateTime time;

	private WaitForSecondsRealtime sec;

	private string LeadingZero(int n)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator Clock()
	{
		return null;
	}

	public UIClock()
		: base()
	{
	}
}
