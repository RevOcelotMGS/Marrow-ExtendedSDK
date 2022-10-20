using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ConstructionElevator : MonoBehaviour
{
	[SerializeField]
	private bool moveOnStart;

	[SerializeField]
	private ConfigurableJoint joint;

	[SerializeField]
	private float duration;

	[SerializeField]
	private float fallDuration;

	[SerializeField]
	private Vector3 startPos;

	[SerializeField]
	private Vector3 endPos;

	[SerializeField]
	private Vector3 startFallPos;

	[SerializeField]
	private Vector3 endFallPos;

	[SerializeField]
	private ConfigurableJoint doorJoint;

	[SerializeField]
	private GameObject trellisObj;

	[SerializeField]
	private Transform lookTarg;

	private bool isLooking;

	[SerializeField]
	private Rigidbody[] trellisBodies;

	[SerializeField]
	private BoxCollider[] trellisCols;

	private Coroutine vatorRoutine;

	private void Start()
	{
	}

	public void MoveUp()
	{
	}

	private IEnumerator CoVatorRoutine()
	{
		return null;
	}

	private IEnumerator CoTrellisSway()
	{
		return null;
	}

	public ConstructionElevator()
		: base()
	{
	}
}
