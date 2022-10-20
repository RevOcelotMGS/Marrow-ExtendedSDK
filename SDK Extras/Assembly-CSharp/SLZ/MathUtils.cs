using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ
{
	public static class MathUtils
	{
		public static readonly float Epsilon;

		public static float _sqrt_2;

		public static void DecomposeSwingTwist(Quaternion q, Vector3 twistAxis, [Out] Quaternion swing, [Out] Quaternion twist)
		{
		}

		public static void CalculateDelta(float pos, float rot, float lastPos, float lastRot, [Out] float posDelta, [Out] float rotDelta)
		{
		}

		public static float Magnitude([In] Quaternion q)
		{
			return default(float);
		}

		public static Quaternion Normalize([In] Quaternion q)
		{
			return default(Quaternion);
		}

		public static bool IsQuaternionNan([In] Quaternion rotation)
		{
			return default(bool);
		}

		public static Vector3 FastRotateTowards([In] Vector3 lhsNorm, [In] Vector3 rhsNorm, float targetAngle)
		{
			return default(Vector3);
		}

		public static Vector3 OrthoNormalVectorFast([In] Vector3 v)
		{
			return default(Vector3);
		}

		public static Quaternion LimitSwingTwistRotation([In] Quaternion q, [In] Vector3 primaryAxis, [In] float swingLimit, [In] float twistLimit)
		{
			return default(Quaternion);
		}

		public static Quaternion SoftLimitSwingTwistRotation([In] Quaternion q, [In] Vector3 primaryAxis, [In] float swingSoftLimit, [In] float swingHardLimit, [In] float twistSoftLimit, [In] float twistHardLimit)
		{
			return default(Quaternion);
		}
	}
}
