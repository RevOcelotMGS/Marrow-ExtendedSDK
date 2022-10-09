using System.Runtime.InteropServices;
using UnityEngine;

public static class ConfigurableJointExtensions
{
	public static Quaternion GetJointSpace(this ConfigurableJoint joint)
	{
		return default(Quaternion);
	}

	public static void SetTargetPositionLocal(this ConfigurableJoint joint, Vector3 targetLocalPosition, Quaternion targetLocalRotation, Quaternion startLocalRotation)
	{
	}

	public static void SetTargetPositionLocal(this ConfigurableJoint joint, Vector3 targetLocalPosition, Quaternion targetLocalRotation, Quaternion startLocalRotation, Quaternion worldToJointSpace)
	{
	}

	public static void SetTargetRotationLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation)
	{
	}

	public static void SetTargetRotationLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation, Quaternion worldToJointSpace)
	{
	}

	public static void SetTargetRotation(this ConfigurableJoint joint, Quaternion targetWorldRotation, Quaternion startWorldRotation)
	{
	}

	public static void SetTargetRotation(this ConfigurableJoint joint, Quaternion targetWorldRotation, Quaternion startWorldRotation, Quaternion worldToJointSpace)
	{
	}

	private static void SetTargetPositionInternal(ConfigurableJoint joint, Vector3 targetPosition, Quaternion targetRotation, Quaternion startRotation, Quaternion worldToJointSpace, Space space)
	{
	}

	private static void SetTargetRotationInternal(ConfigurableJoint joint, Quaternion targetRotation, Quaternion startRotation, Quaternion worldToJointSpace, Space space)
	{
	}

	public static void SetTargetRotationAndAngVelocityLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation, float deltaTime)
	{
	}

	public static void SetTargetRotationAndAngVelocityLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation, Quaternion worldToJointSpace, float deltaTime)
	{
	}

	private static void SetTargetRotationAndAngVelocityInternal(ConfigurableJoint joint, Quaternion targetRotation, Quaternion startRotation, Quaternion worldToJointSpace, Space space, float deltaTime)
	{
	}

	public static Vector3 CalculateAngVelocity(Quaternion startRotation, Quaternion endRotation, float deltaTime)
	{
		return default(Vector3);
	}

	public static void SetupAsCharacterJoint(this ConfigurableJoint joint)
	{
	}

	public static Vector3 GetAxisInWorld(this ConfigurableJoint joint)
	{
		return default(Vector3);
	}

	public static Vector3 GetSecondaryAxisInWorld(this ConfigurableJoint joint)
	{
		return default(Vector3);
	}

	public static Vector3 GetConnectedAnchorInWorld(this ConfigurableJoint joint)
	{
		return default(Vector3);
	}

	public static float GetTwistInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation)
	{
		return default(float);
	}

	public static float GetTwistInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest)
	{
		return default(float);
	}

	private static float GetTwistInDegreesInternal(ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest)
	{
		return default(float);
	}

	public static float GetTwistInLimitPercent(this ConfigurableJoint joint, Quaternion startLocalRotation)
	{
		return default(float);
	}

	public static float GetSwingInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation, [Out] float yDegrees, [Out] float zDegrees)
	{
		return default(float);
	}

	public static float GetSwingInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest, [Out] float yDegrees, [Out] float zDegrees)
	{
		return default(float);
	}

	public static float GetSwingInLimitPercent(this ConfigurableJoint joint, Quaternion startLocalRotation, [Out] float yPercent, [Out] float zPercent)
	{
		return default(float);
	}

	private static float GetSwingCosineInternal(ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest, [Out] Vector2 direction)
	{
		return default(float);
	}
}
