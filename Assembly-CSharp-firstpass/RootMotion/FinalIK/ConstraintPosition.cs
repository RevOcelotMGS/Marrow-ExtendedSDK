using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class ConstraintPosition : Constraint
	{
		public Vector3 position;

		public override void UpdateConstraint()
		{
		}

		public ConstraintPosition()
			: base()
		{
		}

		public ConstraintPosition(Transform transform)
			: this()
		{
		}
	}
}
