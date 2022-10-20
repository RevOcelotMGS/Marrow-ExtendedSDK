using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	public sealed class HandActionMap : XRHand
	{
		private Dictionary<HandFinger, List<Bone>> _bones;

		private bool _isLeft;

		private bool _hasFeature;

		private HandTrackingFeature handTrackingFeature;

		public static Quaternion LeftAnimSpace;

		public static Quaternion RightAnimSpace;

		private SimpleTransform[] _worldBuffer;

		public HandActionMap(bool left)
			: base()
		{
		}

		private bool TryPickBestHandDevice(bool left)
		{
			return default(bool);
		}

		public override void OnPostNewInputUpdate()
		{
		}

		private void ProcessesHand()
		{
		}

		private void CalcLocalPose(HandBone parentBone, HandBone childBone)
		{
		}
	}
}
