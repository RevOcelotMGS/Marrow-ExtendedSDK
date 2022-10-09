using System;

namespace RayFire
{
	[Serializable]
	public class RFTets
	{
		public enum TetType
		{
			Uniform = 0,
			Curved = 1
		}

		public TetType lattice;

		public int density;

		public int noise;

		public RFTets()
			: base()
		{
		}

		public RFTets(RFTets src)
			: this()
		{
		}
	}
}
