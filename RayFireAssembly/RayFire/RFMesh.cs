using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFMesh
	{
		[Serializable]
		public class RFSubMeshTris
		{
			public List<int> triangles;

			public RFSubMeshTris()
				: base()
			{
			}

			public RFSubMeshTris(List<int> tris)
				: this()
			{
			}
		}

		public bool compress;

		public int subMeshCount;

		public Bounds bounds;

		public int[] triangles;

		public List<RFSubMeshTris> subTriangles;

		public Vector2[] uv;

		public Vector3[] vertices;

		public Vector4[] tangents;

		public List<int> uvComp;

		public List<int> verticesComp;

		public List<int> tangentsComp;

		public RFMesh(Mesh mesh, bool comp = false)
			: base()
		{
		}

		public Mesh GetMesh()
		{
			return null;
		}

		private void LoadTriangles(Mesh mesh)
		{
		}

		public static Mesh BakeMesh(SkinnedMeshRenderer skin)
		{
			return null;
		}

		public static void ConvertRfMeshes(RayfireRigid rigid)
		{
		}

		private static Vector2[] SetCompressedUv(List<int> uvComp)
		{
			return null;
		}

		private static Vector3[] SetCompressedVertices(List<int> verticesComp)
		{
			return null;
		}

		private static Vector4[] SetCompressedTangents(List<int> tangentsComp)
		{
			return null;
		}
	}
}
