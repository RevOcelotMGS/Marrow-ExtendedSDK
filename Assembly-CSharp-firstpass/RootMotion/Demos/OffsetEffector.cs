using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		public class EffectorLink
		{
			public FullBodyBipedEffector effectorType;

			public float weightMultiplier;

			[HideInInspector]
			public Vector3 localPosition;

			public EffectorLink()
				: base()
			{
			}
		}

		public EffectorLink[] effectorLinks;

		protected override void Start()
		{
		}

		protected override void OnModifyOffset()
		{
		}

		public OffsetEffector()
			: base()
		{
		}
	}
}
