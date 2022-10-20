using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ImplosionProjectile : MonoBehaviour
{
	[SerializeField]
	private LayerMask LayerFilter;

	public Collider sphere;

	public float implosionForceMultiplier;

	public float implosionForceClamp;

	private List<Rigidbody> allRBs;

	private List<Rigidbody> filteredRBs;

	public bool fire;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private IEnumerator ImplosionCoroutine()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public ImplosionProjectile()
		: base()
	{
	}
}
