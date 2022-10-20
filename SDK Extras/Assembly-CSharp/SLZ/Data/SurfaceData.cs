using System;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Data
{
	[Serializable]
	[CreateAssetMenu(fileName = "Surface", menuName = "Variables/Surface", order = 10)]
	public class SurfaceData : ScriptableObject
	{
		[Header("Options")]
		[Range(0.001f, 1f)]
		public float PenetrationResistance;

		public float megaPascal;

		public bool isFlammable;

		public float fireResistance;

		[ColorUsage(true, true)]
		public Color ParicleColorTint;

		[Header("References")]
		public PhysicMaterial physicMaterial;

		public Spawnable impactEffectSpawnable;

		public Spawnable bulletDecalSpawnable;

		public Material BulletDecal;

		public Material BluntDecal;

		public SurfaceData()
			: base()
		{
		}
	}
}
