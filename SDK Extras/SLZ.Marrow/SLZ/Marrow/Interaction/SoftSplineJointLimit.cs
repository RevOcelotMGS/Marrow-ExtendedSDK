using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public struct SoftSplineJointLimit
	{
		[SerializeField]
		public float limit;

		[SerializeField]
		public float bounciness;

		[SerializeField]
		public float contactDistance;

		public SoftSplineJointLimit(float limit, float bounciness, float contactDistance)
		{
			this.contactDistance = default(float);
			this.bounciness = default(float);
			this.limit = default(float);
		}
	}
}
