using System;

namespace RayFire
{
	[Serializable]
	public class RFSplinters
	{
		public AxisType axis;

		public int amount;

		public float strength;

		public float centerBias;

		public int Amount
		{
			get
			{
				return default(int);
			}
		}

		public RFSplinters()
			: base()
		{
		}

		public RFSplinters(RFSplinters src)
			: this()
		{
		}
	}
}
