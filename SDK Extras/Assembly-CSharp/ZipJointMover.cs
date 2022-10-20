using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

public class ZipJointMover : MonoBehaviour
{
	public enum ZipState
	{
		MOVING_UP = 0,
		MOVING_DOWN = 1,
		READY = 2
	}

	private Vector3 localVel;

	public ZipState zipState;

	[SerializeField]
	private bool isDebugging;

	public ZipLinkManager zipManager;

	public LinkData maxLinkData;

	public LinkData currLinkData;

	public Grip _grip;

	public ConfigurableJoint gripJoint;

	public Collider gripCollider;

	public Rigidbody gripBody;

	[SerializeField]
	private ConfigurableJoint moverJoint;

	public Rigidbody moverBody;

	public float duration;

	public float zipLength;

	[Tooltip("Meters/ second")]
	public float speed;

	private Coroutine moveUpRoutine;

	private Coroutine moveDownRoutine;

	[SerializeField]
	private AnimationCurve animCurve;

	public GameObject[] upperWheelObjs;

	public GameObject lowerWheelObj;

	public float upperWheelSpeed;

	public float lowerWheelSpeed;

	public UnityEvent OnGripClaim;

	public UnityEvent OnGripRelease;

	public UnityEvent OnCompleteMove;

	public UnityEvent OnBreakGrip;

	private PlayerZipSetup playerZipSetup;

	private float playerLerpDistance;

	public Hand activeHand;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnGrab(Hand hand)
	{
	}

	private void OnDrop(Hand hand)
	{
	}

	public void NPCMove(LinkData data)
	{
	}

	public void NPC_MoveDown()
	{
	}

	private void SetZipState(ZipState state)
	{
	}

	private void ResetGripLocalPos()
	{
	}

	private IEnumerator CoMoveJoint(float endGoalX)
	{
		return null;
	}

	private IEnumerator CoMoveJointDown()
	{
		return null;
	}

	private IEnumerator CoCheckGrip()
	{
		return null;
	}

	[ContextMenu("Set Duration")]
	public void SetDuration()
	{
	}

	[ContextMenu("GetLength")]
	public void GetLength()
	{
	}

	public ZipJointMover()
		: base()
	{
	}
}
