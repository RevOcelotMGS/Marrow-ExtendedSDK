using UnityEngine;

namespace RootMotion.FinalIK
{
	public class FBBIKArmBending : MonoBehaviour
	{
		public FullBodyBipedIK ik;

		public Vector3 bendDirectionOffsetLeft;

		public Vector3 bendDirectionOffsetRight;

		public Vector3 characterSpaceBendOffsetLeft;

		public Vector3 characterSpaceBendOffsetRight;

		private Quaternion leftHandTargetRotation;

		private Quaternion rightHandTargetRotation;

		private bool initiated;

		private void LateUpdate()
		{
		}

		private void OnPostFBBIK()
		{
		}

		private void OnDestroy()
		{
		}

		public FBBIKArmBending()
			: base()
		{
		}
	}
}
