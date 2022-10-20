using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AscentElevator : MonoBehaviour
{
	public Transform startObj;

	public Transform endObj;

	public Transform platform;

	[SerializeField]
	private float moveDuration;

	private Coroutine platformRoutine;

	private Vector3 startPos;

	private Vector3 endPos;

	public void StartMotion()
	{
	}

	private IEnumerator MovePlatform()
	{
		return null;
	}

	public AscentElevator()
		: base()
	{
	}
}
