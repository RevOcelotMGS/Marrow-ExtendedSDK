using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Events;

public class MineCartLapBar : MonoBehaviour
{
	[Tooltip("Joint for lapbar")]
	[InspectorDisplayName("Configurable Joint")]
	public ConfigurableJoint cj;

	[Tooltip("needs to be set to allow slow mo to be disabled")]
	public OpenControllerRig openControllerRig;

	[InspectorDisplayName("Seat")]
	[Tooltip("Seat script goes here")]
	public Seat seat;

	[InspectorDisplayName("Servo Script")]
	[Tooltip("Servo script goes here")]
	public Servo servo;

	[InspectorDisplayName("Lock Angle")]
	[Tooltip("The amount of rotation in degrees that will lock the joint")]
	public float lockAngle;

	[SerializeField]
	[Tooltip("Event to fire on player seated")]
	[Header("Events")]
	private UnityEvent OnSeat;

	[SerializeField]
	[Tooltip("Event to fire on player unseated")]
	private UnityEvent OnUnseat;

	[Tooltip("Event to fire on bar locked")]
	[SerializeField]
	private UnityEvent OnBarLocked;

	[SerializeField]
	[Tooltip("Event to fire on bar unlocked")]
	private UnityEvent OnBarUnlocked;

	private Quaternion startRotation;

	private Coroutine _checkingBar;

	public void Reset()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnSeated()
	{
	}

	private void OnUnSeated()
	{
	}

	private IEnumerator CoCheckBar()
	{
		return null;
	}

	public bool CheckBar()
	{
		return default(bool);
	}

	public void LockBar()
	{
	}

	public void UnlockBar()
	{
	}

	private void OnDisable()
	{
	}

	public MineCartLapBar()
		: base()
	{
	}
}
