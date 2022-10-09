using System;
using UnityEngine;

[RequireComponent(typeof(ReflectionProbe))]
public class SetDoorWindowRefraction : MonoBehaviour
{
	[Serializable]
	public struct TargetMaterial
	{
		public Renderer renderer;

		public int matNumber;
	}

	public ReflectionProbe rp;

	public TargetMaterial[] targetMaterials;

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	public SetDoorWindowRefraction()
		: base()
	{
	}
}
