using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

public class VoidSaber : MonoBehaviour
{
	public Grip triggerGrip;

	public GameObject bladeRoot;

	public Transform bladeTop;

	public Transform bladeBottom;

	public Transform com;

	public Transform onOffSwitch;

	public Transform dialGuage;

	public int bladeSegments;

	public float extendRate;

	public float extendRateModifier;

	public float retractRate;

	private bool isExtened;

	private bool isPrimaryButtonHeld;

	private IEnumerator bladeAnim;

	private List<lineSegment> previousPoints;

	private MaterialPropertyBlock LaserMaterialPropertyBlock;

	private Mesh laserTrailMesh;

	private MeshFilter LineTrailMesher;

	private Vector3[] vertices;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void InitializeMesh()
	{
	}

	private void MeshUpdate(Vector3 hitpoint, Vector3 lasthit)
	{
	}

	private void OnHandAttachedUpdate(Hand hand)
	{
	}

	private void OnTriggerGripAttached(Hand hand)
	{
	}

	private void OnTriggerGripDetached(Hand hand)
	{
	}

	private IEnumerator ExtendBlade()
	{
		return null;
	}

	private IEnumerator RetractBlade()
	{
		return null;
	}

	public VoidSaber()
		: base()
	{
	}
}
