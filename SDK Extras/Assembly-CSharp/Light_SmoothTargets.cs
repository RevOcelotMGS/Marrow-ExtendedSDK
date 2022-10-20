using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Light_SmoothTargets : MonoBehaviour
{
	public Transform target_Primary;

	public float distance;

	public float height;

	public float damping;

	public bool smoothRotation;

	public bool followBehind;

	public float rotationDamping;

	public Transform[] target_Interest;

	public float update_t;

	public int target_Default;

	private void Start()
	{
	}

	private IEnumerator UpdatePosition()
	{
		return null;
	}

	public Light_SmoothTargets()
		: base()
	{
	}
}
