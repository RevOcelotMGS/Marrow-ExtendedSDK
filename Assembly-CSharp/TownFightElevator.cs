using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TownFightElevator : MonoBehaviour
{
	public Transform startObj;

	public Transform endObj;

	public Transform platform;

	[SerializeField]
	private float moveDuration;

	private Coroutine platformRoutine;

	private Vector3 startPos;

	private Vector3 endPos;

	private void Start()
	{
	}

	public void StartMotion()
	{
	}

	private IEnumerator MovePlatform()
	{
		return null;
	}

	public TownFightElevator()
		: base()
	{
	}
}
