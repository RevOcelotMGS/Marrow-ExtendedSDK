using UnityEngine;

namespace RootMotion.FinalIK
{
	public class HandPoser : Poser
	{
		protected Transform[] children;

		private Transform _poseRoot;

		private Transform[] poseChildren;

		private Vector3[] defaultLocalPositions;

		private Quaternion[] defaultLocalRotations;

		public override void AutoMapping()
		{
		}

		protected override void InitiatePoser()
		{
		}

		protected override void FixPoserTransforms()
		{
		}

		protected override void UpdatePoser()
		{
		}

		protected void StoreDefaultState()
		{
		}

		public HandPoser()
			: base()
		{
		}
	}
}
