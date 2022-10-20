using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Powerable : MonoBehaviour
{
	[SerializeField]
	[Header("POWERED AND TURNED ON")]
	protected bool m_Powered;

	[SerializeField]
	protected bool m_TurnedOn;

	[Space(5f)]
	[Header("DRAW")]
	[Tooltip("Default value for 10 minutes of use if capacity is 1000f in the PowerSource and there are 4 electronics using it. Divide number based on number of objects using it")]
	public float Discharge;

	[Tooltip("Used when checking compatability")]
	public ElectricItem Electronic;

	private Coroutine CoroutineUnChargeLoop;

	public Manager_Circuit ControlCircuit { get; set; }

	public OnOffSwitch SwitchRef { get; set; }

	public bool Powered
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool TurnedOn
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual void SwitchPowerOnOff(bool isOn)
	{
	}

	public virtual void VoltageToObject(float voltage, int id = 0)
	{
	}

	public virtual void Vector2InputToObject(Vector2 xyLocal, int id = 0)
	{
	}

	protected void OnDestroy()
	{
	}

	private void AddDischarge()
	{
	}

	public void UnCharge()
	{
	}

	private void SubtractDischarge()
	{
	}

	public void StopUnCharge()
	{
	}

	private IEnumerator CoUnchargeLoop()
	{
		return null;
	}

	public Powerable()
		: base()
	{
	}
}
