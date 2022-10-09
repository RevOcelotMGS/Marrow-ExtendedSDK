using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	[Serializable]
	public struct JointDriveExt
	{
		public float positionSpring;

		public float positionDamper;

		public float maximumForce;

		public JointDriveExt(JointDrive drive)
		{
			this.maximumForce = default(float);
			this.positionDamper = default(float);
			this.positionSpring = default(float);
		}

		public JointDrive ToUnityJointDrive()
		{
			return default(JointDrive);
		}
	}
}
