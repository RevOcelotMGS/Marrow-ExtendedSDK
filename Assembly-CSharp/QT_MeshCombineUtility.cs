using UnityEngine;

public class QT_MeshCombineUtility
{
	public struct MeshInstance
	{
		public Mesh mesh;

		public int subMeshIndex;

		public Matrix4x4 transform;
	}

	public static Mesh Combine(MeshInstance[] combines, bool generateStrips)
	{
		return null;
	}

	private static void Copy(int vertexcount, Vector3[] src, Vector3[] dst, int offset, Matrix4x4 transform)
	{
	}

	private static void CopyNormal(int vertexcount, Vector3[] src, Vector3[] dst, int offset, Matrix4x4 transform)
	{
	}

	private static void Copy(int vertexcount, Vector2[] src, Vector2[] dst, int offset)
	{
	}

	private static void CopyColors(int vertexcount, Color[] src, Color[] dst, int offset)
	{
	}

	private static void CopyTangents(int vertexcount, Vector4[] src, Vector4[] dst, int offset, Matrix4x4 transform)
	{
	}

	public QT_MeshCombineUtility()
		: base()
	{
	}
}
