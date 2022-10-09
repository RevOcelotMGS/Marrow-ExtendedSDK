using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFParticleCollisionDebris
	{
		public enum RFParticleCollisionMatType
		{
			ByPhysicalMaterial = 0,
			ByProperties = 1
		}

		[Header("  Common")]
		[Space(3f)]
		public LayerMask collidesWith;

		[Space(2f)]
		public ParticleSystemCollisionQuality quality;

		[Range(0.1f, 2f)]
		[Space(2f)]
		public float radiusScale;

		[Header("  Dampen")]
		[Space(3f)]
		public RFParticleCollisionMatType dampenType;

		[Range(0f, 1f)]
		[Space(2f)]
		public float dampenMin;

		[Range(0f, 1f)]
		[Space(2f)]
		public float dampenMax;

		[Space(3f)]
		[Header("  Bounce")]
		public RFParticleCollisionMatType bounceType;

		[Range(0f, 1f)]
		[Space(2f)]
		public float bounceMin;

		[Space(2f)]
		[Range(0f, 1f)]
		public float bounceMax;

		[HideInInspector]
		public bool propertiesSet;

		public void CopyFrom(RFParticleCollisionDebris source)
		{
		}

		public void SetMaterialProps(RayfireDebris debris)
		{
		}

		public RFParticleCollisionDebris()
			: base()
		{
		}
	}
}
