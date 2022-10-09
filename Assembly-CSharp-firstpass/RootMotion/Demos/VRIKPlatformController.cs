using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class VRIKPlatformController : MonoBehaviour
	{
		public VRIK ik;

		public Transform trackingSpace;

		public Transform platform;

		public bool moveToPlatform;

		private Transform lastPlatform;

		private Vector3 lastPosition;

		private Quaternion lastRotation;

		private void LateUpdate()
		{
		}

		public VRIKPlatformController()
			: base()
		{
		}
	}
}
