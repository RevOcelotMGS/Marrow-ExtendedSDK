using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

public class GripSwing : MonoBehaviour
{
	[SerializeField]
	private GameObject anchorObj;

	[SerializeField]
	private ConfigurableJoint _joint;

	[SerializeField]
	private Grip _grip;

	public UnityEvent OnGripClaim;

	public UnityEvent OnDetachComplete;

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

	private void ResetJoint()
	{
	}

	public GripSwing()
		: base()
	{
	}
}
