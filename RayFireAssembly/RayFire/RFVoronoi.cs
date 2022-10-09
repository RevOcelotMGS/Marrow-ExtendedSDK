using System;

namespace RayFire
{
	[Serializable]
	public class RFVoronoi
	{
		public int amount;

		public float centerBias;

		public int Amount
		{
			get
			{
				return default(int);
			}
		}

		public RFVoronoi()
			: base()
		{
		}

		public RFVoronoi(RFVoronoi src)
			: this()
		{
		}
	}
}
