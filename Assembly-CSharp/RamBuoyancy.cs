using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RamBuoyancy : MonoBehaviour
{
	public float buoyancy;

	public float viscosity;

	public float viscosityAngular;

	public LayerMask layer;

	public Collider collider;

	[Range(2f, 10f)]
	public int pointsInAxis;

	private Rigidbody rigidbody;

	private static RamSpline[] ramSplines;

	private static LakePolygon[] lakePolygons;

	public List<Vector3> volumePoints;

	public bool autoGenerateVolumePoints;

	private Vector3[] volumePointsMatrix;

	private Vector3 lowestPoint;

	private Vector3 center;

	public bool debug;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void WaterPhysics()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public RamBuoyancy()
		: base()
	{
	}
}
