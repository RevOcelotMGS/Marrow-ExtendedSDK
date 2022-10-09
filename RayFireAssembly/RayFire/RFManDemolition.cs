using System;

namespace RayFire
{
	[Serializable]
	public class RFManDemolition
	{
		public enum FragmentParentType
		{
			Manager = 0,
			Parent = 1
		}

		public FragmentParentType parent;

		public int maximumAmount;

		public int badMeshTry;

		public float sizeThreshold;

		public int currentAmount;

		public RFManDemolition()
			: base()
		{
		}
	}
}
