using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class ConstraintRotation : Constraint
	{
		public Quaternion rotation;

		public override void UpdateConstraint()
		{
		}

		public ConstraintRotation()
			: base()
		{
		}

		public ConstraintRotation(Transform transform)
			: this()
		{
		}
	}
}
