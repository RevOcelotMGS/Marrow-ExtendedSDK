using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFShatterAdvanced
	{
		public int seed;

		public bool decompose;

		public bool removeCollinear;

		public bool copyComponents;

		public bool postWeld;

		public bool smooth;

		public bool inputPrecap;

		public bool outputPrecap;

		public bool removeDoubleFaces;

		public int elementSizeThreshold;

		public bool combineChildren;

		public bool inner;

		public bool planar;

		public int relativeSize;

		public float absoluteSize;

		public bool vertexLimitation;

		public int vertexAmount;

		public static float planarThreshold;

		public RFShatterAdvanced()
			: base()
		{
		}

		public RFShatterAdvanced(RFShatterAdvanced src)
			: this()
		{
		}

		public static bool IsCoplanar(Mesh mesh, float threshold)
		{
			return default(bool);
		}
	}
}
