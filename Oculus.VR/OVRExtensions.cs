using UnityEngine;

public static class OVRExtensions
{
	public static OVRPose ToOVRPose(this OVRPlugin.Posef p)
	{
		return default(OVRPose);
	}

	public static Quaternion FromFlippedXQuatf(this OVRPlugin.Quatf q)
	{
		return default(Quaternion);
	}
}
