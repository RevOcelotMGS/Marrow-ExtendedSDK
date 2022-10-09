using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFParticleEmission
	{
		[Header("  Burst")]
		[Space(3f)]
		public RFParticles.BurstType burstType;

		[Space(2f)]
		[Range(0f, 500f)]
		public int burstAmount;

		[Header("  Distance")]
		[Space(3f)]
		[Range(0f, 5f)]
		public float distanceRate;

		[Space(2f)]
		[Range(0.5f, 10f)]
		public float duration;

		[Range(1f, 60f)]
		[Space(3f)]
		[Header("  Lifetime")]
		public float lifeMin;

		[Range(1f, 60f)]
		[Space(2f)]
		public float lifeMax;

		[Header("  Size")]
		[Space(3f)]
		[Range(0.1f, 10f)]
		public float sizeMin;

		[Space(2f)]
		[Range(0.1f, 10f)]
		public float sizeMax;

		public void CopyFrom(RFParticleEmission source)
		{
		}

		public RFParticleEmission()
			: base()
		{
		}
	}
}
