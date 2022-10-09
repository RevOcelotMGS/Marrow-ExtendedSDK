using System;
using UnityEngine;

[Serializable]
public class CabletSeUp
{
	public GameObject Cable;

	[Tooltip("If you need a motor, then add a motor spawner")]
	public GameObject Motor;

	public Transform Parent;

	public Transform StartPoint;

	public Transform EndPoint;

	[Space(3f)]
	[Tooltip("For now default it to a Frictionless material")]
	public PhysicMaterial PhysicsMaterial;

	public float velocity;

	public float gripRadius;

	public float colRadius;

	public float subdivisions;

	[Space(3f)]
	public Vector2 Scale;

	public CabletSeUp()
		: base()
	{
	}
}
