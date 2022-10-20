using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class VehicleDamage : MonoBehaviour
{
	public enum WheelDamage
	{
		Off = 0,
		Visual = 1,
		Mechanical = 2
	}

	private struct originalMeshVerts
	{
		public Vector3[] meshVerts;
	}

	[SerializeField]
	private float health;

	[SerializeField]
	private float minCollisionForce;

	[SerializeField]
	private AudioClip[] crashClips;

	public bool useDamage;

	public WheelDamage wheelDamage;

	public float wheelDamageRadius;

	public float wheelDamageMultiplier;

	private originalMeshVerts[] originalMeshData;

	public MeshFilter[] deformableMeshFilters;

	public LayerMask damageFilter;

	public float randomizeVertices;

	public float damageRadius;

	private float minimumVertDistanceForDamagedMesh;

	public bool repairNow;

	public bool repaired;

	public float maximumDamage;

	public float damageMultiplier;

	private Vector3 localVector;

	private Quaternion rot;

	private void Awake()
	{
	}

	private void InitDamage()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void LoadOriginalMeshData()
	{
	}

	private void DeformMesh(Mesh mesh, Vector3[] originalMesh, Collision collision, float cos, Transform meshTransform, Quaternion rot)
	{
	}

	[ContextMenu("Repair")]
	public void StartRepair()
	{
	}

	private IEnumerator CoRepair()
	{
		return null;
	}

	public void Repair()
	{
	}

	public VehicleDamage()
		: base()
	{
	}
}
