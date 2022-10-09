using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class EffectorOffset : OffsetModifier
	{
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		public Vector3 bodyOffset;

		public Vector3 leftShoulderOffset;

		public Vector3 rightShoulderOffset;

		public Vector3 leftThighOffset;

		public Vector3 rightThighOffset;

		public Vector3 leftHandOffset;

		public Vector3 rightHandOffset;

		public Vector3 leftFootOffset;

		public Vector3 rightFootOffset;

		protected override void OnModifyOffset()
		{
		}

		public EffectorOffset()
			: base()
		{
		}
	}
}
