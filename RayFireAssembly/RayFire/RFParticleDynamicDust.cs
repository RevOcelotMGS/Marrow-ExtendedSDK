using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFParticleDynamicDust
	{
		[Range(0f, 10f)]
		[Header("  Speed")]
		[Space(3f)]
		public float speedMin;

		[Range(0f, 10f)]
		[Space(2f)]
		public float speedMax;

		[Header("  Rotation")]
		[Space(3f)]
		[Range(0f, 1f)]
		public float rotation;

		[Range(-2f, 2f)]
		[Header("  Gravity Modifier")]
		[Space(3f)]
		public float gravityMin;

		[Range(-2f, 2f)]
		[Space(2f)]
		public float gravityMax;

		public void CopyFrom(RFParticleDynamicDust source)
		{
		}

		public RFParticleDynamicDust()
			: base()
		{
		}
	}
}
