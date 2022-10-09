using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFFlash
	{
		[Space(3f)]
		[Range(0.1f, 5f)]
		[Header("  Intensity")]
		public float intensityMin;

		[Space(1f)]
		[Range(0.1f, 5f)]
		public float intensityMax;

		[Header("  Range")]
		[Range(0.01f, 10f)]
		[Space(3f)]
		public float rangeMin;

		[Space(1f)]
		[Range(0.01f, 10f)]
		public float rangeMax;

		[Header("  Other")]
		[Space(3f)]
		[Range(0.01f, 2f)]
		public float distance;

		[Space(1f)]
		public Color color;

		public RFFlash()
			: base()
		{
		}
	}
}
