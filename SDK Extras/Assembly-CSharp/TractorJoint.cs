using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

public class TractorJoint : MonoBehaviour
{
	[SerializeField]
	private Rigidbody tractorBody;

	[SerializeField]
	private Grip tractorGrip;

	[SerializeField]
	private ForcePullGrip tractorForcePull;

	[SerializeField]
	private ConfigurableJoint joint;

	private Coroutine TractorRoutine;

	[SerializeField]
	private float initialWaitDuration;

	[SerializeField]
	private float duration;

	[SerializeField]
	private float startForce;

	[SerializeField]
	private float endForce;

	[SerializeField]
	private float maxForce;

	[SerializeField]
	private float rotForce;

	public float breakForce;

	private float endRotForce;

	private JointDrive tractorDrive;

	private JointDrive tractorRotDrive;

	[SerializeField]
	private AnimationCurve animCurve;

	[ContextMenu("StartTractorBeam")]
	public void StartTractorBeam()
	{
	}

	private IEnumerator CoTractorBeam()
	{
		return null;
	}

	public TractorJoint()
		: base()
	{
	}
}
