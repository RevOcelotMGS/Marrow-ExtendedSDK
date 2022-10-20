using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PowerSocket : MonoBehaviour
{
	[SerializeField]
	[Tooltip("The charge rate passed into the battery in Watts/min")]
	private float m_ChargeCurrent;

	private Coroutine CoroutineChargeLoop;

	public bool Charging;

	[Header("SPECIFIC POWERSOURCE")]
	[SerializeField]
	private PowerSource SamePower;

	[Space(5f)]
	[Header("INDICATOR LIGHTS")]
	public GameObject[] indicateOn;

	public GameObject[] indicateOff;

	public Manager_Circuit ControlCircuit { get; set; }

	public PowerSource PS { get; private set; }

	private void Start()
	{
	}

	public void EnterPowerOut(PowerSource ps, bool match)
	{
	}

	public void RunOutPower(PowerSource ps)
	{
	}

	public void ExitPowerOut(PowerSource ps)
	{
	}

	private void OnDestroy()
	{
	}

	private void M_Charge()
	{
	}

	private IEnumerator CoChargeLoop()
	{
		return null;
	}

	private void M_StopCharge()
	{
	}

	public void EnterCharge(PowerSource ps, bool match)
	{
	}

	public void ExitCharge(PowerSource ps)
	{
	}

	private void M_SetIndicators(bool OnOff = false)
	{
	}

	public PowerSocket()
		: base()
	{
	}
}
