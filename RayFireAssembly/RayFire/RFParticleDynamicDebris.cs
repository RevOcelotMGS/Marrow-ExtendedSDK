using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFParticleDynamicDebris
	{
		[Range(0f, 10f)]
		[Space(3f)]
		[Header("  Speed")]
		public float speedMin;

		[Space(2f)]
		[Range(0f, 10f)]
		public float speedMax;

		[Space(3f)]
		[Header("  Inherit Velocity")]
		[Range(0f, 3f)]
		public float velocityMin;

		[Range(0f, 3f)]
		[Space(2f)]
		public float velocityMax;

		[Range(-2f, 2f)]
		[Space(3f)]
		[Header("  Gravity Modifier")]
		public float gravityMin;

		[Space(2f)]
		[Range(-2f, 2f)]
		public float gravityMax;

		[Header("  Rotation")]
		[Space(3f)]
		[Range(0f, 1f)]
		public float rotationSpeed;

		public void CopyFrom(RFParticleDynamicDebris source)
		{
		}

		public RFParticleDynamicDebris()
			: base()
		{
		}
	}
}
