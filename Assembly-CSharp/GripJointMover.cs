using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

public class GripJointMover : MonoBehaviour
{
	[SerializeField]
	private enum MoveState
	{
		UP = 0,
		DOWN = 1,
		MOVING_UP = 2,
		MOVING_DOWN = 3,
		ROTATED = 4
	}

	[SerializeField]
	private MoveState moveState;

	[SerializeField]
	private bool isRotaterAttached;

	[SerializeField]
	private float duration;

	[SerializeField]
	private Grip _grip;

	[SerializeField]
	private ConfigurableJoint joint;

	[SerializeField]
	private Transform topTarget;

	[SerializeField]
	private Transform bottomTarget;

	[SerializeField]
	private float topHeight;

	[SerializeField]
	private float bottomHeight;

	[SerializeField]
	private GameObject anchorObj;

	[SerializeField]
	private float rotDuration;

	[SerializeField]
	private float inwardVel;

	[SerializeField]
	private float outwardVel;

	private Coroutine jointMoveRoutine;

	[SerializeField]
	private ConfigurableJoint rotJoint;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private GameObject CreateAnchorObject(ConfigurableJoint joint)
	{
		return null;
	}

	[ContextMenu("ToggleMove")]
	public void ToggleMove()
	{
	}

	private IEnumerator CoMoveJointTarget(Vector3 startPos, Vector3 endPos, float initialDelay = 0f)
	{
		return null;
	}

	public void TeleportJointToStart()
	{
	}

	private void OnGrab(Hand hand)
	{
	}

	private void OnDrop(Hand hand)
	{
	}

	private IEnumerator CoCheckGrip()
	{
		return null;
	}

	public void RotateInwards()
	{
	}

	public void RotateOutwards()
	{
	}

	public void OnDrawGizmosSelected()
	{
	}

	public GripJointMover()
		: base()
	{
	}
}
