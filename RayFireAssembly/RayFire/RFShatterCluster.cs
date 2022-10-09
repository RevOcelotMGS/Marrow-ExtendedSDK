using System;

namespace RayFire
{
	[Serializable]
	public class RFShatterCluster
	{
		public bool enable;

		public int count;

		public int seed;

		public float relax;

		public int amount;

		public int layers;

		public float scale;

		public int min;

		public int max;

		public RFShatterCluster()
			: base()
		{
		}

		public RFShatterCluster(RFShatterCluster src)
			: this()
		{
		}
	}
}
