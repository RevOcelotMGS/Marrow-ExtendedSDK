using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFDecals
	{
		public bool enable;

		[Range(0.1f, 5f)]
		[Space(2f)]
		[Header("  Size")]
		public float sizeMin;

		[Range(0.1f, 5f)]
		[Space(1f)]
		public float sizeMax;

		[Range(0.01f, 2f)]
		[Space(2f)]
		[Header("  Limitations")]
		public float distance;

		public RFDecals()
			: base()
		{
		}
	}
}
