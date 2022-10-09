using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFMirrored
	{
		public int amount;

		public PlaneType planeType;

		[HideInInspector]
		public bool noPoints;

		public static List<Vector3> GetMirroredPointCLoud(RFMirrored mirror, Transform tm, int seed, Bounds bound)
		{
			return null;
		}

		public RFMirrored()
			: base()
		{
		}
	}
}
