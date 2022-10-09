using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFCustom
	{
		public enum RFPointCloudSourceType
		{
			ChildrenTransform = 4,
			TransformList = 8,
			Vector3List = 12
		}

		public enum RFPointCloudUseType
		{
			VolumePoints = 4,
			PointCloud = 12
		}

		public enum RFModifierType
		{
			None = 0,
			Splinters = 3,
			Slabs = 6
		}

		public RFPointCloudSourceType source;

		public RFPointCloudUseType useAs;

		public int amount;

		public float radius;

		public bool enable;

		public float size;

		public List<Transform> transforms;

		public List<Vector3> vector3;

		public bool noPoints;

		public RFCustom()
			: base()
		{
		}

		public RFCustom(RFCustom src)
			: this()
		{
		}

		public static List<Vector3> GetCustomPointCLoud(RFCustom custom, Transform tm, int seed, Bounds bound)
		{
			return null;
		}

		private static List<Vector3> GetCustomInputCloud(RFCustom custom, Transform tm)
		{
			return null;
		}

		private static List<Vector3> GetCustomOutputCloud(RFCustom custom, List<Vector3> inputPoints, int seed, Bounds bound)
		{
			return null;
		}

		private static List<Vector3> GetCustomBoundPoints(List<Vector3> inputPoints, Bounds bound)
		{
			return null;
		}

		private static Vector3 RandomPointInRadius(Vector3 point, float radius)
		{
			return default(Vector3);
		}

		private static Vector3 RandomVector()
		{
			return default(Vector3);
		}
	}
}
