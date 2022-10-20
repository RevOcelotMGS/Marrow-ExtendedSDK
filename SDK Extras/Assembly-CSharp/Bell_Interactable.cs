using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

public class Bell_Interactable : MonoBehaviour
{
	[SerializeField]
	private enum MoveState
	{
		UP = 0,
		DOWN = 1,
		MOVING_UP = 2,
		MOVING_DOWN = 3
	}

	[SerializeField]
	private bool isVisDebug;

	public bool isReady;

	[SerializeField]
	private MoveState moveState;

	[SerializeField]
	private float duration;

	[SerializeField]
	private InteractableHost host;

	[SerializeField]
	private Grip _grip;

	[SerializeField]
	private ConfigurableJoint joint;

	[SerializeField]
	private Transform topTarget;

	[SerializeField]
	private Transform bottomTarget;

	[SerializeField]
	private GameObject anchorObj;

	private Coroutine jointMoveRoutine;

	public UnityEvent OnRing;

	public UnityEvent OnBellReset;

	[SerializeField]
	private Rigidbody[] jointChainRBs;

	public Quaternion[] localBodyRotations;

	public Vector3[] localBodyPositions;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private GameObject CreateAnchorObject(ConfigurableJoint joint)
	{
		return null;
	}

	private void OnGrab(Hand hand)
	{
	}

	private void OnDrop(Hand hand)
	{
	}

	public void RingTheBell()
	{
	}

	public void TeleportToUpState()
	{
	}

	[ContextMenu("ToggleMove")]
	public void ToggleMove()
	{
	}

	private IEnumerator CoMoveJointTarget(Vector3 startPos, Vector3 endPos)
	{
		return null;
	}

	[ContextMenu("Reset Bell")]
	public void ResetBell()
	{
	}

	private IEnumerator CoResetBell()
	{
		return null;
	}

	[ContextMenu("Get All Local Positions")]
	private void GetAllReferences()
	{
	}

	public void OnDrawGizmos()
	{
	}

	[ContextMenu("ForceDetach")]
	public void ForceDetachFromBell()
	{
	}

	public Bell_Interactable()
		: base()
	{
	}
}
