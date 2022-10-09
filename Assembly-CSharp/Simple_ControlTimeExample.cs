using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class Simple_ControlTimeExample : MonoBehaviour
{
	public Control_GlobalTime ctrl_GlobalTime;

	public float max_countdown;

	private float cur_countdown;

	public TextMeshProUGUI text_CountDown;

	private bool alreadyActive;

	private float cur_upTime_real;

	private float cur_upTime_slow;

	public TextMeshProUGUI text_upTime_real;

	public TextMeshProUGUI text_upTime_slow;

	public TextMeshProUGUI text_TimeScale;

	public void TIMEACTION(int action)
	{
	}

	public void POWERED(bool powered = false)
	{
	}

	private IEnumerator Countdown()
	{
		return null;
	}

	private IEnumerator CountUpReal()
	{
		return null;
	}

	private IEnumerator CountUpSlow()
	{
		return null;
	}

	public void DISPLAYTEXT()
	{
	}

	private void Update()
	{
	}

	public Simple_ControlTimeExample()
		: base()
	{
	}
}
