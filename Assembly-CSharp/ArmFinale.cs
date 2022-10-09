using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Rig;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Playables;

public class ArmFinale : MonoBehaviour
{
	private enum ArmStage
	{
		Preshow = 0,
		Decent = 1,
		Hold = 2,
		Ascent = 3,
		Dropped = 4,
		Void = 5
	}

	public Rigidbody windmillBlades;

	public ConfigurableJoint windmillJoint;

	public PlayableDirector decent;

	public PlayableDirector ascent;

	public InteractableHostManager hostManager;

	public GameObject holeStopper;

	public SkinnedMeshRenderer armMesh;

	public Seat palmSeat;

	private RigManager _lastRmToDetatch;

	private int _attachedHandCount;

	private ArmStage _armStage;

	private float _timer;

	public void GongHit()
	{
	}

	public void ReadyForAscent()
	{
	}

	public void ReadyForVoid()
	{
	}

	public void WindmillProjectRotation(float secondsFromNow)
	{
	}

	private IEnumerator CoTargetWindMill(float duration, float deltaAngVel)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnHandAttached(InteractableHost host, Hand hand)
	{
	}

	private void OnHandDetached(InteractableHost host, Hand hand)
	{
	}

	public ArmFinale()
		: base()
	{
	}
}
