using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

public class HubDoorController : MonoBehaviour
{
	public ConfigurableJoint jnt;

	public Rigidbody rb;

	public Servo servo;

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

	public void OPENDOOR()
	{
	}

	public void CLOSEDOOR()
	{
	}

	private IEnumerator CloseCoroutine()
	{
		return null;
	}

	public HubDoorController()
		: base()
	{
	}
}
