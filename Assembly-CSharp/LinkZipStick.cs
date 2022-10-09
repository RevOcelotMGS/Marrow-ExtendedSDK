using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

public class LinkZipStick : MonoBehaviour
{
	public Rigidbody rb;

	[SerializeField]
	private Grip grip;

	[SerializeField]
	private ConfigurableJoint joint;

	private Vector3 startPos;

	private Quaternion startRot;

	private float initBreakForce;

	public int activeStick;

	[SerializeField]
	private GameObject[] sticks;

	public float[] conAnchor;

	[SerializeField]
	private GameObject shortStick;

	[SerializeField]
	private GameObject medStick;

	[SerializeField]
	private GameObject longStick;

	[SerializeField]
	private Grip shortGrip;

	[SerializeField]
	private Grip medGrip;

	[SerializeField]
	private Grip longGrip;

	private void OnEnable()
	{
	}

	private void OnAttach(Hand hand)
	{
	}

	private void OnDetach(Hand hand)
	{
	}

	private void ResetJoint()
	{
	}

	private void CreateJoint()
	{
	}

	private IEnumerator CoCheckGrip(float initialWait = 0.15f)
	{
		return null;
	}

	private void OnJointBreak(float breakForce)
	{
	}

	public void SetZipLengthObject(int currStick)
	{
	}

	public LinkZipStick()
		: base()
	{
	}
}
