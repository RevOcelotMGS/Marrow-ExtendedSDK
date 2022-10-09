using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		public class Pose
		{
			public bool visualize;

			public string name;

			public Vector3 direction;

			public float yaw;

			public float pitch;

			private float angleBuffer;

			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			public void SetAngleBuffer(float value)
			{
			}

			public Pose()
				: base()
			{
			}
		}

		public float angleBuffer;

		public Pose[] poses;

		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		public void SetPoseActive(Pose pose)
		{
		}

		public AimPoser()
			: base()
		{
		}
	}
}
