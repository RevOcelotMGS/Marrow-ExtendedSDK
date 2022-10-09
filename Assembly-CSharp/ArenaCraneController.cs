using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ArenaCraneController : MonoBehaviour
{
	public enum MoveState
	{
		MOVING = 0,
		AT_TARGET = 1,
		IDLE = 2
	}

	public enum GrabState
	{
		GRAB = 0,
		DUMP = 1,
		RETRACT = 2,
		NONE = 3
	}

	[SerializeField]
	private ConfigurableJoint xJoint;

	[SerializeField]
	private ConfigurableJoint zJoint;

	[SerializeField]
	private ConfigurableJoint dropJoint;

	[SerializeField]
	private ConfigurableJoint grabJoint;

	[SerializeField]
	private Transform target;

	[SerializeField]
	private float sqrDistToBody;

	private float dropDuration;

	[SerializeField]
	private float sqrDist;

	[SerializeField]
	private float targetThresh;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float attachThresh;

	private Coroutine dumpRoutine;

	[SerializeField]
	private Vector3 xTarget;

	[SerializeField]
	private Vector3 zTarget;

	public MoveState moveState;

	public GrabState grabState;

	[SerializeField]
	private bool isEmpty;

	[SerializeField]
	private Rigidbody containerBody;

	[SerializeField]
	private CargoData activeCargo;

	[SerializeField]
	private CargoData[] cargoData;

	[ContextMenu("StartMoveState")]
	public void StartMoveState()
	{
	}

	public void UpdateMoveState(MoveState state)
	{
	}

	public void UpdateGrabState(GrabState state)
	{
	}

	private void FixedUpdate()
	{
	}

	public void Grab()
	{
	}

	private IEnumerator CoGrab()
	{
		return null;
	}

	public void Dump()
	{
	}

	private IEnumerator CoDump()
	{
		return null;
	}

	[ContextMenu("PickupCargoOne")]
	public void PickupCargoOne()
	{
	}

	[ContextMenu("PickupCargoTwo")]
	public void PickupCargoTwo()
	{
	}

	public void PickupCargo(int idX)
	{
	}

	public ArenaCraneController()
		: base()
	{
	}
}
