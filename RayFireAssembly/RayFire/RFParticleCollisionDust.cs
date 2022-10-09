using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFParticleCollisionDust
	{
		[Space(3f)]
		[Header("  Common")]
		public LayerMask collidesWith;

		[Space(2f)]
		public ParticleSystemCollisionQuality quality;

		[Space(2f)]
		[Range(0.1f, 2f)]
		public float radiusScale;

		public void CopyFrom(RFParticleCollisionDust source)
		{
		}

		public RFParticleCollisionDust()
			: base()
		{
		}
	}
}
