using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	public class RFTriangle
	{
		public int id;

		public float area;

		public Vector3 normal;

		public Vector3 pos;

		public List<int> neibs;

		private static int[] triangles;

		private static Vector3[] vertices;

		private static Vector3[] normals;

		private RFTriangle(float Area, Vector3 Normal, Vector3 Pos)
			: base()
		{
		}

		public static void SetTriangles(RFShard shard)
		{
		}

		public static void Clear(RFShard shard)
		{
		}
	}
}
