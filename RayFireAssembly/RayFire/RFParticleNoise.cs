using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFParticleNoise
	{
		[Space(3f)]
		[Header("  Main")]
		public bool enabled;

		[Space(2f)]
		public ParticleSystemNoiseQuality quality;

		[Space(3f)]
		[Range(0f, 3f)]
		[Header("  Strength")]
		public float strengthMin;

		[Space(2f)]
		[Range(0f, 3f)]
		public float strengthMax;

		[Range(0.001f, 3f)]
		[Header("  Other")]
		[Space(3f)]
		public float frequency;

		[Range(0f, 2f)]
		[Space(2f)]
		public float scrollSpeed;

		[Space(2f)]
		public bool damping;

		public void CopyFrom(RFParticleNoise source)
		{
		}

		public RFParticleNoise()
			: base()
		{
		}
	}
}
