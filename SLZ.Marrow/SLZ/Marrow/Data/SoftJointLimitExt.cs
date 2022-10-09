using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	[Serializable]
	public struct SoftJointLimitExt
	{
		public float limit;

		public float bounciness;

		public float contactDistance;

		public SoftJointLimitExt(SoftJointLimit softJointLimit)
		{
			this.contactDistance = default(float);
			this.bounciness = default(float);
			this.limit = default(float);
		}

		public SoftJointLimit ToUnitySoftJointLimit()
		{
			return default(SoftJointLimit);
		}
	}
}
