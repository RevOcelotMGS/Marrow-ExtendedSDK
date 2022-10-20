using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.SFX;
using UnityEngine;

public class Launch_Gun : MonoBehaviour
{
	public enum LaunchMode
	{
		PUSH = 0,
		PULL = 1
	}

	public LaunchMode launchMode;

	public Grip triggerGrip;

	public Transform firePoint;

	public Hand oppositeHand;

	public Hand leftHand;

	public Hand rightHand;

	public float maxFireDist;

	public float playerLaunchForce;

	public float objectLaunchForce;

	public bool isDisplayingFX;

	[SerializeField]
	private bool isReadyToFire;

	public float rechargeTime;

	public GravGunSFX sfx;

	[SerializeField]
	private Rigidbody playerPelvisRB;

	private Rigidbody[] _playerRbs;

	private InteractableHost _host;

	private bool _isTriggerDownOnGrab;

	[SerializeField]
	private GameObject aimAssistParentObj;

	[SerializeField]
	private GameObject aimAssistScalerObj;

	[SerializeField]
	private GameObject aimAssistHitObj;

	[SerializeField]
	private GameObject aimAssistMissObj;

	[SerializeField]
	private GameObject readyIndicatorObj;

	[SerializeField]
	private GameObject directionDecalObj;

	private float aimAssistScale;

	private void Awake()
	{
	}

	private void OnTriggerHandAttached(Hand hand)
	{
	}

	private void OnTriggerHandDetached(Hand hand)
	{
	}

	private void OnTriggerGripUpdate(Hand hand)
	{
	}

	private IEnumerator CoCoolDown()
	{
		return null;
	}

	private void FireLaunchRay()
	{
	}

	private void FireFX(bool isHitting)
	{
	}

	private IEnumerator CoDisableAimAssist()
	{
		return null;
	}

	private void DisableAimAssist()
	{
	}

	private void ApplyForceToTarget(Rigidbody targetRB, Vector3 hitPosition)
	{
	}

	private void ApplyForceToPlayer(Vector3 hitPosition)
	{
	}

	public void ToggleLaunchMode()
	{
	}

	public Launch_Gun()
		: base()
	{
	}
}
