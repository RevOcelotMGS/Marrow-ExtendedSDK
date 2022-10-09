using UnityEngine;

namespace RootMotion.FinalIK
{
	public static class RotationLimitUtilities
	{
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, Quaternion lastRotation, float lastAngle)
		{
			return default(Quaternion);
		}

		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
}
