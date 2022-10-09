using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class VRIKPlatform : MonoBehaviour
	{
		public VRIK ik;

		private Vector3 lastPosition;

		private Quaternion lastRotation;

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		public VRIKPlatform()
			: base()
		{
		}
	}
}
