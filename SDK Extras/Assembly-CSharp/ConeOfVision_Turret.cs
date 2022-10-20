using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ConeOfVision_Turret : MonoBehaviour
{
	private Collider[] m_CollectedColliders;

	private Collider[] m_SortedColliders;

	private int m_MaxCollidersCollected;

	private int m_CoolidersCount;

	public float visionRadius;

	public float visionAngle;

	public Enemy_Turret turret;

	public LayerMask mask;

	[ColorUsage(true, true)]
	public Color idleColor;

	[ColorUsage(true, true)]
	public Color aggroColor;

	public Transform acquiredTarget;

	private Coroutine visionCheckCoroutine;

	public bool IsOverlapping { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void VisionCheck()
	{
	}

	private IEnumerator CoVisionCheck()
	{
		return null;
	}

	public void OnVisionEnter(Transform target)
	{
	}

	public void OnVisionExit()
	{
	}

	public ConeOfVision_Turret()
		: base()
	{
	}
}
