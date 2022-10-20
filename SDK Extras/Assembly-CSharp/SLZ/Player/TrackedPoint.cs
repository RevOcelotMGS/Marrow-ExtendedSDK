using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Player
{
	public struct TrackedPoint
	{
		public enum Type
		{
			INVALID = -1,
			HMD = 0,
			LEFTHAND = 1,
			RIGHTHAND = 2,
			OTHER = 3,
			ROOT = 4
		}

		public Type type;

		public Vector3 position;

		public Quaternion rotation;

		public static readonly TrackedPoint leftHand;

		public static readonly TrackedPoint rightHand;

		public static readonly TrackedPoint hmd;

		public static readonly TrackedPoint root;

		public static readonly TrackedPoint invalid;

		public TrackedPoint(Type t, Vector3 pos = default(Vector3), Quaternion rot = default(Quaternion))
		{
			this.rotation = default(Quaternion);
			this.position = default(Vector3);
			this.type = default(Type);
		}
	}
}
