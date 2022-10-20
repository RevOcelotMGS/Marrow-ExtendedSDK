using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Boneworks;
using SLZ.Interaction;
using UnityEngine;

public class RopeSwing : MonoBehaviour
{
	[SerializeField]
	private bool isReady;

	[SerializeField]
	private Rigidbody anchorRB;

	[SerializeField]
	private Rigidbody gripRB;

	[SerializeField]
	private ConfigurableJoint swingJoint;

	[SerializeField]
	private Grip _grip;

	[SerializeField]
	private LineRenderer lineRend;

	[SerializeField]
	private DrawLine2Points drawLine;

	[SerializeField]
	private GameObject lineRendGripTarg;

	[SerializeField]
	private float jointLimitValue;

	[SerializeField]
	private GameObject gripPrefab;

	[SerializeField]
	private Vector3 startGripPos;

	[SerializeField]
	private Quaternion startGripRot;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void OnGrab(Hand hand)
	{
	}

	public void OnDrop(Hand hand)
	{
	}

	private IEnumerator CoCheckGrip()
	{
		return null;
	}

	private void ResetRopeSwing()
	{
	}

	public void OnDrawGizmos()
	{
	}

	public RopeSwing()
		: base()
	{
	}
}
