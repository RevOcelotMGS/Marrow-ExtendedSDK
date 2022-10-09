using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Utilities;
using SLZ.Zones;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class SkelGripEvents : MonoBehaviour
{
	[SerializeField]
	private Grip[] skeletonGrips;

	[SerializeField]
	private ConfigurableJoint skeletonFixedJoint;

	[SerializeField]
	private ConfigurableJoint[] allSkellJoints;

	[SerializeField]
	private GameObject skelRArmObj;

	[SerializeField]
	private GameObject wallParentObj;

	[SerializeField]
	private ConfigurableJoint[] wallJoints;

	public UnityEvent onWallBreakEvent;

	public float jointStrength;

	private Coroutine jointRoutine;

	[SerializeField]
	private bool isLowBreak;

	[SerializeField]
	private Transform audioTransform;

	[SerializeField]
	private AudioClip audioClip;

	[SerializeField]
	private AudioMixerGroup mixerGroup;

	[SerializeField]
	private Zone3dSound windSound;

	private AudioPlayer _ap;

	private float sourceRadius;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGrabSkeleton(Hand hand)
	{
	}

	public void KeystoneBroke()
	{
	}

	private void BreakRocks()
	{
	}

	private IEnumerator CoAdjustJoints()
	{
		return null;
	}

	[ContextMenu("GrabAllJoints")]
	public void GrabAllJoints()
	{
	}

	[ContextMenu("GrabGrips")]
	public void GrabGrips()
	{
	}

	public SkelGripEvents()
		: base()
	{
	}
}
