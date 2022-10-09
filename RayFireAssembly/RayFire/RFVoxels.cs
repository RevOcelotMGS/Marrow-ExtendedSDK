using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFVoxels
	{
		[Range(0.01f, 10f)]
		public float size;

		public RFVoxels()
			: base()
		{
		}
	}
}
