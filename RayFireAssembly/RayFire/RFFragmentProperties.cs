using System;

namespace RayFire
{
	[Serializable]
	public class RFFragmentProperties
	{
		public RFColliderType colliderType;

		public float sizeFilter;

		public bool decompose;

		public bool removeCollinear;

		public string layer;

		public void CopyFrom(RFFragmentProperties fragmentProperties)
		{
		}

		public RFFragmentProperties()
			: base()
		{
		}
	}
}
