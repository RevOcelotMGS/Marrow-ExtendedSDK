using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	[Serializable]
	public struct SoftJointLimitSpringExt
	{
		public float spring;

		public float damper;

		public SoftJointLimitSpringExt(SoftJointLimitSpring softJointLimitSpring)
		{
			this.damper = default(float);
			this.spring = default(float);
		}

		public SoftJointLimitSpring ToUnitySoftJointLimitSpring()
		{
			return default(SoftJointLimitSpring);
		}
	}
}
