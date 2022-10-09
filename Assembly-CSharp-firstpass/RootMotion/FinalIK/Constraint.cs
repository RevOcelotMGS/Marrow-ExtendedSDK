using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public abstract class Constraint
	{
		public Transform transform;

		public float weight;

		public bool isValid
		{
			get
			{
				return default(bool);
			}
		}

		public abstract void UpdateConstraint();

		public Constraint()
			: base()
		{
		}
	}
}
