using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class ConstraintRotationOffset : Constraint
	{
		public Quaternion offset;

		private Quaternion defaultRotation;

		private Quaternion defaultLocalRotation;

		private Quaternion lastLocalRotation;

		private Quaternion defaultTargetLocalRotation;

		private bool initiated;

		private bool rotationChanged
		{
			get
			{
				return default(bool);
			}
		}

		public override void UpdateConstraint()
		{
		}

		public ConstraintRotationOffset()
			: base()
		{
		}

		public ConstraintRotationOffset(Transform transform)
			: this()
		{
		}
	}
}
