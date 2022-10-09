using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFSlice
	{
		public PlaneType plane;

		public List<Transform> sliceList;

		public RFSlice()
			: base()
		{
		}

		public RFSlice(RFSlice src)
			: this()
		{
		}

		public Vector3 Axis(Transform tm)
		{
			return default(Vector3);
		}
	}
}
