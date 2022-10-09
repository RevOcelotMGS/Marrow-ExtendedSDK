using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	public class RFCombineMesh
	{
		private List<int> trianglesSubId;

		private List<List<int>> triangles;

		private List<Vector3> vertices;

		private List<Vector3> normals;

		private List<Vector2> uvs;

		private List<Vector4> tangents;

		public static RFCombineMesh GetCombinedMesh(Transform transForm, List<Mesh> meshList, List<Transform> transList, List<List<int>> matIdList, List<bool> invertNormals)
		{
			return null;
		}

		public static Mesh CreateMesh(RFCombineMesh cMesh, string name)
		{
			return null;
		}

		public static Mesh CombineShatter(RayfireShatter shatter, Transform root, List<MeshFilter> filters)
		{
			return null;
		}

		private static void GetMeshTransMatLists(List<MeshFilter> filters, List<Mesh> meshList, List<Transform> transList, List<List<Material>> matList, int verts, float size)
		{
		}

		public static List<Material> GetAllMaterials(List<Transform> transList, List<List<Material>> matList)
		{
			return null;
		}

		public static List<List<int>> GetMatIdList(List<Transform> transList, List<List<Material>> matList, List<Material> allMaterials)
		{
			return null;
		}

		public static List<bool> GetInvertList(List<Transform> transList)
		{
			return null;
		}

		public RFCombineMesh()
			: base()
		{
		}
	}
}
