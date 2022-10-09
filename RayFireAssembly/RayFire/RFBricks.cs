using System;

namespace RayFire
{
	[Serializable]
	public class RFBricks
	{
		public enum RFBrickType
		{
			ByAmount = 0,
			BySize = 1
		}

		public RFBrickType amountType;

		public float mult;

		public int amount_X;

		public int amount_Y;

		public int amount_Z;

		public bool size_Lock;

		public float size_X;

		public float size_Y;

		public float size_Z;

		public int sizeVar_X;

		public int sizeVar_Y;

		public int sizeVar_Z;

		public float offset_X;

		public float offset_Y;

		public float offset_Z;

		public bool split_X;

		public bool split_Y;

		public bool split_Z;

		public int split_probability;

		public float split_offset;

		public int split_rotation;

		public RFBricks()
			: base()
		{
		}
	}
}
