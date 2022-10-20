using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

public class CarDoorController : MonoBehaviour
{
	public ConfigurableJoint jnt;

	public Rigidbody rb;

	public Servo servo;

	public Grip[] grips;

	public Grip[] insideGrips;

	public bool isLatched;

	public bool isInHand;

	public bool isLocked;

	public float latchThreshhold;

	public Vector3 positiveDrive;

	public Vector3 negativeDrive;

	public float positiveRot;

	public float negativeRot;

	private SoftJointLimit lowLimit;

	private SoftJointLimit highLimit;

	private SoftJointLimit zeroLimit;

	private JointDrive openDrive;

	private JointDrive closeDrive;

	[SerializeField]
	private UnityEvent DoorCloseEvent;

	[SerializeField]
	private UnityEvent DoorOpenEvent;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnHandAttached(Hand hand)
	{
	}

	private void OnHandDetached(Hand hand)
	{
	}

	private void OnFarHoverUpdate(Hand hand)
	{
	}

	private void OnHandAttachedUpdate(Hand hand)
	{
	}

	private void FixedUpdate()
	{
	}

	public void OPENDOOR()
	{
	}

	private IEnumerator SetLatch()
	{
		return null;
	}

	public void CLOSEDOOR()
	{
	}

	public void CLOSEDOORCAB()
	{
	}

	public CarDoorController()
		: base()
	{
	}
}
