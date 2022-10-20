using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Vehicle;
using UnityEngine;

public class mineCartGunControl : MonoBehaviour
{
	[InspectorDisplayName("Slider Joint Translation")]
	[Tooltip("Joint for raising arm")]
	public ConfigurableJoint cj_translate;

	[Tooltip("Joint for rotating arm")]
	[InspectorDisplayName("Arm Joint Rotation")]
	public ConfigurableJoint cj_rotate;

	[InspectorDisplayName("Gun Joint Rotation")]
	[Tooltip("Joint for rotating gun")]
	public ConfigurableJoint cj_gun;

	[InspectorDisplayName("Servo Script")]
	[Tooltip("Servo script goes here")]
	public Servo servo;

	[Tooltip("Seat script goes here")]
	[InspectorDisplayName("Seat")]
	public Seat seat;

	public Rigidbody rigidbody_translate;

	public Rigidbody rigidbody_gun;

	public Rigidbody rigidbody_mineCart;

	public GameObject laser;

	public Animator animator;

	public float upAngleLock;

	public float downAngleLock;

	public float translateUpValue;

	public float translateDownValue;

	private bool _lockableState;

	private Vector3 _startPosition;

	private Quaternion _startRotation;

	private Quaternion _upRotation;

	private Quaternion _hiddenRotation;

	private float _lockUpValue;

	private float _lockDownValue;

	private ConfigurableJoint _lockJoint;

	private Vector3 _gunAnchor;

	private int _slideExtendHash;

	private int _slideRetractHash;

	public Grip[] grips;

	public void Reset()
	{
	}

	private void Start()
	{
	}

	private bool CheckRotationCompletion()
	{
		return default(bool);
	}

	private bool CheckTranslationCompletion()
	{
		return default(bool);
	}

	private void LockGunRotation()
	{
	}

	private void LockGunTranslation()
	{
	}

	private void LockGun()
	{
	}

	private void ReleaseGun()
	{
	}

	private void SetJoint(ConfigurableJoint joint)
	{
	}

	private IEnumerator MoveGun(bool isRising)
	{
		return null;
	}

	private void TranslateGun(bool isRising)
	{
	}

	private void RotateGun(bool isRising)
	{
	}

	[ContextMenu("Raise Gun")]
	public void RAISEGUN()
	{
	}

	[ContextMenu("Hide Gun")]
	public void HIDEGUN()
	{
	}

	public mineCartGunControl()
		: base()
	{
	}
}
