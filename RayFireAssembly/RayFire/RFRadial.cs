using System;

namespace RayFire
{
	[Serializable]
	public class RFRadial
	{
		public AxisType centerAxis;

		public float radius;

		public float divergence;

		public bool restrictToPlane;

		public int rings;

		public int focus;

		public int focusStr;

		public int randomRings;

		public int rays;

		public int randomRays;

		public int twist;

		public RFRadial()
			: base()
		{
		}

		public RFRadial(RFRadial src)
			: this()
		{
		}
	}
}
