using UnityEngine;

namespace RootMotion.FinalIK
{
	public class BodyTilt : OffsetModifier
	{
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		private float tiltAngle;

		private Vector3 lastForward;

		protected override void Start()
		{
		}

		protected override void OnModifyOffset()
		{
		}

		public BodyTilt()
			: base()
		{
		}
	}
}
