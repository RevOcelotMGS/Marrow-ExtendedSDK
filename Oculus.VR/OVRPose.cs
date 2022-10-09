using System;
using UnityEngine;

[Serializable]
public struct OVRPose
{
	public Vector3 position;

	public Quaternion orientation;

	public override bool Equals(object obj)
	{
		return default(bool);
	}

	public override int GetHashCode()
	{
		return default(int);
	}
}
