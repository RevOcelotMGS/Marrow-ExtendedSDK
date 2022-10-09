using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFParticleLimitations
	{
		[Range(3f, 100f)]
		[Header("  Particle system")]
		[Space(3f)]
		public int minParticles;

		[Space(2f)]
		[Range(5f, 100f)]
		public int maxParticles;

		[Header("  Fragments")]
		[Space(3f)]
		[Range(10f, 100f)]
		public int percentage;

		[Space(2f)]
		[Range(0.05f, 5f)]
		public float sizeThreshold;

		[HideInInspector]
		[Range(0f, 5f)]
		public int demolitionDepth;

		public void CopyFrom(RFParticleLimitations source)
		{
		}

		public RFParticleLimitations()
			: base()
		{
		}
	}
}
