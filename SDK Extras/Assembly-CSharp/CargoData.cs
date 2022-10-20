using System;
using UnityEngine;

[Serializable]
public class CargoData
{
	public Rigidbody rb;

	public Vector3 grabPoint;

	public Vector3 dropPoint;

	public CargoData()
		: base()
	{
	}
}
